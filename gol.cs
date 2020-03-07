using System;
using GolWorld;
using System.Threading;

class gol {

	static void Main(string[] args) {
		int delay = 100;
		
		Console.CursorVisible = false;
		
		World world = new World(Console.WindowWidth-2, Console.WindowHeight-3, false);

		world.OpenCursor();

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
	}

}