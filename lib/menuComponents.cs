using System;

namespace Menu {

	public class Button {

		private string ButtonName;

		public Button(string ButtonName) {
			this.ButtonName = ButtonName;
		}

		public void Show() {
			Console.Write(ButtonName);
		}
	}

}