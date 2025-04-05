using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class Sphere:Node
	{
		public float PosX { get; set; }
		public float PosY { get; set; }
		public float PosZ { get; set; }

		public int Red { get; set; }
		public int Green { get; set; }
		public int Blue { get; set; }

		public float Radius { get; set; }

		public override string ToString(bool withName)
		{
			return withName ? "Sphere " + ToString() : ToString();
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(PosX.ToString());
			sb.Append(" ");
			sb.Append(PosY.ToString());
			sb.Append(" ");
			sb.Append(PosZ.ToString());
			sb.Append(" ");
			sb.Append(Red.ToString("X2"));
			sb.Append(Green.ToString("X2"));
			sb.Append(Blue.ToString("X2"));
			sb.Append(" ");
			sb.Append(Radius.ToString());
			return sb.ToString();
		}
		public override Node Clone()
		{
			Sphere sphere = new Sphere();
			sphere.PosX = PosX;
			sphere.PosY = PosY;
			sphere.PosZ = PosZ;
			sphere.Red = Red;
			sphere.Green = Green;
			sphere.Blue = Blue;
			sphere.Radius = Radius;
			sphere.type = type;
			sphere.hidenChildren = hidenChildren;
			sphere.X = X;
			sphere.Y = Y;

			return sphere;
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
				float.TryParse(strings[4], out float radius))
				{
					PosX = x;
					PosY = y;
					PosZ = z;
					Red = red;
					Green = green;
					Blue = blue;
					Radius = radius;
					return true;
				}
			}
			catch(Exception ex)
			{
				Debug.WriteLine("Error parsing sphere: " + ex.Message);
			}
			
			return false;
		}
	}

	
}
