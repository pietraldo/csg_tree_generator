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
		private int chanceLeft;
        private int chanceRight;
		private Random random;

        public CreateTreeForm(List<Node> trees)
		{
            random = new Random();
            this.trees = trees;
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			chanceLeft = trLeft.Value;
            chanceRight = trRight.Value;
            trees.Add(GenerateBalancedTree(null, (int)txtHeight.Value));
            Close();
		}

		private Node GenerateBalancedTree(Node parent, int maxDepth, int depth=0)
		{
			if(depth==maxDepth) return null;
			Node node = new Node(NodeType.Union);
			node.parent = parent;
			
            if (random.Next(0, 100) < chanceLeft)
                node.left = GenerateBalancedTree(node, maxDepth, depth + 1);
			if(random.Next(0, 100) < chanceRight)
				node.right = GenerateBalancedTree(node, maxDepth, depth + 1);
			return node;
		}
	}
}
