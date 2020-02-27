using System;

namespace GolWorld {

	public class Cell {
		//==================== ATRIBUTES ====================//

		//status of cell
		public bool Alive = false;

		//position of cell
		public int PositionX { get; private set; }
		public int PositionY { get; private set; }

		//characters to represent cell in console
		public char Type = '#';
		public char DeadChar { get; private set; } = ' ';


		//==================== CONSTRUCTORS ====================//

		//constructor for cell with position and type
		public Cell(int PositionX, int PositionY) {
			this.PositionX = PositionX;
			this.PositionY = PositionY;
		}

		//constructor for cell with position and char definitions
		public Cell(int PositionX, int PositionY, char Type, char DeadChar) {
			this.PositionX = PositionX;
			this.PositionY = PositionY;
			this.Type      = Type;
			this.DeadChar  = DeadChar;
		}


		//==================== METHODS ====================//

		//returns console char
		public void Show() {

			if(Alive) {
				Console.Write(Type);
			}
			else {
				Console.Write(DeadChar);
			}

		}




	}

}