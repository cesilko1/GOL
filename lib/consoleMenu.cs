using System;
using System.Collections.Generic;

namespace Menu {

	public class ConsoleMenu {

		private List<Button> MenuItems = new List<Button>();
		private string MenuHeader;

 
		public ConsoleColor TextColor;
		public ConsoleColor HighlightColor;


		public ConsoleMenu(string MenuHeader) {
			this.MenuHeader = MenuHeader;
		}


		public void AddItem(Button Item) {
			MenuItems.Add(Item);
		}

		public void Show() {
			Console.WriteLine(MenuHeader);
			Console.WriteLine(MenuItems[0].Show());
		}

	}

}