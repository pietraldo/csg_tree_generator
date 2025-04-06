using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class Cube : Node
	{
		public float PosX { get; set; }
		public float PosY { get; set; }
		public float PosZ { get; set; }

		public int Red { get; set; }
		public int Green { get; set; }
		public int Blue { get; set; }

		public float EdgeLength { get; set; }

		public override Node Clone()
		{
			Cube cube = new Cube();
			cube.PosX = PosX;
			cube.PosY = PosY;
			cube.PosZ = PosZ;
			cube.Red = Red;
			cube.Green = Green;
			cube.Blue = Blue;
			cube.EdgeLength = EdgeLength;
			cube.type = type;
			cube.hidenChildren = hidenChildren;
			cube.X = X;
			cube.Y = Y;
			return cube;
		}
		public override string ToString(bool withName)
		{
			return withName ? "Cube " + ToString() : ToString();
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(PosX.ToString("F2"));
			sb.Append(" ");
			sb.Append(PosY.ToString("F2"));
			sb.Append(" ");
			sb.Append(PosZ.ToString("F2"));
			sb.Append(" ");
			sb.Append(Red.ToString("X2"));
			sb.Append(Green.ToString("X2"));
			sb.Append(Blue.ToString("X2"));
			sb.Append(" ");
			sb.Append(EdgeLength.ToString("F2"));
			return sb.ToString();
		}

		public override bool EditShape(string editString)
		{
			string[] strings = editString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (strings.Length < 5)
				return false;
			try
			{
				if (float.TryParse(strings[0], out float x) &&
				float.TryParse(strings[1], out float y) &&
				float.TryParse(strings[2], out float z) &&
				int.TryParse(strings[3].Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int red) &&
				int.TryParse(strings[3].Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int green) &&
				int.TryParse(strings[3].Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int blue) &&
				float.TryParse(strings[4], out float edgeLength))
				{
					PosX = x;
					PosY = y;
					PosZ = z;
					Red = red;
					Green = green;
					Blue = blue;
					EdgeLength = edgeLength;
					return true;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return false;
		}
	}
}
