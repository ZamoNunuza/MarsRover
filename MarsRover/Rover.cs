using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
	public class Rover
	{
		public long x;
		public long y;
		public int X;
		public int Y;

		public class Moves {
			public string m = "1";
			public string l = "90";
			public string r = "90";
		}
		


		public string point;
		public int lifeTime;

		public Rover(long coordinateX, long coordinateY,int startX, int startY, List<Moves> Moves,  string cardinal)
		{
			this.x = coordinateX;
			this.y = coordinateY;
			this.X = startX;
			this.Y = startY;

			List<Moves> moves = new List<Moves>();
			Moves = moves;

			this.point = cardinal;
			//this.lifeTime = lifeTime;
		}

		/* Update the rover lifetime */
		public void UpdateRoverLifeTime(int xChange, int yChange)
		{
			this.lifeTime -= Math.Abs(xChange - yChange);
		}

		/* Move the rover a desired amount */
		public void MoveRover(int xChange, int yChange)
		{

			if (xChange <= 5 && yChange <= 5 && xChange >= -5 && yChange >= -5)
			{
				this.x += xChange;
				this.y += yChange;
				UpdateRoverLifeTime(xChange, yChange);
			}
			else
			{
				Console.WriteLine("\nPOSITION CHANGE MUST BE <= 5 or >= -5.");
			}
		}
		public void GetRoverPositionChange()
		{
			Console.WriteLine("\n-- Rover Position Changer Menu. --");

			Console.Write("xChange: ");
			int xChange = Int32.Parse(Console.ReadLine());

			Console.Write("yChange: ");
			int yChange = Int32.Parse(Console.ReadLine());

			MoveRover(xChange, yChange);
		}
		/* Output rover statistics */
		public void OutputRoverStats()
		{
			Console.WriteLine("\n-- Rover Stats Menu. --");
			Console.WriteLine("Rover: {0}", this.point);
			Console.WriteLine("x: {0}, y: {1}", this.x, this.y);
			Console.WriteLine("Life: {0}", this.lifeTime);
		}
		
		public bool RoverDead()
		{
			return this.lifeTime > 0;
		}

		/* Main rover update "loop" */
		public void UpdateRover()
		{
			//GetRoverPositionChange();
			OutputRoverStats();
		}
	}
}
