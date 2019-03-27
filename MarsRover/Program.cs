using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

	class Program
	{

		private static Manager roverManager = new Manager();
		static void Main(string[] args)
		{
			roverManager.MainManagerLoop();
		}
	}
}
