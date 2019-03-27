using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
	public class SpinningControl
	{
		static  List<Directions> directions =
					new List<Directions>();

		public Dictionary<char, Func<string, string>> SpinningFunctions =
							new Dictionary<char, Func<string, string>>
		{
			{'L', TurnLeft},
			{'R', TurnRight},
			{'M', Stay }
		};
		public string GetNextDirection(string currentDirection, char stepCommand)
		{
			return SpinningFunctions[stepCommand](currentDirection);
		}

		private static string TurnRight(string currentDirection)
		{
			LinkedListNode<string> currentIndex = directions.Find(currentDirection);
			return currentIndex.PreviousOrLast().Value;
		}

		private static string TurnLeft(string currentDirection)
		{
			LinkedListNode<string> currentIndex = directions.Find(currentDirection);
			return currentIndex.NextOrFirst().Value;
		}

		private static string Stay(string currentDirection)
		{
			return currentDirection;
		}
	}
}
