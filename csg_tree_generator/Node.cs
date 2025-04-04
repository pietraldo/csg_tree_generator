using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public enum NodeType
	{
		Union,
		Intersection,
		Difference,
		Sphere,
		Cube,
		Cylinder
	}
	public class Node
	{
		public bool hidenChildren = false;
		public Node? parent = null;
		public Node? left = null;
		public Node? right = null;
		public NodeType type = NodeType.Union;

		// drawing parameters
		public int X { get; set; }
		public int Y { get; set; }

		public WorldCordinates WorldCordinates
		{
			get
			{
				return new WorldCordinates(X, Y);
			}
			set
			{
				X = value.X;
				Y = value.Y;
			}
		}

		public CanvasCordinates CanvasCordinates(Camera camera)
		{
			return WorldCordinates.CanvasCordinates(camera);
		}

		public Node? DetectNode(WorldCordinates wc)
		{
			if (X - Draw.circleRadius < wc.X && X + Draw.circleRadius > wc.X &&
								Y - Draw.circleRadius < wc.Y && Y + Draw.circleRadius > wc.Y)
			{
				return this;
			}
			if (left != null)
			{
				Node? leftNode = left.DetectNode(wc);
				if (leftNode != null) return leftNode;
			}
			if (right != null)
			{
				Node? rightNode = right.DetectNode(wc);
				if (rightNode != null) return rightNode;
			}
			return null;
		}

		public bool AddChild(Node child)
		{
			if (left == null)
				left = child;
			else if (right == null)
				right = child;
			else
				return false;
			child.parent = this;
			return true;
		}
	}

}
