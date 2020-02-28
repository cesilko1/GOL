# Game of Life



* ## namespace GolWorld
	* ### Cell
		* Cell()

		* *public* Show()

		* *public* NextGen()


	* ### World
		* World(X, Y)

		* *public* ReviveCell(X, Y, Type)

		* *public* ReviveCellHard(X, Y, Type)

		* *public* KillCell(X, Y)

		* *public* KillCellHard(X, Y)

		* *public* GetCountOfCells(X, Y)

		* *public* NextGen()

		* *public* Display()

		* *private* FillCell()

	* ### Rules
		* *public static* AliveRule(CellsAround)