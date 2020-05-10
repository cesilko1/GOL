using System;
using GolWorld;
using System.Threading;
using Menu;

class gol {

	static void Main(string[] args) {

		ConsoleMenu menu = new ConsoleMenu("Game Of Life  v-1.1.2");

		menu.AddItem(new Button("START"));
		menu.AddItem(new Switcher("Colors"));
		menu.AddItem(new Input("Generations", "100"));
		menu.AddItem(new Option("Speed", new string[]{"Normal", "Slow", "Fast"}));
		menu.AddItem(new Button("EXIT"));


		if(menu.Display() == 0) {
			int delay = 0;

			switch((string)menu.GetData()[3]) {
				case "Slow":
					delay = 250;
					break;
				case "Normal":
					delay = 100;
					break;
				case "Fast":
					delay = 25;
					break;
			}


			Console.CursorVisible = false;

			World world = new World(Console.WindowWidth-2, Console.WindowHeight-3, (bool)menu.GetData()[1]);

			world.OpenCursor();

			Thread.Sleep(delay);

			int generations = int.Parse((string)menu.GetData()[2]);
			
			for(int i = 0; i < generations; i++) {

				world.NextGen();

				world.Display();

				Console.WriteLine();
				int genNum = i+1;
				Console.Write("generation: " + genNum);

				Thread.Sleep(delay);
			}
			Console.WriteLine();

			Console.CursorVisible = true;

		}
		else {
			Console.WriteLine("Good bye...");
		}
	}

}
