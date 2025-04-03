using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class Node
	{
		public bool hidenChildren = false;
		public Node? parent = null;
		public Node? left = null;
		public Node? right = null;

		// drawing parameters
		public int x = 0;
		public int y = 0;
	
		public Node DetectNode(int x,int y)
		{
			if (this.x - Draw.circleRadius < x && this.x + Draw.circleRadius > x &&
								this.y - Draw.circleRadius < y && this.y + Draw.circleRadius > y)
			{
				return this;
			}
			if (left != null)
			{
				Node? leftNode = left.DetectNode(x, y);
				if (leftNode != null) return leftNode;
			}
			if (right != null)
			{
				Node? rightNode = right.DetectNode(x, y);
				if (rightNode != null) return rightNode;
			}
			return null;
		}
	}

}
