# Game of Life

v 0.1.0

* ## namespace GolWorld
	* ### Cell
		* Cell()

		* Cell(*char* DeadChar)

		* Cell(*char* Type, *char* DeadChar)

		* *public void* Show()

		* *public void* NextGen()


	* ### World
		* World(*int* X, *int* Y)

		* *public void* ReviveCell(*int* X, *int* Y)

		* *public void* KillCell(*int* X, *int* Y)

		* *public int* GetCountOfCells(*int* X, *int* Y)

		* *public void* NextGen()

		* *public void* CellsNextGen()

		* *public void* Display()

		* *private void* FillCell()

	* ### Rules
		* *public static* AliveRule(*int* CellsAround)