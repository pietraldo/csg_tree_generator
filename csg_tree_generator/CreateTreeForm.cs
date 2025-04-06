using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csg_tree_generator
{
	public partial class CreateTreeForm : Form
	{
		private List<Node> trees;
		public CreateTreeForm(List<Node> trees)
		{
			this.trees = trees;
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			if(rdBalanced.Checked)
			{
				trees.Add(GenerateBalancedTree(null, (int)txtHeight.Value));
			}
			else if (rdLeft.Checked)
			{
				trees.Add(GenerateLeftTree(null, (int)txtHeight.Value));
			}
			else if (rdRight.Checked)
			{
				trees.Add(GenerateRightTree(null, (int)txtHeight.Value));
			}
			else
			{
				MessageBox.Show("Select a tree type");
				return;
			}
			Close();
		}

		private Node GenerateBalancedTree(Node parent, int maxDepth, int depth=0)
		{
			if(depth==maxDepth) return null;
			Node node = new Node(NodeType.Union);
			node.parent = parent;
			node.left = GenerateBalancedTree(node, maxDepth, depth + 1);
			node.right = GenerateBalancedTree(node, maxDepth, depth + 1);
			return node;
		}
		private Node GenerateLeftTree(Node parent, int maxDepth, int depth = 0)
		{
			if (depth == maxDepth) return null;
			Node node = new Node(NodeType.Union);
			node.parent = parent;
			node.left = GenerateLeftTree(node, maxDepth, depth + 1);
			return node;
		}
		private Node GenerateRightTree(Node parent, int maxDepth, int depth = 0)
		{
			if (depth == maxDepth) return null;
			Node node = new Node(NodeType.Union);
			node.parent = parent;
			node.right = GenerateRightTree(node, maxDepth, depth + 1);
			return node;
		}
	}
}
