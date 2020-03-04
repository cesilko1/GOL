using System;
using GolWorld;

class gol {

	static void Main(string[] args) {
		
		Console.CursorVisible = false;

		char[] types = new char[2];
		types[0] = '#';
		types[1] = 'O';
		
		//World world = new World(Console.WindowWidth-2, Console.WindowHeight-3);
		World world = new World(20, 6, types);

		world.ReviveCell(10, 3, '#');
		world.ReviveCell(11, 3, '#');
		world.ReviveCell(12, 3, '#');
		world.ReviveCell(12, 2, '#');

		world.NextGen();

		world.Display();

		

		Console.WriteLine();

		Console.WriteLine(world.GetCountOfCells(11, 2)[1]);
		

		Console.CursorVisible = true;

		Console.ReadKey();
	}

}