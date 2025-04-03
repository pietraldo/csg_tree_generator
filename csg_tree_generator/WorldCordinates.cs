using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator
{
	public class WorldCordinates
	{
		public int X { get; set; }
		public int Y { get; set; }

		public WorldCordinates()
		{
			X = 0;
			Y = 0;
		}
		public WorldCordinates(int x, int y)
		{
			X = x;
			Y = y;
		}

		public CanvasCordinates CanvasCordinates(Camera camera)
		{
			CanvasCordinates canvasCordinates = new CanvasCordinates();
			canvasCordinates.X = (int)(X * camera.scale) + camera.x;
			canvasCordinates.Y = (int)(Y * camera.scale) + camera.y;
			return canvasCordinates;
		}
	}
}
