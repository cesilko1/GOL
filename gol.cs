using System;
using GolWorld;

class gol {

	static void Main(string[] args) {
		
		Console.CursorVisible = false;
		
		World world = new World(Console.WindowWidth-2, Console.WindowHeight-3);

		world.ReviveCell(20, 5, '#');
		world.ReviveCell(20, 6, '#');
		world.ReviveCell(21, 6, '#');

		world.ReviveCell(35, 3, 'X');
		world.ReviveCell(34, 2, 'X');

		world.Display();



		Console.CursorVisible = true;

		Console.ReadKey();
	}

}