using System;
using GolWorld;
using System.Threading;

class gol {

	static void Main(string[] args) {
		int delay = 100;
		
		Console.CursorVisible = false;
		
		World world = new World(Console.WindowWidth-2, Console.WindowHeight-3, true);
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


		world.ReviveCell(30,15);
		world.ReviveCell(31,15);
		world.ReviveCell(32,15);
		world.ReviveCell(29,16);
		world.ReviveCell(29,14);
		world.ReviveCell(33,14);
		world.ReviveCell(33,16);


		world.CellsNextGen();

		world.Display();

		Thread.Sleep(delay);

		
		for(int i = 0; i < 50; i++) {

			world.NextGen();

			world.Display();

			Console.WriteLine();
			int genNum = i+1;
			Console.Write("generation: " + genNum);

			Thread.Sleep(delay);
		}
		
		

		Console.CursorVisible = true;
		Console.ReadKey();
		Console.WriteLine();
	}

}