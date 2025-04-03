using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class Draw
	{
		public static int circleRadius = 15;
		public Camera camera;

		public Draw(Camera camera)
		{
			this.camera = camera;
		}

		private void DrawCircle(CanvasCordinates cc, System.Drawing.Graphics g)
		{
			g.FillEllipse(System.Drawing.Brushes.Blue, cc.X-circleRadius*camera.scale, cc.Y - circleRadius * camera.scale, circleRadius*2*camera.scale, circleRadius*2*camera.scale);
		}
		private void DrawLine(CanvasCordinates cc1, CanvasCordinates cc2, System.Drawing.Graphics g)
		{
			g.DrawLine(System.Drawing.Pens.Blue, cc1.X, cc1.Y, cc2.X, cc2.Y);
		}

		public void DrawNode(Node node, System.Drawing.Graphics g)
		{
			if (node == null) return;

			// Draw the current node
			DrawCircle(node.CanvasCordinates(camera), g);

			if (node.left != null)
			{
				DrawLine(node.CanvasCordinates(camera), node.left.CanvasCordinates(camera), g);
				DrawNode(node.left, g);
			}
				
			if (node.right != null)
			{
				DrawLine(node.CanvasCordinates(camera), node.right.CanvasCordinates(camera), g);
				DrawNode(node.right, g);
			}
		}

	}
}
