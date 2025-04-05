﻿using System;
using System.Collections.Generic;
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

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(PosX.ToString());
			sb.AppendLine(" ");
			sb.AppendLine(PosY.ToString());
			sb.AppendLine(" ");
			sb.AppendLine(PosZ.ToString());
			sb.AppendLine(" ");
			sb.Append(Red.ToString("X"));
			sb.AppendLine(" ");
			sb.Append(Green.ToString("X"));
			sb.AppendLine(" ");
			sb.Append(Blue.ToString("X"));
			sb.AppendLine(" ");
			sb.Append(EdgeLength.ToString());
			return sb.ToString();
		}

		public override bool EditShape(string editString)
		{
			string[] strings = editString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (strings.Length < 7)
				return false;
			if (float.TryParse(strings[0], out float x) &&
				float.TryParse(strings[1], out float y) &&
				float.TryParse(strings[2], out float z) &&
				int.TryParse(strings[3], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int red) &&
				int.TryParse(strings[4], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int green) &&
				int.TryParse(strings[5], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int blue) &&
				float.TryParse(strings[6], out float edgeLength))
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
			return false;
		}
	}
}
