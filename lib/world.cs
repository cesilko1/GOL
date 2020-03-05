using System;
using System.Linq;

namespace GolWorld {

	public class World {
		//==================== ATRIBUTES ====================//

		//World dimensions
		private int WorldSizeX;
		private int WorldSizeY;

		//2D array with cells
		private Cell[,] cells;

		//console output type
		private bool Colored = false;

		//activation of cursor
		private bool CursorActive = true;

		private Cursor cursor;


		//==================== CONSTRUCTORS ====================//

		//assign dimensions
		public World(int WorldSizeX, int WorldSizeY) {
			this.WorldSizeX = WorldSizeX;
			this.WorldSizeY = WorldSizeY;
			this.cells      = new Cell[WorldSizeX, WorldSizeY];
			this.cursor     = new Cursor(WorldSizeX, WorldSizeY, WorldSizeX/2, WorldSizeY/2);


			FillCell();
		}

		//assign dimensions and console output type
		public World(int WorldSizeX, int WorldSizeY, bool Colored) {
			this.WorldSizeX = WorldSizeX;
			this.WorldSizeY = WorldSizeY;
			this.Colored    = Colored;
			this.cells      = new Cell[WorldSizeX, WorldSizeY];
			this.cursor     = new Cursor(WorldSizeX, WorldSizeY, WorldSizeX/2, WorldSizeY/2);

			FillCell();
		}


		//==================== METHODS ====================//

		//revives the cell and set type in next generation
		public void ReviveCell(int X, int Y) {
			try {
				cells[X, Y].NextGenAlive = true;
			}
			catch {}
		}

		//kills the cell in next generation
		public void KillCell(int X, int Y) {
			try {
				cells[X, Y].NextGenAlive = false;
			}
			catch {}
		}

		//displays world in console
		public void Display() {

			Console.Clear();

			//print top border
			FrameHorizontal();
			Console.WriteLine();			

			//print columns
			for(int Y = 0; Y < WorldSizeY; Y++) {

				//print left border
				FrameVertical();

				//print rows
				for(int X = 0; X < WorldSizeX; X++) {


					if(cursor.X == X && cursor.Y == Y && CursorActive) {
						cursor.Show(Colored);
					}

					else {
						//print cell char
						cells[X, Y].Show(Colored);
					}

				}

				//print right border
				FrameVertical();

			}

			//print bottom border
			FrameHorizontal();

		}

		//next generation of cells
		public void NextGen() {

			//check if the cell will die or survive
			for(int Y = 0; Y < WorldSizeY; Y++) {

				for(int X = 0; X < WorldSizeX; X++) {

					//check if the cell will survive or die
					if( Rules.AliveRule(GetCountOfCells(X, Y), cells[X, Y].Alive) ) {
						ReviveCell(X, Y);
					}
					else {
						KillCell(X, Y);
					}

				}
			}

			CellsNextGen();

		}

		//make new generation of cells
		public void CellsNextGen() {
			for(int Y = 0; Y < WorldSizeY; Y++) {
				for(int X = 0; X < WorldSizeX; X++) {
					cells[X, Y].NextGen();
				}
			}
		}

		//returns the number of cells of the same type in given area
		public int GetCountOfCells(int x, int y) {

			//number of cells of the same type in given area
			int CellCount = 0;


			//list area rows
			for(int Y = y-1; Y <= y+1; Y++) {

				//scan columns in row
				for(int X = x-1; X <= x+1; X++) {

					//using try-catch because the coordinates may be out of the world
					try {

						//if cell allive, has the same type of cell and its not cell on given coordinates
						if( (cells[X, Y].Alive) && ((X != x) || (Y != y)) ) {
							CellCount++;
						}

					}
					catch {}

				}

			}

			return CellCount;
		}

		//opens the cursor
		public void OpenCursor() {

			CursorActive = true;

			ConsoleKeyInfo btn;

			Display();

			do {
				btn = Console.ReadKey(true);
				
				switch(btn.Key) {
					case ConsoleKey.UpArrow:
						cursor.MoveUp();
						break;
					case ConsoleKey.DownArrow:
						cursor.MoveDown();
						break;
					case ConsoleKey.LeftArrow:
						cursor.MoveLeft();
						break;
					case ConsoleKey.RightArrow:
						cursor.MoveRight();
						break;
					case ConsoleKey.Enter:
						ReviveCell(cursor.X, cursor.Y);
						break;
					default:
						break;
				}
				CellsNextGen();
				Display();
			}
			while(btn.Key != ConsoleKey.Escape);

			CursorActive = false;

		}


		//==================== PRIVATE METHODS ====================//

		//fill array with cells
		private void FillCell() {

			//fill rows
			for(int Y = 0; Y < this.WorldSizeY; Y++) {

				//fill columns
				for(int X = 0; X < this.WorldSizeX; X++) {
					cells[X, Y] = new Cell('O', ' ');
				}

			}

		}

		//print colored or ASCI horizontal frame
		private void FrameHorizontal() {

			if(Colored) {

				for(int i = 0; i < WorldSizeX+2; i++) {
					Console.BackgroundColor = ConsoleColor.Blue;
					Console.Write(" ");
					Console.ResetColor();
				}

			}

			else {

				for(int i = 0; i < WorldSizeX+2; i++) {
					Console.Write("=");
				}

			}
		}

		//print colored or ASCI vertical frame
		private void FrameVertical() {

			if(Colored) {
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.Write(" ");
				Console.ResetColor();
			}

			else {
				Console.Write("|");
			}
		}



	}
	
}