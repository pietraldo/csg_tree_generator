using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csg_tree_generator
{

	public partial class GenerateShapesForm : Form
	{
		

		private Node tree;
		public GenerateShapesForm(Node tree)
		{
			this.tree = tree;

			InitializeComponent();
		}
		
		private Node GetNewNode()
		{
			int sum = 0;
			if(chBoxSphere.Checked)
			{
                sum+=(int)txtChanceSphere.Value;
            }
            if (chBoxCube.Checked)
            {
                sum += (int)txtChanceCube.Value;
            }
            if (chBoxCylinder.Checked)
            {
                sum += (int)txtChanceCylinder.Value;
            }
			Random random = new Random();
            int randomValue = random.Next(0, sum);

            if (chBoxSphere.Checked && randomValue < (int)txtChanceSphere.Value)
				return GenerateSphere();
            else if (chBoxCube.Checked && randomValue < (int)txtChanceSphere.Value + (int)txtChanceCube.Value)
                return GenerateCube();
            else if (chBoxCylinder.Checked && randomValue < (int)txtChanceSphere.Value + (int)txtChanceCube.Value + (int)txtChanceCylinder.Value)
                return GenerateCylinder();
            else
                return GenerateSphere();
        }

		private void FillTree(Node node)
		{
			if (node == null)
				return;

			if (node.left == null)
			{
				Node newNode = GetNewNode();
                node.left = newNode;
				newNode.parent = node;
			}
			else
			{
				if (node.left.type == NodeType.Sphere || node.left.type == NodeType.Cube || node.left.type == NodeType.Cylinder)
				{
					if (chBoxReplace.Checked)
					{
						Node newNode = GetNewNode();
                        newNode.parent = node;
						node.left = newNode;
					}
				}
				else
				{
					FillTree(node.left);
				}
			}

			if (node.right == null)
			{
				Node newNode = GetNewNode();
				node.right = newNode;
				newNode.parent = node;
			}
			else
			{
				if (node.right.type == NodeType.Sphere || node.right.type == NodeType.Cube || node.right.type == NodeType.Cylinder)
				{
					if (chBoxReplace.Checked)
					{
						Node newNode = GetNewNode();
						newNode.parent = node;
						node.right = newNode;
					}
				}
				else
				{
					FillTree(node.right);
				}
			}
		}

		private void txtGenerate_Click(object sender, EventArgs e)
		{
			FillTree(tree);
			Close();
		}
		private Node GenerateCube()
		{
			Cube cube = new Cube();
			cube.PosX = (float) GenerateRandom(txtMinXCu.Value, txtMaxXCu.Value);
			cube.PosY = (float) GenerateRandom(txtMinYCu.Value, txtMaxYCu.Value);
			cube.PosZ = (float) GenerateRandom(txtMinZCu.Value, txtMaxZCu.Value);
			cube.Red = btnSelectColorCu.BackColor.R;
            cube.Green = btnSelectColorCu.BackColor.G;
            cube.Blue = btnSelectColorCu.BackColor.B;
            cube.EdgeLength = (float)GenerateRandom(txtMinWidthCu.Value, txtMaxWidthMaxCu.Value);
			cube.type = NodeType.Cube;
			return cube;
		}
		private Node GenerateCylinder()
		{
			Cylinder cylinder = new Cylinder();
			cylinder.PosX = (float) GenerateRandom(txtMinXCy.Value, txtMaxXCy.Value);
			cylinder.PosY = (float)GenerateRandom(txtMinYCy.Value, txtMaxYCy.Value);
            cylinder.PosZ = (float)GenerateRandom(txtMinZCy.Value, txtMaxZCy.Value);
            cylinder.Red = btnSelectColorCy.BackColor.R;
            cylinder.Green = btnSelectColorCy.BackColor.R;
            cylinder.Blue = btnSelectColorCy.BackColor.R;
            cylinder.Radius = (float)GenerateRandom(txtMinWiCy.Value, txtMaxWiCy.Value);
            cylinder.Height = (float)GenerateRandom(txtMinHCy.Value, txtMaxHCy.Value);
            cylinder.RotationX = (float)GenerateRandom(txtMinRotX.Value, txtMaxRotX.Value);
            cylinder.RotationY = (float)GenerateRandom(txtMinRotY.Value, txtMaxRotY.Value);
            cylinder.RotationZ = (float)GenerateRandom(txtMinRotZ.Value, txtMaxRotZ.Value);
            cylinder.type = NodeType.Cylinder;
			return cylinder;
		}

		private double GenerateRandom(decimal min, decimal max)
		{
			Random ranodm = new Random();
			ranodm.NextDouble();
            double randomX = ranodm.NextDouble() * ((double)max - (double)min) + (double)min;
			return randomX;
        }
		private Node GenerateSphere()
		{
			Sphere sphere = new Sphere();
			sphere.PosX = (float)GenerateRandom(txtXMin.Value, txtXMax.Value);
			sphere.PosY = (float)GenerateRandom(txtXMin.Value, txtXMax.Value);
            sphere.PosZ = (float)GenerateRandom(txtXMin.Value, txtXMax.Value);
            sphere.Red = btnSelectColor.BackColor.R;
			sphere.Green = btnSelectColor.BackColor.G;
			sphere.Blue = btnSelectColor.BackColor.B;
			sphere.Radius = (float)GenerateRandom(txtRadiusMin.Value, txtRadiusMax.Value);
            sphere.type = NodeType.Sphere;
			return sphere;
		}

		private void btnSelectColor_Click(object sender, EventArgs e)
		{
			using(ColorDialog colorDialog = new ColorDialog())
			{
				colorDialog.AllowFullOpen = true;
				colorDialog.ShowHelp = true;
				colorDialog.Color = btnSelectColor.BackColor;

				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					btnSelectColor.BackColor = colorDialog.Color;
					btnSelectColor.Text = colorDialog.Color.R.ToString("X2") + " " +
						colorDialog.Color.G.ToString("X2") + " " +
						colorDialog.Color.B.ToString("X2");
				}
			}
		}
	}
}
