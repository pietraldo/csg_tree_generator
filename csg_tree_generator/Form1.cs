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
	MakeDifferenceNode
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
		this.lblStatus.Text = editingMode.ToString();
	}

	private void mainWindow_MouseMove(object sender, MouseEventArgs e)
	{
		switch (mouseMode)
		{
			case MouseMode.MoveNode:
				CanvasCordinates canvasCordinates = new CanvasCordinates(e.X, e.Y);
				scene.draggingNode.WorldCordinates = canvasCordinates.WorldCordinates(scene.camera);
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
				scene.MoveWholeTree(scene.draggingTree, dx, dy);
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
				if (node == null || scene.draggingTree == node) continue;

				if (scene.JoinTrees(node)) break;
			}
			mouseMode = MouseMode.None;

		}
		mouseMode = MouseMode.None;
	}


	private void mainWindow_MouseDown(object sender, MouseEventArgs e)
	{

		WorldCordinates worldCordinates = new CanvasCordinates(e.X, e.Y).WorldCordinates(scene.camera);
		bool isDragingNode = false;
		foreach (Node root in scene.trees)
		{
			Node? node = root.DetectNode(worldCordinates);
			if (node == null) continue;

			if (e.Button == MouseButtons.Right)
			{
				if (editingMode == EditingMode.RemoveNode)
				{
					scene.DetachTree(node);
					break;
				}

				if (editingMode == EditingMode.AdjustNode)
				{
					scene.AdjustTree(node);
					break;
				}

				if (editingMode == EditingMode.MakeUnionNode)
				{
					node.type = NodeType.Union;
					break;
				}
				else if (editingMode == EditingMode.MakeIntersectionNode)
				{
					node.type = NodeType.Intersection;
					break;
				}
				else if (editingMode == EditingMode.MakeDifferenceNode)
				{
					node.type = NodeType.Difference;
					break;
				}

				scene.draggingTree = node;
				mouseMode = MouseMode.MoveTree;

			}
			else
			{
				scene.draggingNode = node;
				mouseMode = MouseMode.MoveNode;
			}
			isDragingNode = true;
			break;
		}


		if (mouseMode == MouseMode.None)
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
			default:
				editingMode = EditingMode.None;
				break;
		}
		Invalidate();
	}

	private void btnCreatSphere_Click(object sender, EventArgs e)
	{
		CreateSphere createSphere = new CreateSphere();
		createSphere.ShowDialog();
	}
}

