using System;

namespace Cells {

	public class Cell {

		//status of cell with public getter and private setter
		public bool Alive { get; private set; } = false;

		//position of cell
		public int PositionX { get; private set; }
		public int PositionY { get; private set; }

		//characters to represent cell in console
		public char AliveChar { get; private set; } = '#';
		public char DeadChar { get; private set; } = ' ';


		//constructor for cell with position
		public Cell(int PositionX, int PositionY) {
			this.PositionX = PositionX;
			this.PositionY = PositionY;
		}

		//constructor for cell with position and char definitions
		public Cell(int PositionX, int PositionY, char AliveChar, char DeadChar) {
			this.PositionX = PositionX;
			this.PositionY = PositionY;
			this.AliveChar = AliveChar;
			this.DeadChar  = DeadChar;
		}

		public char Show() {
			if(Alive) {
				return AliveChar;
			}
			else {
				return DeadChar;
			}
		}
	}

}