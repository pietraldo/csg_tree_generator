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
		public static Camera camera = new Camera();

		private static void DrawCircle(int x, int y, System.Drawing.Graphics g)
		{
			int newX = (int)((x-circleRadius)*camera.scale) + camera.x;
			int newY = (int)((y - circleRadius) * camera.scale) + camera.y;
			g.FillEllipse(System.Drawing.Brushes.Blue, newX, newY, circleRadius*2*camera.scale, circleRadius*2*camera.scale);
		}
		private static void DrawLine(int x1, int y1, int x2, int y2, System.Drawing.Graphics g)
		{
			x1 = (int)((x1) * camera.scale) + camera.x;
			y1 = (int)((y1) * camera.scale) + camera.y;
			x2 = (int)((x2) * camera.scale) + camera.x;
			y2 = (int)((y2) * camera.scale) + camera.y;
			g.DrawLine(System.Drawing.Pens.Blue, x1, y1, x2, y2);
		}

		public static void DrawNode(Node node, System.Drawing.Graphics g)
		{
			if (node == null) return;

			// Draw the current node
			DrawCircle(node.x, node.y, g);

			if (node.left != null)
				DrawLine(node.x, node.y, node.left.x, node.left.y, g);
			if (node.right != null)
				DrawLine(node.x, node.y, node.right.x, node.right.y, g);

			// Recursively draw the left and right children
			DrawNode(node.left, g);
			DrawNode(node.right, g);
		}

		public static Node DetectNode(Node node, int x, int y)
		{
			if (node == null) return null;

			return node.DetectNode(x,y);
		}
	}
}
