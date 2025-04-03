using System.Diagnostics;
using System.Windows.Forms;

namespace csg_tree_generator
{
	public partial class mainWindow : Form
	{
		public mainWindow()
		{

			InitializeComponent();

			this.SetStyle(
			   System.Windows.Forms.ControlStyles.UserPaint |
			   System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
			   System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
			   true);

			root = new Node();
			root.X = 100;
			root.Y = 100;
			root.left = new Node();
			root.left.X = 50;
			root.left.Y = 50;
			root.right = new Node();
			root.right.X = 150;
			root.right.Y = 50;
			root.left.left = new Node();
			root.left.left.X = 25;
			root.left.left.Y = 25;
			root.left.right = new Node();
			root.left.right.X = -75;
			root.left.right.Y = -25;

		}
		Node root;

		private void mainWindow_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(Color.White);

			Draw.DrawNode(root, e.Graphics);
		}

		private void mainWindow_MouseMove(object sender, MouseEventArgs e)
		{
			
			if (active != null)
			{
				CanvasCordinates canvasCordinates = new CanvasCordinates(e.X, e.Y);
				active.WorldCordinates = canvasCordinates.WorldCordinates(Draw.camera);
			}
			if(movingScene)
			{
				Draw.camera.x += (e.X - lastPoint.X);
				Draw.camera.y += (e.Y - lastPoint.Y);
				lastPoint = new Point(e.X, e.Y);
			}
			Invalidate();

			
		}
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			base.OnMouseWheel(e);

			if(e.Delta > 0)
			{
				Draw.camera.scale *= 1.1f;
			}
			else
			{
				Draw.camera.scale /= 1.1f;
			}
			Invalidate();
		}

		private void mainWindow_MouseUp(object sender, MouseEventArgs e)
		{
			active = null;
			movingScene = false;
		}

		Node? active = null;
		Point lastPoint;
		bool movingScene = false;
		private void mainWindow_MouseDown(object sender, MouseEventArgs e)
		{
			
			WorldCordinates worldCordinates = new CanvasCordinates(e.X, e.Y).WorldCordinates(Draw.camera);

			active = root.DetectNode(worldCordinates);
			if(active==null)
			{
				lastPoint = new Point(e.X, e.Y);
				movingScene = true;
			}
			
		}

		private void mainWindow_Scroll(object sender, ScrollEventArgs e)
		{
			Debug.WriteLine(e.NewValue);
		}
	}
}
