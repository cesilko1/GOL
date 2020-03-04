# Game of Life



* ## namespace GolWorld
	* ### Cell
		* Cell(*char* DeadChar)

		* Cell(*char* Type, *char* DeadChar)

		* *public void* Show()

		* *public void* NextGen()


	* ### World
		* World(*int* X, *int* Y, *char[]* availableTypes)

		* *public void* ReviveCell(*int* X, *int* Y, *char* Type)

		* *public void* KillCell(*int* X, *int* Y)

		* *public int[]* GetCountOfCells(*int* X, *int* Y)

		* *public void* NextGen()

		* *public void* CellsNextGen()

		* *public void* Display()

		* *private void* FillCell()

	* ### Rules
		* *public static* AliveRule(*int[]* CellsAround)