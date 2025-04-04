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
		public static int distanceVertical = 50;
		public static int distanceHorizontal = 50;
		public Camera camera;

		public Draw(Camera camera)
		{
			this.camera = camera;
		}

		
		private void DrawLine(CanvasCordinates cc1, CanvasCordinates cc2, System.Drawing.Graphics g)
		{
			g.DrawLine(System.Drawing.Pens.LightBlue, cc1.X, cc1.Y, cc2.X, cc2.Y);
		}

		public void DrawNode(Node node, System.Drawing.Graphics g)
		{
			if (node == null) return;

			// Draw the current node
			CanvasCordinates cc = node.CanvasCordinates(camera);
			g.FillEllipse(System.Drawing.Brushes.LightBlue, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale, circleRadius * 2 * camera.scale, circleRadius * 2 * camera.scale);


			

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


			string text = "";
			if (node.type == NodeType.Union)
				text = "+";
			else if (node.type == NodeType.Intersection)
				text = "∩";
			else if (node.type == NodeType.Difference)
				text = "-";

			WriteString(text, cc, g);
		}

		public void WriteString(string text, CanvasCordinates cc, Graphics g)
		{
			// Choose font and measure text size
			using (Font font = new Font("Arial", 25 * camera.scale, FontStyle.Bold, GraphicsUnit.Pixel))
			using (StringFormat format = new StringFormat())
			{
				format.Alignment = StringAlignment.Center;
				format.LineAlignment = StringAlignment.Center;

				// Draw the text inside the circle
				RectangleF textRect = new RectangleF(cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale, circleRadius * 2 * camera.scale, circleRadius * 2 * camera.scale);
				g.DrawString(text, font, Brushes.Blue, textRect, format);
			}
		}

	}
}
