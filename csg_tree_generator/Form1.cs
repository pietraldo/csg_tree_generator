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
	EditShape
}

public partial class mainWindow : Form
{

	CanvasCordinates lastMousePoint;
	Scene scene;
	MouseMode mouseMode = MouseMode.None;
	EditingMode editingMode = EditingMode.None;
	public mainWindow()
	{

		InitializeComponent();

		this.SetStyle(
		   System.Windows.Forms.ControlStyles.UserPaint |
		   System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
		   System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
		   true);

		scene = new Scene();
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
			if (e.Button == MouseButtons.Right)
			{

				switch(editingMode)
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
						break;
					default:
						mouseMode = MouseMode.MoveTree;
						changedMode = true;
						break;
				}

				scene.SelectedNode = node;
			}
			else
			{
				scene.SelectedNode = node;
				mouseMode = MouseMode.MoveNode;
				changedMode=true;
			}
		}

		if (mouseMode == MouseMode.None && !changedMode)
		{
			lastMousePoint = new CanvasCordinates(e.X, e.Y);
			mouseMode = MouseMode.MoveScene;
		}
	}

	private void mainWindow_KeyPress(object sender, KeyPressEventArgs e)
	{

		switch (e.KeyChar)
		{
			case 'a':
				editingMode = EditingMode.AdjustNode;
				break;
			case 'd':
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
}

