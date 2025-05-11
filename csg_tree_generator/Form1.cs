using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace csg_tree_generator;
public enum MouseMode
{
    None,
    MoveNode,
    MoveScene,
    MoveTree
}



public partial class mainWindow : Form
{

    CanvasCordinates lastMousePoint;
    CanvasCordinates lastClickPoint;
    Scene scene;
    MouseMode mouseMode = MouseMode.None;


    string csgProgramPath = "";
    string saving_tree_path = "tree.txt";
    string camera_path = "camera.ini";


    public mainWindow()
    {
        InitializeComponent();

        this.SetStyle(
           System.Windows.Forms.ControlStyles.UserPaint |
           System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
           System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
           true);

        scene = new Scene();
        LoadSettings();
    }
    private void LoadSettings()
    {
        csgProgramPath = Properties.Settings.Default.Csg_viewer_path;
    }

    private void mainWindow_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.Clear(Color.White);

        scene.DrawTrees(e.Graphics);
    }

    private void mainWindow_MouseMove(object sender, MouseEventArgs e)
    {
        switch (mouseMode)
        {
            case MouseMode.MoveNode:
                CanvasCordinates canvasCordinates = new CanvasCordinates(e.X, e.Y);
                scene.SelectedNode.WorldCordinates = canvasCordinates.WorldCordinates(scene.camera);
                break;

            case MouseMode.MoveScene:
                scene.camera.x += (e.X - lastMousePoint.X);
                scene.camera.y += (e.Y - lastMousePoint.Y);
                break;

            case MouseMode.MoveTree:
                WorldCordinates worldCordinates = new CanvasCordinates(e.X, e.Y).WorldCordinates(scene.camera);
                WorldCordinates worldCortinates2 = lastMousePoint.WorldCordinates(scene.camera);
                int dx = worldCordinates.X - worldCortinates2.X;
                int dy = worldCordinates.Y - worldCortinates2.Y;
                scene.MoveWholeTree(scene.SelectedNode, dx, dy);
                break;
        }
        lastMousePoint = new CanvasCordinates(e.X, e.Y);
        Invalidate();
    }
    protected override void OnMouseWheel(MouseEventArgs e)
    {
        base.OnMouseWheel(e);

        if (e.Delta > 0)
        {
            scene.camera.scale *= 1.1f;
        }
        else
        {
            scene.camera.scale /= 1.1f;
        }
        Invalidate();
    }

    private void mainWindow_MouseUp(object sender, MouseEventArgs e)
    {
        WorldCordinates worldCordinates = new CanvasCordinates(e.X, e.Y).WorldCordinates(scene.camera);
        CanvasCordinates canvasCordinates = new CanvasCordinates(e.X, e.Y);
        Node node = scene.SelectedNode;


        if (e.Button == MouseButtons.Left)
        {

        }
        else if (e.Button == MouseButtons.Right)
        {
            if (lastClickPoint.X == canvasCordinates.X && lastClickPoint.Y == canvasCordinates.Y)
            {
                if (node != null)
                {
                    editShapeToolStripMenuItem.Enabled = (node.type == NodeType.Sphere || node.type == NodeType.Cube || node.type == NodeType.Cylinder);
                    ctxNodeMenu.Show(this, e.Location);
                }
                else
                {
                    ctxSceneMenu.Show(this, e.Location);
                }
            }
            else
            {
                // joining trees
                if (mouseMode == MouseMode.MoveTree)
                {
                    foreach (Node root in scene.trees)
                    {
                        Node? nodeDetected = root.DetectNode(worldCordinates);
                        if (nodeDetected == null || scene.SelectedNode == nodeDetected) continue;

                        if (scene.JoinTrees(nodeDetected)) break;
                    }
                }
            }
        }

        mouseMode = MouseMode.None;
    }



    private void mainWindow_MouseDown(object sender, MouseEventArgs e)
    {
        WorldCordinates worldCordinates = new CanvasCordinates(e.X, e.Y).WorldCordinates(scene.camera);
        lastMousePoint = new CanvasCordinates(e.X, e.Y);
        lastClickPoint = new CanvasCordinates(e.X, e.Y);

        Node? node = scene.GetNode(worldCordinates);
        if (node != null)
        {
            scene.SelectedNode = node;
        }

        if (e.Button == MouseButtons.Left)
        {
            if (node != null)
            {
                mouseMode = MouseMode.MoveNode;
            }
            else
            {
                mouseMode = MouseMode.MoveScene;
            }
        }
        else if (e.Button == MouseButtons.Right)
        {
            mouseMode = MouseMode.MoveTree;
        }
        else if (e.Button == MouseButtons.Middle)
        {
            if (node != null)
            {
                mouseMode = MouseMode.MoveTree;
            }

        }

        Invalidate();
    }


    private void btnSave_Click(object sender, EventArgs e)
    {
        if (scene.SelectedNode.EditShape(txtEdit.Text))
            txtEdit.Text = "";
    }


    private void selectedTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Tree to File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    scene.ExportTree(scene.SelectedNode, saveFileDialog.FileName);
                }
            }
        }
        catch (ExportException ex)
        {
            MessageBox.Show(ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private string SelectCsgViewerProgramPath()
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog.Title = "Select CSG Program";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                csgProgramPath = openFileDialog.FileName;
                return csgProgramPath;
            }
        }
        return string.Empty;
    }

    private void btnResult_Click(object sender, EventArgs e)
    {
        if (csgProgramPath == "" && SelectCsgViewerProgramPath() == string.Empty)
        {
            MessageBox.Show("No CSG program selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            scene.ExportTree(scene.SelectedNode, saving_tree_path);
        }
        catch (ExportException ex)
        {
            MessageBox.Show(ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            string arguments = chBoxCameraUse.Checked ? $"\"{saving_tree_path}\"" : $"\"{saving_tree_path}\" \"{camera_path}\"";
            var processStartInfo = new ProcessStartInfo
            {
                FileName = csgProgramPath,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            var process = new Process();
            process.StartInfo = processStartInfo;

            process.OutputDataReceived += (sender, args) =>
            {
                if (!string.IsNullOrWhiteSpace(args.Data))
                    Debug.WriteLine("[OUT] " + args.Data);
            };

            process.ErrorDataReceived += (sender, args) =>
            {
                if (!string.IsNullOrWhiteSpace(args.Data))
                {
                    Debug.WriteLine("[ERR] " + args.Data);
                    MessageBox.Show(args.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Failed to start external program", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void mainWindow_FormClosed(object sender, FormClosedEventArgs e)
    {
        //Saving settings
        Properties.Settings.Default.Csg_viewer_path = csgProgramPath;
        Properties.Settings.Default.Save();
    }

    private void selectToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SelectCsgViewerProgramPath();
    }

    private void importToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Import Tree from File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    scene.ImportTree(openFileDialog.FileName);
                }
                catch (ImportException ex)
                {
                    MessageBox.Show(ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Invalidate();
            }
        }
    }

    private void txtGenerateShapes_Click(object sender, EventArgs e)
    {
        if (scene.SelectedNode == null)
        {
            MessageBox.Show("Select a node to generate shapes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        GenerateShapesForm generateShapesForm = new GenerateShapesForm(scene.SelectedNode);
        generateShapesForm.ShowDialog();
    }

    private void chBoxCameraUse_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void btnCreateTree_Click(object sender, EventArgs e)
    {
        CreateTreeForm createTreeForm = new CreateTreeForm(scene.trees);
        createTreeForm.ShowDialog();
        Invalidate();
    }

    private void detachTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.DetachTree(scene.SelectedNode);
        Invalidate();
    }

    private void adjustTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Node node = scene.SelectedNode;
        int treeHeight = scene.CountTreeHeight(node);
        scene.AdjustTree(node, treeHeight);
        Invalidate();
    }

    private void makeIntersectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.SelectedNode.type = NodeType.Intersection;
        Invalidate();
    }

    private void makeDifferenceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.SelectedNode.type = NodeType.Difference;
        Invalidate();
    }

    private void makeUnionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.SelectedNode.type = NodeType.Union;
        Invalidate();
    }

    private void editShapeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Node node = scene.SelectedNode;
        if (node.type == NodeType.Sphere)
        {
            Sphere sphere = (Sphere)node;
            txtEdit.Text = sphere.ToString();
        }
        else if (node.type == NodeType.Cylinder)
        {
            Cylinder cylinder = (Cylinder)node;
            txtEdit.Text = cylinder.ToString();
        }
        else if (node.type == NodeType.Cube)
        {
            Cube cube = (Cube)node;
            txtEdit.Text = cube.ToString();
        }
        Invalidate();
    }

    private void deleteTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.DeleteTree(scene.SelectedNode);
        Invalidate();
    }

    private void copyTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.CopyTree(scene.SelectedNode);
        Invalidate();
    }

    private void hideUnHideTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.SelectedNode.hidenChildren = !scene.SelectedNode.hidenChildren;
        Invalidate();
    }

    private void createNodeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        scene.CreateNode(lastMousePoint.WorldCordinates(scene.camera));
    }

    private void createSphereToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CanvasCordinates canvasCordinates = new CanvasCordinates(lastClickPoint.X, lastClickPoint.Y);
        WorldCordinates wc = canvasCordinates.WorldCordinates(scene.camera);

        Sphere sphere = new Sphere();
        sphere.X = wc.X;
        sphere.Y = wc.Y;
        sphere.type = NodeType.Sphere;
        sphere.Radius = 3.0f;
        sphere.Red = 255;
        sphere.Green = 0;
        sphere.Blue = 0;
        sphere.PosX = 0;
        sphere.PosY = 0;
        sphere.PosZ = 0;

        scene.trees.Add(sphere);
        Invalidate();
    }

    private void createCylinderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CanvasCordinates canvasCordinates = new CanvasCordinates(lastClickPoint.X, lastClickPoint.Y);
        WorldCordinates wc = canvasCordinates.WorldCordinates(scene.camera);

        Cylinder cylinder = new Cylinder();
        cylinder.X = wc.X;
        cylinder.Y = wc.Y;
        cylinder.type = NodeType.Cylinder;
        cylinder.Radius = 3.0f;
        cylinder.Height = 5.0f;
        cylinder.Red = 0;
        cylinder.Green = 255;
        cylinder.Blue = 0;
        cylinder.PosX = 0;
        cylinder.PosY = 0;
        cylinder.PosZ = 0;
        cylinder.RotationX = 0;
        cylinder.RotationY = 1;
        cylinder.RotationZ = 0;

        scene.trees.Add(cylinder);
        Invalidate();
    }

    private void createCubeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CanvasCordinates canvasCordinates = new CanvasCordinates(lastClickPoint.X, lastClickPoint.Y);
        WorldCordinates wc = canvasCordinates.WorldCordinates(scene.camera);

        Cube cube = new Cube();
        cube.X = wc.X;
        cube.Y = wc.Y;
        cube.type = NodeType.Cube;
        cube.Red = 0;
        cube.Green = 0;
        cube.Blue = 255;
        cube.PosX = 0;
        cube.PosY = 0;
        cube.PosZ = 0;
        cube.EdgeLength = 5.0f;
        scene.trees.Add(cube);
        Invalidate();
    }
}

