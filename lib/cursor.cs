using System;

namespace GolWorld {

	public class Cursor {

		//cursoe position
		public int X { get; private set; }
		public int Y { get; private set; }

		//world dimensions
		private int WorldSizeX;
		private int WorldSizeY;

		//cursor char
		private char CursorChar = 'X';


		public Cursor(int WorldSizeX, int WorldSizeY, int X, int Y) {
			this.X = X;
			this.Y = Y;

			this.WorldSizeX = WorldSizeX;
			this.WorldSizeY = WorldSizeY;
		}


		public void Show(bool Colored) {
			if(!Colored) {
				Console.Write(CursorChar);
			}
			else {
				Console.BackgroundColor = ConsoleColor.Green;
				Console.Write(' ');
				Console.ResetColor();
			}
		}

		public void MoveRight() {
			if(X < WorldSizeX-1) {
				X++;
			}
		}

		public void MoveLeft() {
			if(X > 0) {
				X--;
			}
		}

		public void MoveUp() {
			if(Y > 0) {
				Y--;
			}
		}

		public void MoveDown() {
			if(Y < WorldSizeY-1) {
				Y++;
			}
		}

	}

}