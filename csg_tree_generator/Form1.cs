using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace csg_tree_generator;
public enum MouseMode
{
	None,
	MoveNode,
	MoveScene,
	MoveTree
}

public enum EditingMode
{
	None,
	RemoveNode,
	AdjustNode,
	MakeUnionNode,
	MakeIntersectionNode,
	MakeDifferenceNode,
	EditShape,
	DeleteTree,
	CopyTree
}

public partial class mainWindow : Form
{

	CanvasCordinates lastMousePoint;
	Scene scene;
	MouseMode mouseMode = MouseMode.None;
	EditingMode editingMode = EditingMode.None;

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
		lblStatus.Text = editingMode.ToString();
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
		if (mouseMode == MouseMode.MoveTree)
		{

			foreach (Node root in scene.trees)
			{
				Node? node = root.DetectNode(worldCordinates);
				if (node == null || scene.SelectedNode == node) continue;

				if (scene.JoinTrees(node)) break;
			}
			mouseMode = MouseMode.None;

		}
		mouseMode = MouseMode.None;
	}


	private void mainWindow_MouseDown(object sender, MouseEventArgs e)
	{

		WorldCordinates worldCordinates = new CanvasCordinates(e.X, e.Y).WorldCordinates(scene.camera);
		bool changedMode = false;
		Node? node = scene.GetNode(worldCordinates);
		if (node != null)
		{
			scene.SelectedNode = node;
			if (e.Button == MouseButtons.Right)
			{
				switch (editingMode)
				{
					case EditingMode.RemoveNode:
						scene.DetachTree(node);
						break;
					case EditingMode.AdjustNode:
						scene.AdjustTree(node);
						break;
					case EditingMode.MakeUnionNode:
						node.type = NodeType.Union;
						break;
					case EditingMode.MakeIntersectionNode:
						node.type = NodeType.Intersection;
						break;
					case EditingMode.MakeDifferenceNode:
						node.type = NodeType.Difference;
						break;
					case EditingMode.EditShape:
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
						break;
					case EditingMode.DeleteTree:
						scene.DeleteTree(node);
						break;
					case EditingMode.CopyTree:
						scene.CopyTree(scene.SelectedNode);
						break;
					default:
						mouseMode = MouseMode.MoveTree;
						changedMode = true;
						break;
				}

				editingMode = EditingMode.None;

			}
			else
			{
				mouseMode = MouseMode.MoveNode;
				changedMode = true;
			}
		}

		if (mouseMode == MouseMode.None && !changedMode)
		{
			lastMousePoint = new CanvasCordinates(e.X, e.Y);
			mouseMode = MouseMode.MoveScene;
		}
		Invalidate();
	}

	private void mainWindow_KeyPress(object sender, KeyPressEventArgs e)
	{

		switch (e.KeyChar)
		{
			case 'a':
				editingMode = EditingMode.AdjustNode;
				break;
			case 'r':
				editingMode = EditingMode.RemoveNode;
				break;
			case 'u':
				editingMode = EditingMode.MakeUnionNode;
				break;
			case 'i':
				editingMode = EditingMode.MakeIntersectionNode;
				break;
			case 's':
				editingMode = EditingMode.MakeDifferenceNode;
				break;
			case 'e':
				editingMode = EditingMode.EditShape;
				break;
			case 'd':
				editingMode = EditingMode.DeleteTree;
				break;
			case 'c':
				editingMode = EditingMode.CopyTree;
				break;
			default:
				editingMode = EditingMode.None;
				break;
		}
		Invalidate();
	}

	private void btnCreatSphere_Click(object sender, EventArgs e)
	{
		Sphere sphere = new Sphere();
		sphere.X = 100;
		sphere.Y = 100;
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

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (scene.SelectedNode.EditShape(txtEdit.Text))
			txtEdit.Text = "";
	}

	private void btnCreateCylinder_Click(object sender, EventArgs e)
	{
		Cylinder cylinder = new Cylinder();
		cylinder.X = 200;
		cylinder.Y = 100;
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

	private void btnCreateCube_Click(object sender, EventArgs e)
	{
		Cube cube = new Cube();
		cube.X = 180;
		cube.Y = 100;
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
			var processStartInfo = new ProcessStartInfo
			{
				FileName = csgProgramPath,
				Arguments = $"\"{saving_tree_path}\" \"{camera_path}\"",
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
					Debug.WriteLine("[ERR] " + args.Data);
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
}

