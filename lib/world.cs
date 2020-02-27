using System;

namespace GolWorld {

	public class World {
		//==================== ATRIBUTES ====================//

		//World dimensions
		private int WorldSizeX;
		private int WorldSizeY;

		//2D array with cells
		private Cell[,] cells;


		//==================== CONSTRUCTORS ====================//

		//assign dimensions
		public World(int WorldSizeX, int WorldSizeY) {
			this.WorldSizeX = WorldSizeX;
			this.WorldSizeY = WorldSizeY;
			this.cells = new Cell[WorldSizeX, WorldSizeY];

			FillCell();
		}


		//==================== METHODS ====================//

		//revives the cell and set type
		public void ReviveCell(int X, int Y, char Type) {
			cells[X, Y].Alive = true;
			cells[X, Y].Type  = Type;
		}

		//kills the cell
		public void KillCell(int X, int Y) {
			cells[X, Y].Alive = false;
		}

		//displays world in console
		public void Display() {

			Console.Clear();

			//print top border
			for(int i = 0; i < WorldSizeX+2; i++) {
				Console.Write("=");
			}
			Console.WriteLine();

			//print columns
			for(int Y = 0; Y < WorldSizeY; Y++) {

				//print left border
				Console.Write("|");

				//print rows
				for(int X = 0; X < WorldSizeX; X++) {
					cells[X, Y].Show();
				}

				//print right border
				Console.WriteLine("|");

			}

			//print bottom border
			for(int i = 0; i < WorldSizeX+2; i++) {
				Console.Write("=");
			}

		}


		//==================== PRIVATE METHODS ====================//

		//fill array with cells
		private void FillCell() {

			//fill rows
			for(int Y = 0; Y < this.WorldSizeY; Y++) {

				//fill columns
				for(int X = 0; X < this.WorldSizeX; X++) {
					cells[X, Y] = new Cell();
				}

			}

		}



	}
	
}