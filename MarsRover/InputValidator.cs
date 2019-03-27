using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
	public static class InputValidator
	{
		private static Coordinates plateauDimenstions;
		private static Coordinates currentCoordinates;
		private static string currentDirection;
		private static string command;

		private static string[] inputByLines;

		private const int expectedNumberOfInputs = 3;
		private const int LineWithPlateauDimension = 0;
		private const int LineWithStartPosition = 1;
		private const int LineWithCommand = 2;

		private const char linesDelimeter = '\n';
		private const char parametersDelimeter = ' ';

		private static readonly List<Directions> allowedDirections = new List<Directions>(); //{ "N", "W", "E", "S" };

		public static RoverNavigationParameters GetNaviagtionParametersFromInput(string input)
		{
			SplitInputByLines(input);
			SetPlateauDimensions(inputByLines);
			SetStartPositionAndDirection(inputByLines);
			SetCommand();

			return new RoverNavigationParameters(currentDirection, plateauDimenstions, currentCoordinates, command);
		}
		private static void SplitInputByLines(string input)
		{
			var splitString = input.Split(linesDelimeter);

			if (splitString.Length != expectedNumberOfInputLines)
			{
				throw new IncorrectInputFormatException();
			}

			inputByLines = splitString;
		}
		private static void SetCommands()
		{
			command = inputByLines[expectedLineWithCommand];
		}
		private static void SetPlateauDimensions(string[] inputLines)
		{
			var stringPlateauDimenstions = inputLines[expectedLineWithPlateauDimension].Split(parametersDelimeter);

			if (PlateauDimension(stringPlateauDimenstions))
			{
				throw new IncorrectPlateauDimensionsException();
			}

			plateauDimenstions = new Coordinates
			{
				X = Int32.Parse(stringPlateauDimenstions[0]),
				Y = Int32.Parse(stringPlateauDimenstions[1])
			};
		}
		private static bool StartPosition(string[] currentPositionAndDirection)
		{
			if (currentPositionAndDirection.Length != 3 || !currentPositionAndDirection[0].All(char.IsDigit)
			   || !currentPositionAndDirection[1].All(char.IsDigit) || !allowedDirections.Any(currentPositionAndDirection[2].Contains))
			{
				return true;
			}

			if (Int32.Parse(currentPositionAndDirection[0]) > plateauDimenstions.X ||
				Int32.Parse(currentPositionAndDirection[1]) > plateauDimenstions.Y)
			{
				return true;
			}

			return false;
		}
		private static bool PlateauDimension(string[] strPlateauDimenstions)
		{
			if (strPlateauDimenstions.Length != 2 || !strPlateauDimenstions[0].All(char.IsDigit)
			   || !strPlateauDimenstions[1].All(char.IsDigit))
			{
				return true;
			}

			return false;
		}
	}
}
