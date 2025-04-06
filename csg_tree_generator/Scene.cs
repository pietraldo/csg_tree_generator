using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace csg_tree_generator
{
	public class Scene
	{
		public Node? SelectedNode = null;

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
			root.left.parent = root;
			root.right = new Node();
			root.right.X = 150;
			root.right.Y = 50;
			root.right.parent = root;
			root.left.left = new Node();
			root.left.left.X = 25;
			root.left.left.Y = 25;
			root.left.left.parent = root.left;
			root.left.right = new Node();
			root.left.right.X = -75;
			root.left.right.Y = -25;
			root.left.right.parent = root.left;

			root2 = new Node();
			root2.X = 200;
			root2.Y = 200;
			root2.left = new Node();
			root2.left.X = 250;
			root2.left.Y = 250;
			root2.left.parent = root2;

			trees.Add(root);
			trees.Add(root2);

			draw = new Draw(camera);

			Sphere sphere = new Sphere();
			root2.right = sphere;
			sphere.X = 300;
			sphere.Y = 300;
			sphere.parent = root2;
			sphere.type = NodeType.Sphere;


		}

		public void DrawTrees(System.Drawing.Graphics g)
		{
			foreach (Node root in trees)
			{
				draw.DrawNode(root, g, SelectedNode);
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

		public void AdjustTree(Node node)
		{
			if (node == null) return;

			if (node.parent == null)
			{
				AdjustTree(node.left);
				AdjustTree(node.right);
				return;
			}

			if (node == node.parent.left)
			{
				node.X = node.parent.X - Draw.distanceHorizontal;
				node.Y = node.parent.Y + Draw.distanceVertical;
			}
			else if (node == node.parent.right)
			{
				node.X = node.parent.X + Draw.distanceHorizontal;
				node.Y = node.parent.Y + Draw.distanceVertical;
			}
			AdjustTree(node.left);
			AdjustTree(node.right);
		}

		public bool JoinTrees(Node node)
		{
			if (SelectedNode == null) return false;
			if (!trees.Contains(SelectedNode)) return false;

			if (node.AddChild(SelectedNode))
			{
				trees.Remove(SelectedNode);
				MoveWholeTree(SelectedNode, 0, Draw.distanceVertical);
				return true;
			}
			return false;
		}

		public bool DetachTree(Node node)
		{
			if (node == null) return false;
			if (node.parent == null) return false;
			if (node.parent.left == node)
			{
				node.parent.left = null;
			}
			else if (node.parent.right == node)
			{
				node.parent.right = null;
			}
			else
			{
				return false;
			}
			node.parent = null;
			trees.Add(node);
			return true;
		}

		public Node? GetNode(WorldCordinates wc)
		{
			foreach (Node root in trees)
			{
				Node? node = root.DetectNode(wc);
				if (node != null) return node;
			}
			return null;
		}

		internal void ExportTree(Node? selectedNode, string file_path)
		{
			if (selectedNode == null)
				throw new ExportException("No tree selected");

			StringBuilder sb = new StringBuilder();
			BuildExportString(0, selectedNode, sb);
			string exportString = sb.ToString();

			// Save to file
			File.WriteAllText(file_path, exportString);
		}

		public void BuildExportString(int indentLevel, Node node, StringBuilder sb)
		{
			if (node == null) return;
			sb.Append(new string('\t', indentLevel));
			sb.AppendLine(node.ToString(true).Replace(',', '.'));
			BuildExportString(indentLevel + 1, node.left, sb);
			BuildExportString(indentLevel + 1, node.right, sb);
		}

		public void DeleteTree(Node? node)
		{
			if(node == null) return;
			if(trees.Contains(node))
			{
				trees.Remove(node);
			}
			else if (node.parent != null)
			{
				if (node.parent.left == node)
					node.parent.left = null;
				else if (node.parent.right == node)
					node.parent.right = null;
				node.parent = null;
			}
		}

		public Node? CopyTree(Node? node, Node? parent=null)
		{
			if (node == null) return null;
            
            Node newNode = node.Clone();
			if(parent == null)
			{
				newNode.X -= Draw.circleRadius*2;
				trees.Add(newNode);
			}

			if (node.left != null)
			{
				newNode.left = CopyTree(node.left, newNode);
				if (newNode.left != null)
					newNode.left.parent = newNode;
			}
			if (node.right != null)
			{
				newNode.right = CopyTree(node.right, newNode);
				if (newNode.right != null)
					newNode.right.parent = newNode;
			}
			return newNode;
		}

		public void ImportTree(string file_name)
		{
			Dictionary<string, INodeFactory> factories = new Dictionary<string, INodeFactory>
			{
				{ "Union", new UnionFactory() },
				{ "Intersection", new IntersectionFactory() },
				{ "Difference", new DifferenceFactory() },
				{ "Sphere", new SphereFactory() },
				{ "Cube", new CubeFactory() },
				{ "Cylinder", new CylinderFactory() }
			};

			Node? root = null;
			Node? last = null;
			string[] lines = File.ReadAllLines(file_name);
			foreach (string line in lines)
			{
				string[] data = line.Replace('.',',').Trim().Split(' ');

				if (!factories.TryGetValue(data[0], out var factory))
				{
					throw new ImportException("Unknown node type");
				}
				Node node = factory.CreateNode(data);
				if (root == null)
				{
					trees.Add(node);
					root = node;
					last = node;
					continue;
				}


				while (last != null && ((last.type != NodeType.Union
					&& last.type != NodeType.Intersection
					&& last.type != NodeType.Difference)
					|| (last.right != null && last.left != null)))
				{
					last = last.parent;
				}
				if (last == null)
					throw new ImportException("Tree is wrong");
				if (last.left == null)
				{
					last.left = node;
					node.parent = last;
					last = node;
				}
				else if (last.right == null)
				{
					last.right = node;
					node.parent = last;
					last = node;
				}


			}
			if (root == null)
			{
				throw new ImportException("Tree is empty");
			}

			AdjustTree(root);

		}

		public void CreateNode(WorldCordinates worldCordinates)
		{
			Node node = new Node(NodeType.Union);
			node.X = worldCordinates.X;
			node.Y = worldCordinates.Y;
			trees.Add(node);
		}
	}
}
