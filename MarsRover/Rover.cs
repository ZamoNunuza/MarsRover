using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
	public class Rover
	{
		

		public int x { get; set; }
		public int y { get; set; }
		public List<Moves> moves { get; set; }

		public Directions directions { get; set; }
		public Rover(int X, int Y, Directions directions, List<Moves> itemMoves)
		{
			
			List<Moves> Moves = new List<Moves>();
			Moves = itemMoves;

		}
	}
}
