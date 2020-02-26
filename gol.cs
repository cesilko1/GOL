using System;
using Cells;

class gol {

	static void Main(string[] args) {
		
		//disable cursor
		Console.CursorVisible = false;
		Console.Clear();

		//get width and height of world
		int WorldWidth = Console.WindowWidth;
		int WorldHeight = Console.WindowHeight;

		//create an array of world matrix
		Cell[,] World = new Cell[WorldWidth, WorldHeight];


		for(int Y = 0; Y < WorldHeight; Y++) {

			for(int X = 0; X < WorldWidth; X++) {

				World[X, Y] = new Cell(X, Y, '#', '.');

			}

		}

		
		for(int Y = 0; Y < WorldHeight; Y++) {

			for(int X = 0; X < WorldWidth; X++) {

				Console.Write(World[X, Y].Show());

			}

			Console.WriteLine();

		}

		Console.ReadKey();
	}

}