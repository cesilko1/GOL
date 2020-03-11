using System;

namespace GolWorld {

	public class Cursor {
		//==================== ATRIBUTES ====================//

		//cursoe position
		public int X { get; private set; }
		public int Y { get; private set; }

		//world dimensions
		private int WorldSizeX;
		private int WorldSizeY;

		//cursor char
		private char CursorChar = 'X';


		//==================== CONSTRUCTORS ====================//

		//set first position of cursor and world dimensions
		public Cursor(int WorldSizeX, int WorldSizeY, int X, int Y) {
			this.X = X;
			this.Y = Y;

			this.WorldSizeX = WorldSizeX;
			this.WorldSizeY = WorldSizeY;
		}


		//==================== METHODS ====================//

		//print cursor or colored block
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

		//moving right
		public void MoveRight() {
			if(X < WorldSizeX-1) {
				X++;
			}
		}

		//moving left
		public void MoveLeft() {
			if(X > 0) {
				X--;
			}
		}

		//moving up
		public void MoveUp() {
			if(Y > 0) {
				Y--;
			}
		}

		//moving down
		public void MoveDown() {
			if(Y < WorldSizeY-1) {
				Y++;
			}
		}

	}

}