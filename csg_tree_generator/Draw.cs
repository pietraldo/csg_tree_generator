using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
    public class Draw
    {
        public static int circleRadius = 15;
        public static int distanceVertical = 30;
        public static int distanceHorizontal = 30;
        public Camera camera;

        private Pen pen = new Pen(System.Drawing.Color.Red, 3);
        public Draw(Camera camera)
        {
            this.camera = camera;
        }

        private void DrawCylinder(Graphics g, CanvasCordinates cc)
        {
            g.FillRectangle(System.Drawing.Brushes.Beige, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale, camera.scale * circleRadius * 2, camera.scale * circleRadius * 2);
            g.FillEllipse(System.Drawing.Brushes.Beige, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale * 1.3f, camera.scale * circleRadius * 2, camera.scale * circleRadius);
            g.DrawEllipse(System.Drawing.Pens.LightBlue, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale * 1.3f, camera.scale * circleRadius * 2, camera.scale * circleRadius * 1.3f);
            g.FillEllipse(System.Drawing.Brushes.Beige, cc.X - circleRadius * camera.scale, cc.Y + circleRadius * camera.scale * 0.7f, camera.scale * circleRadius * 2, camera.scale * circleRadius);
            g.DrawEllipse(System.Drawing.Pens.LightBlue, cc.X - circleRadius * camera.scale, cc.Y + circleRadius * camera.scale * 0.7f, camera.scale * circleRadius * 2, camera.scale * circleRadius * 1.3f);
        }

        private void DrawCube(Graphics g, CanvasCordinates cc)
        {
            g.FillRectangle(System.Drawing.Brushes.Orange, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale, camera.scale * circleRadius * 2, camera.scale * circleRadius * 2);
        }

        private void DrawLine(CanvasCordinates cc1, CanvasCordinates cc2, System.Drawing.Graphics g)
        {
            g.DrawLine(System.Drawing.Pens.LightBlue, cc1.X, cc1.Y, cc2.X, cc2.Y);
        }

        public void DrawNode(Node node, System.Drawing.Graphics g, Node selected)
        {
            if (node == null) return;

            // Draw the current node
            CanvasCordinates cc = node.CanvasCordinates(camera);

            if (node.type == NodeType.Cylinder)
            {
                DrawCylinder(g, cc);
            }
            else if (node.type == NodeType.Cube)
            {
                DrawCube(g, cc);
            }
            else if (node.type == NodeType.Sphere)
            {
                g.FillEllipse(System.Drawing.Brushes.Violet, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale, circleRadius * 2 * camera.scale, circleRadius * 2 * camera.scale);
            }
            else
            {
                Brush brush = (node.hidenChildren) ? System.Drawing.Brushes.LightCoral : System.Drawing.Brushes.LightBlue;
                g.FillEllipse(brush, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale, circleRadius * 2 * camera.scale, circleRadius * 2 * camera.scale);
            }


            if (node == selected)
            {

                g.DrawEllipse(pen, cc.X - circleRadius * camera.scale, cc.Y - circleRadius * camera.scale, circleRadius * 2 * camera.scale, circleRadius * 2 * camera.scale);
            }



            if (!node.hidenChildren)
            {
                if (node.left != null)
                {
                    DrawLine(node.CanvasCordinates(camera), node.left.CanvasCordinates(camera), g);
                    DrawNode(node.left, g, selected);
                }

                if (node.right != null)
                {
                    DrawLine(node.CanvasCordinates(camera), node.right.CanvasCordinates(camera), g);
                    DrawNode(node.right, g, selected);
                }
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
