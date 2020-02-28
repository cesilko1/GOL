using System;

namespace GolWorld {

	public class Cell {
		//==================== ATRIBUTES ====================//

		//status of cell
		public  bool Alive    = false;
		public  bool NextGenAlive = false;
		//characters to represent cell in console
		public  char Type     = '#';
		private char DeadChar = ' ';


		//==================== CONSTRUCTORS ====================//

		//constructor for cell
		public Cell() {}

		//constructor for cell with char definitions and type
		public Cell(char Type, char DeadChar) {
			this.Type     = Type;
			this.DeadChar = DeadChar;
		}


		//==================== METHODS ====================//

		//returns console char
		public void Show() {

			if(NextGenAlive) {
				Console.Write(Type);
			}
			else {
				Console.Write(DeadChar);
			}

		}


		public void NextGen() {
			Alive = NextGenAlive;
		}



	}

}