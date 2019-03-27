using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
	public class MarsRover
	{
		private readonly string input;
		private RoverNavigator roverNavigator;
		public RoverNavigationParameters RoverNavigationParameters { get; set; }
		public string FinalPosition { get; set; }


		public MarsRover(string input)
		{
			this.input = input;
		}


	}
}
