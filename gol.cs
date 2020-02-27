using System;
using GolWorld;

class gol {

	static void Main(string[] args) {
		
		Console.CursorVisible = false;
		
		//World world = new World(Console.WindowWidth-2, Console.WindowHeight-3);
		World world = new World(70, 20);

		world.ReviveCell(20, 5, '#');
		world.ReviveCell(20, 6, '#');
		world.ReviveCell(21, 6, 'O');
		world.ReviveCell(21, 7, '#');
		world.ReviveCell(20, 7, 'O');
		world.ReviveCell(22, 5, 'O');

		world.Display();

		Console.WriteLine();

		Console.Write(world.GetCountOfCells(21, 6));


		Console.CursorVisible = true;

		Console.ReadKey();
	}

}