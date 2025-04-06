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
		private class Parser
		{
			float minX;
			float maxX;
			float minY;
			float maxY;
			float minZ;
			float maxZ;
			int red;
			int green;
			int blue;
			float radiusMin;
			float radiusMax;
			float rotationMinX;
			float rotationMaxX;
			float rotationMinY;
			float rotationMaxY;
			float rotationMinZ;
			float rotationMaxZ;
			float heightMin;
			float heightMax;
			float widthMin;
			float widthMax;
			bool sphere = false;
			bool cylinder = false;
			bool cube = false;
			bool replace = false;

			Random r = new Random();

			public float X { get { return GetRandom(minX, maxX); } }
			public float Y { get { return GetRandom(minY, maxY); } }
			public float Z { get { return GetRandom(minZ, maxZ); } }
			public int Red { get { return red; } }
			public int Green { get { return green; } }
			public int Blue { get { return blue; } }
			public float Radius { get { return GetRandom(radiusMin, radiusMax); } }
			public float RotationX { get { return GetRandom(rotationMinX, rotationMaxX); } }
			public float RotationY { get { return GetRandom(rotationMinY, rotationMaxY); } }
			public float RotationZ { get { return GetRandom(rotationMinZ, rotationMaxZ); } }
			public float Height { get { return GetRandom(heightMin, heightMax); } }
			public float Width { get { return GetRandom(widthMin, widthMax); } }

			public bool Replace { get { return replace; } set { replace = value; } }
			public NodeType Shape
			{
				get
				{
					List<NodeType> list = new List<NodeType>();
					if (cube)
						list.Add(NodeType.Cube);
					if (cylinder)
						list.Add(NodeType.Cylinder);
					if (sphere)
						list.Add(NodeType.Sphere);
					if (list.Count == 0)
						return NodeType.Sphere;

					return list[r.Next(0, list.Count)];
				}
			}

			private float GetRandom(float min, float max)
			{
				return (float)(r.NextDouble() * (max - min) + min);
			}

			public Parser(GenerateShapesForm gen)
			{
				minX = (float)gen.txtXMin.Value;
				maxX = (float)gen.txtXMax.Value;
				minY = (float)gen.txtYMin.Value;
				maxY = (float)gen.txtYMax.Value;
				minZ = (float)gen.txtZMin.Value;
				maxZ = (float)gen.txtZMax.Value;
				red = gen.btnSelectColor.BackColor.R;
				green = gen.btnSelectColor.BackColor.G;
				blue = gen.btnSelectColor.BackColor.B;
				radiusMin = (float)gen.txtRadiusMin.Value;
				radiusMax = (float)gen.txtRadiusMax.Value;
				rotationMinX = (float)gen.txtRotationXMin.Value;
				rotationMaxX = (float)gen.txtRotationXMax.Value;
				rotationMinY = (float)gen.txtRotationYMin.Value;
				rotationMaxY = (float)gen.txtRotationYMax.Value;
				rotationMinZ = (float)gen.txtRotationZMin.Value;
				rotationMaxZ = (float)gen.txtRotationZMax.Value;
				heightMin = (float)gen.txtHeightMin.Value;
				heightMax = (float)gen.txtHeightMax.Value;
				widthMin = (float)gen.txtWidthMin.Value;
				widthMax = (float)gen.txtWidthMax.Value;
				replace = gen.chBoxReplace.Checked;
			}
		}

		private Node tree;
		public GenerateShapesForm(Node tree)
		{
			this.tree = tree;

			InitializeComponent();
		}
		private Dictionary<NodeType, Func<Parser, Node>> shapeGenerators = new Dictionary<NodeType, Func<Parser, Node>>()
		{
			{ NodeType.Cube, GenerateCube },
			{ NodeType.Cylinder, GenerateCylinder },
			{ NodeType.Sphere, GenerateSphere }
		};

		private void FillTree(Parser parse, Node node)
		{
			if (node == null)
				return;

			if (node.left == null)
			{
				Node newNode = shapeGenerators[parse.Shape](parse);
				node.left = newNode;
				newNode.parent = node;
			}
			else
			{
				if (node.left.type == NodeType.Sphere || node.left.type == NodeType.Cube || node.left.type == NodeType.Cylinder)
				{
					if (parse.Replace)
					{
						Node newNode = shapeGenerators[parse.Shape](parse);
						newNode.parent = node;
						node.left = newNode;
					}
				}
				else
				{
					FillTree(parse, node.left);
				}
			}

			if (node.right == null)
			{
				Node newNode = shapeGenerators[parse.Shape](parse);
				node.right = newNode;
				newNode.parent = node;
			}
			else
			{
				if (node.right.type == NodeType.Sphere || node.right.type == NodeType.Cube || node.right.type == NodeType.Cylinder)
				{
					if (parse.Replace)
					{
						Node newNode = shapeGenerators[parse.Shape](parse);
						newNode.parent = node;
						node.right = newNode;
					}
				}
				else
				{
					FillTree(parse, node.right);
				}
			}
		}

		private void txtGenerate_Click(object sender, EventArgs e)
		{
			Parser parser = new Parser(this);

			FillTree(parser, tree);
			Close();
		}
		private static Node GenerateCube(Parser parser)
		{
			Cube cube = new Cube();
			cube.PosX = parser.X;
			cube.PosY = parser.Y;
			cube.PosZ = parser.Z;
			cube.Red = parser.Red;
			cube.Green = parser.Green;
			cube.Blue = parser.Blue;
			cube.EdgeLength = parser.Width;
			cube.type = NodeType.Cube;
			return cube;
		}
		private static Node GenerateCylinder(Parser parser)
		{
			Cylinder cylinder = new Cylinder();
			cylinder.PosX = parser.X;
			cylinder.PosY = parser.Y;
			cylinder.PosZ = parser.Z;
			cylinder.Red = parser.Red;
			cylinder.Green = parser.Green;
			cylinder.Blue = parser.Blue;
			cylinder.Radius = parser.Radius;
			cylinder.Height = parser.Height;
			cylinder.RotationX = parser.RotationX;
			cylinder.RotationY = parser.RotationY;
			cylinder.RotationZ = parser.RotationZ;
			cylinder.type = NodeType.Cylinder;
			return cylinder;
		}

		private static Node GenerateSphere(Parser parser)
		{
			Sphere sphere = new Sphere();
			sphere.PosX = parser.X;
			sphere.PosY = parser.Y;
			sphere.PosZ = parser.Z;
			sphere.Red = parser.Red;
			sphere.Green = parser.Green;
			sphere.Blue = parser.Blue;
			sphere.Radius = parser.Radius;
			sphere.type = NodeType.Sphere;
			return sphere;
		}
	}
}
