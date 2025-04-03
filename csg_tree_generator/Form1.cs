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
			root.x = 100;
			root.y = 100;
			root.left = new Node();
			root.left.x = 50;
			root.left.y = 50;
			root.right = new Node();
			root.right.x = 150;
			root.right.y = 50;
			root.left.left = new Node();
			root.left.left.x = 25;
			root.left.left.y = 25;
			root.left.right = new Node();
			root.left.right.x = -75;
			root.left.right.y = -25;

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
				active.x = (int)((e.X - Draw.camera.x) / Draw.camera.scale);
				active.y = (int)((e.Y - Draw.camera.y) /Draw.camera.scale);
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
			int x = (int)((e.X- Draw.camera.x)/Draw.camera.scale);
			int y = (int)((e.Y - Draw.camera.y) / Draw.camera.scale);

			Debug.WriteLine($"x: {x} y: {y}");

			active = root.DetectNode(x, y);
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
