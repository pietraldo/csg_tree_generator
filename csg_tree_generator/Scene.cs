using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class Scene
	{
		public Node? draggingNode = null;
		public Node? draggingTree = null;

		public List<Node> trees = new List<Node>();
		public Camera camera = new Camera();
		public Draw draw;

		public Scene()
		{
			trees = new List<Node>();
			Node root;
			Node root2;
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

			root2 = new Node();
			root2.X = 200;
			root2.Y = 200;
			root2.left = new Node();
			root2.left.X = 250;
			root2.left.Y = 250;

			trees.Add(root);
			trees.Add(root2);

			draw= new Draw(camera);
		}

		public void DrawTrees(System.Drawing.Graphics g)
		{
			foreach (Node root in trees)
			{
				draw.DrawNode(root, g);
			}
		}

		public void MoveWholeTree(Node node, int dx, int dy)
		{
			if (node == null) return;
			node.X += dx;
			node.Y += dy;

			if (node.left != null)
			{
				MoveWholeTree(node.left, dx, dy);
			}
			if (node.right != null)
			{
				MoveWholeTree(node.right, dx, dy);
			}
		}

		public bool JoinTrees(Node node)
		{
			if(draggingTree == null) return false;
			if(!trees.Contains(draggingTree)) return false;

			if(node.AddChild(draggingTree))
			{
				trees.Remove(draggingTree);
				MoveWholeTree(draggingTree, 40, 40);
				return true;
			}
			return false;
		}

	}
}
