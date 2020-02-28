using System;
using GolWorld;

class gol {

	static void Main(string[] args) {
		
		Console.CursorVisible = false;
		
		//World world = new World(Console.WindowWidth-2, Console.WindowHeight-3);
		World world = new World(20, 6);

		world.ReviveCell(10, 3, '#');
		world.ReviveCell(11, 3, '#');
		world.ReviveCell(12, 3, '#');
		world.ReviveCell(12, 2, '#');

		world.Display();

		

		Console.WriteLine();

		Console.WriteLine(world.GetCountOfCells(11, 2));
		

		Console.CursorVisible = true;

		Console.ReadKey();
	}

}