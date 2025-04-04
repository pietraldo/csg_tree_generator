using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class Cylinder:Node
	{
		public float Radius { get; set; }
		public float Height { get; set; }

		public float PosX { get; set; }
		public float PosY { get; set; }
		public float PosZ { get; set; }

		public int Red { get; set; }
		public int Green { get; set; }
		public int Blue { get; set; }

		public float RotationX { get; set; }
		public float RotationY { get; set; }
		public float RotationZ { get; set; }
	}
}
