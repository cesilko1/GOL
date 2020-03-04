using System;
using GolWorld;
using System.Threading;

class gol {

	static void Main(string[] args) {
		int delay = 150;
		
		Console.CursorVisible = false;
		
		World world = new World(Console.WindowWidth-2, Console.WindowHeight-3);
		//World world = new World(3, 3);

		world.ReviveCell(20,10);
		world.ReviveCell(21,10);
		world.ReviveCell(22,10);
		world.ReviveCell(22,9);
		world.ReviveCell(21,9);
		world.ReviveCell(20,8);
		world.ReviveCell(19,10);
		world.ReviveCell(19,8);
		world.ReviveCell(23,11);
		world.ReviveCell(23,7);


		world.ReviveCell(40,20);
		world.ReviveCell(41,21);
		world.ReviveCell(42,22);
		world.ReviveCell(40,22);
		world.ReviveCell(42,20);
		world.ReviveCell(39,21);
		world.ReviveCell(43,21);
		world.ReviveCell(41,19);
		world.ReviveCell(41,23);
		world.ReviveCell(39,19);
		world.ReviveCell(43,19);
		world.ReviveCell(39,23);
		world.ReviveCell(43,23);


		world.CellsNextGen();

		world.Display();

		Thread.Sleep(delay);

		
		for(int i = 0; i < 100; i++) {

			world.NextGen();

			world.Display();

			Console.WriteLine();
			int genNum = i+1;
			Console.Write("generation: " + genNum);

			Thread.Sleep(delay);
		}
		
		

		Console.CursorVisible = true;
		Console.WriteLine();
	}

}