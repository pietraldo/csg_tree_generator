using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class Cylinder : Node
	{
		public float PosX { get; set; }
		public float PosY { get; set; }
		public float PosZ { get; set; }

		public int Red { get; set; }
		public int Green { get; set; }
		public int Blue { get; set; }

		public float Radius { get; set; }
		public float Height { get; set; }

		public float RotationX { get; set; }
		public float RotationY { get; set; }
		public float RotationZ { get; set; }

		public override Node Clone()
		{
			Cylinder cylinder = new Cylinder();
			cylinder.PosX = PosX;
			cylinder.PosY = PosY;
			cylinder.PosZ = PosZ;
			cylinder.Red = Red;
			cylinder.Green = Green;
			cylinder.Blue = Blue;
			cylinder.Radius = Radius;
			cylinder.Height = Height;
			cylinder.RotationX = RotationX;
			cylinder.RotationY = RotationY;
			cylinder.RotationZ = RotationZ;
			cylinder.type = type;
			cylinder.hidenChildren = hidenChildren;
			cylinder.X = X;
			cylinder.Y = Y;
			return cylinder;
		}

		public override string ToString(bool withName)
		{
			return withName ? "Cylinder " + ToString() : ToString();
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
			sb.Append(Radius.ToString("F2"));
			sb.Append(" ");
			sb.Append(Height.ToString("F2"));
			sb.Append(" ");
			sb.Append(RotationX.ToString("F2"));
			sb.Append(" ");
			sb.Append(RotationY.ToString("F2"));
			sb.Append(" ");
			sb.Append(RotationZ.ToString("F2"));
			return sb.ToString();
		}

		public override bool EditShape(string editString)
		{
			string[] strings = editString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (strings.Length < 9)
				return false;
			try
			{
				if (float.TryParse(strings[0], out float x) &&
				float.TryParse(strings[1], out float y) &&
				float.TryParse(strings[2], out float z) &&
				int.TryParse(strings[3].Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int red) &&
				int.TryParse(strings[3].Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int green) &&
				int.TryParse(strings[3].Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int blue) &&
				float.TryParse(strings[4], out float radius) &&
				float.TryParse(strings[5], out float height) &&
				float.TryParse(strings[6], out float rotationX) &&
				float.TryParse(strings[7], out float rotationY) &&
				float.TryParse(strings[8], out float rotationZ))
				{
					PosX = x;
					PosY = y;
					PosZ = z;
					Red = red;
					Green = green;
					Blue = blue;
					Radius = radius;
					Height = height;
					RotationX = rotationX;
					RotationY = rotationY;
					RotationZ = rotationZ;
					return true;
				}
			}
			catch(Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return false;
		}
	}
}
