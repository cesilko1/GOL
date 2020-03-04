using System;
using GolWorld;

class gol {

	static void Main(string[] args) {
		
		Console.CursorVisible = false;

		char[] types = new char[2];
		types[0] = '#';
		types[1] = 'O';
		
		//World world = new World(Console.WindowWidth-2, Console.WindowHeight-3);
		World world = new World(3, 3, types);

		world.ReviveCell(0, 1, '#');
		world.ReviveCell(1, 1, '#');
		world.ReviveCell(2, 1, '#');

		world.CellsNextGen();

		world.Display();

		
		for(int i = 0; i < 1; i++) {

			world.NextGen();

			world.Display();
		}
		
		

		Console.CursorVisible = true;

		Console.ReadKey();
	}

}