using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class CanvasCordinates
	{
		public int X { get; set; }
		public int Y { get; set; }

		public CanvasCordinates()
		{
			X = 0;
			Y = 0;
		}

		public CanvasCordinates(int x, int y)
		{
			X = x;
			Y = y;
		}

		public WorldCordinates WorldCordinates(Camera camera)
		{
			WorldCordinates worldCordinates = new WorldCordinates();
			worldCordinates.X = (int)((X - camera.x) / camera.scale);
			worldCordinates.Y = (int)((Y - camera.y) / camera.scale);
			return worldCordinates;
		}
	}
}
