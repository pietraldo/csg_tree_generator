using System;
using System.Collections.Generic;
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

		public float Width { get; set; }

		public int Red { get; set; }
		public int Green { get; set; }
		public int Blue { get; set; }
	}
}
