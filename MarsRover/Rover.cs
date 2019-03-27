﻿using System;
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
		public int startX;
		public int startY;

		public string moveInputs;

		List<Moves> moves = new List<Moves>
		{
			new Moves{m=1 },
			new Moves{l=90 },
			new Moves{r=90 }
		};
		public class Moves
		{
			public int m = 1;
			public int l = 90;
			public int r = 90;
		}

		public string movesInput { get; set; }
		public override string ToString()
		{
			return movesInput;
		}


		public string point;
		public int lifeTime;

		public Rover(long coordinateX, long coordinateY, int startX, int startY, string inputMoves, string cardinal)
		{
			this.x = coordinateX;
			this.y = coordinateY;
			this.startX = startX;
			this.startY = startY;
			this.moveInputs = inputMoves;
			this.point = cardinal;
			//this.lifeTime = lifeTime;
		}

		/* Update the rover lifetime */
		public void UpdateRoverLifeTime(int xChange, int yChange)
		{
			this.lifeTime -= Math.Abs(xChange - yChange);
		}

		/* Move the rover a desired amount */
		public void MoveRover(List<Moves> Moves)
		{
			List<Moves> moves = new List<Moves>();
			Moves = moves;

			foreach (var item in Moves)
			{
				var input = (item.m + item.r - item.l);
			}
		}
		public void GetRoverPositionChange()
		{
			List<Moves> moves = new List<Moves>();
			//Moves = moves;

			//Console.Write("Enter moves: ");
			//string inputs = String.Empty;

			string input = Console.ReadLine();

			var userinput = new List<Moves>(input.Length);



			MoveRover(userinput);
		}
		/* Output rover statistics */
		public void OutputRoverStats()
		{
			Console.WriteLine("\n-- Rover Stats Menu. --");
			Console.WriteLine("Rover: {0}", this.point);
			Console.WriteLine("coordinate x: {0}, coordinate y: {1}", this.x, this.y);
			Console.WriteLine("Start x: {0}, Start y: {1}", this.startX, this.startY);
			Console.WriteLine("movesEntered: {0}", this.moveInputs);
		}

		public bool RoverDead()
		{
			return this.lifeTime > 0;
		}

		/* Main rover update "loop" */
		public void UpdateRover()
		{
			GetRoverPositionChange();

			OutputRoverStats();
		}
	}
}
