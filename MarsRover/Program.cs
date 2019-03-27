﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
	public class Program
	{
		private readonly string input;
		private RoverNavigator roverNavigator;
		public RoverNavigationParameters RoverNavigationParameters { get; set; }
		public string FinalPosition { get; set; }


		public Program(string input)
		{
			this.input = input;
		}

		public void Initialize()
		{
			RoverNavigationParameters = InputValidator.GetNaviagtionParametersFromInput(input);
		}
		static void Main(string[] args)
		{
		}
	}
}