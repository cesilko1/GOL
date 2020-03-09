using System;
using GolWorld;
using System.Threading;
using System.Linq;
using System.Text;
using Menu;

class gol {

	static void Main(string[] args) {
		
		ConsoleMenu Menu = new ConsoleMenu("Menu");

		Menu.AddItem(new Button("START"));

		Menu.Show();

	}

}