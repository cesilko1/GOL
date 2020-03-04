using System;

namespace GolWorld {

	public class Cell {
		//==================== ATRIBUTES ====================//

		//status of cell
		public  bool Alive        = false;
		public  bool NextGenAlive = false;
		//characters to represent cell in console
		public  char Type;
		private char DeadChar     = ' ';


		//==================== CONSTRUCTORS ====================//

		//only constructor
		public Cell() {}

		//constructor for cell with definition of dead char
		public Cell(char DeadChar) {
			this.DeadChar = DeadChar;
		}

		//constructor for cell with dead char and type char
		public Cell(char Type, char DeadChar) {
			this.Type     = Type;
			this.DeadChar = DeadChar;
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


		public void NextGen() {
			Alive = NextGenAlive;
		}



	}

}