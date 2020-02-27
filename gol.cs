using System;
using GolWorld;

class gol {

	static void Main(string[] args) {
		
		Console.CursorVisible = false;
		
		World world = new World(Console.WindowWidth-2, Console.WindowHeight-3);

		world.ReviveCell(20, 5, '#');
		world.ReviveCell(20, 6, '#');
		world.ReviveCell(21, 6, '#');

		world.ReviveCell(35, 3, 'O');
		world.ReviveCell(34, 2, 'O');

		world.Display();

		world.KillCell(20, 6);
		world.ReviveCell(21, 5, '#');
		world.ReviveCell(35, 2, 'O');

		world.Display();



		Console.CursorVisible = true;

		Console.ReadKey();
	}

}