using System;
using GolWorld;
using System.Threading;
using Menu;

class gol {

	static void Main(string[] args) {

		//thickness of border in chars
		const int VerticalBorderThickness   = 2;
		const int HorizontalBorderThickness = 3;

		//legth of: "generation: "
		const int IdentationSize = 12;

		//speed options in milliseconds
		const int slow   = 250;
		const int normal = 100;
		const int fast   = 25;



		ConsoleMenu menu = new ConsoleMenu("Game Of Life  v 1.2.5");

		menu.AddItem(new Button("START"));
		menu.AddItem(new Switcher("Colors"));
		menu.AddItem(new Input("Generations", "100"));
		menu.AddItem(new Option("Speed", new string[]{"Slow", "Normal", "Fast"}, 1));
		menu.AddItem(new Button("EXIT"));


		if(menu.Display() == 0) {
			int delay = 0;

			switch((string)menu.GetData()[3]) {
				case "Slow":
					delay = slow;
					break;
				case "Normal":
					delay = normal;
					break;
				case "Fast":
					delay = fast;
					break;
			}


			Console.CursorVisible = false;

			World world = new World(Console.WindowWidth-VerticalBorderThickness, Console.WindowHeight-HorizontalBorderThickness, (bool)menu.GetData()[1]);

			world.OpenCursor();

			Thread.Sleep(delay);

			int generations = int.Parse((string)menu.GetData()[2]);
			
			for(int i = 0; i < generations; i++) {

				world.NextGen();

				world.Display();

				int genNum = i+1;
				Console.Write("generation: " + genNum.ToString().PadRight(Console.WindowWidth-(IdentationSize+genNum.ToString().Length)));

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
