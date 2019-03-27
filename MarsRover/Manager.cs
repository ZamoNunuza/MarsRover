using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

	public class Manager
	{
		public List<Rover> rovers = new List<Rover>();
		public List<Rover.Moves> Moves = new List<Rover.Moves>();

		/* Add a rover */
		public void AddRover()
		{
			Console.WriteLine("\n-- Add Rover Menu. --");

			Console.Write("coordinateX: ");
			long coordinateX = (long)Int32.Parse(Console.ReadLine());

			Console.Write("coordinateY: ");
			long coordinateY = (long)Int32.Parse(Console.ReadLine());

			Console.Write("startX: ");
			int startX = (int)Int32.Parse(Console.ReadLine());

			Console.Write("startY: ");
			int startY = (int)Int32.Parse(Console.ReadLine());

			Console.Write("name: ");
			string name = Console.ReadLine();

			Console.Write("Enter moves: ");
			string inputs = Console.ReadLine();
			//while (!string.IsNullOrEmpty(input))
			//{
			//	moves.Add(input);
			//	input = Console.ReadLine();
			//}





			//Console.Write("startingLifeTime: ");
			//int startingLifeTime = Int32.Parse(Console.ReadLine());

			this.rovers.Add(new Rover(coordinateX, coordinateY, startX, startY, inputs, name));
		}
		public void DestroyRovers()
		{
			for (int n = rovers.Count - 1; n >= 0; n--)
			{
				Rover rover = rovers[n];

				if (rover.RoverDead())
				{
					rovers.Remove(rover);
				}
			}
		}

		/* Update each rover vvv */
		public void UpdateRovers()
		{
			int move = 1;
			int left = 90;
			int right = 90;
			var output = "";
			List<Rover.Moves> moves = new List<Rover.Moves>();


			for (int n = rovers.Count - 1; n >= 0; n--)
			{
				Rover rover = rovers[n];
				
				rover.UpdateRover();
			}
		}

		/* Main rover manager loop */
		public void MainManagerLoop()
		{
			while (true)
			{
				AddRover();
				UpdateRovers();
				DestroyRovers();
			}
		}
	}
}
