# Game of Life

v 0.1.1

* ## namespace GolWorld
	* ### Cell
		* Cell()

		* Cell(*char* Type, *char* DeadChar)

		* *public void* Show()

		* *public void* NextGen()


	* ### World
		* World(*int* X, *int* Y)

		* World(*int* X, *int* Y, *bool* Colored)

		* *public void* ReviveCell(*int* X, *int* Y)

		* *public void* KillCell(*int* X, *int* Y)

		* *public int* GetCountOfCells(*int* X, *int* Y)

		* *public void* NextGen()

		* *public void* CellsNextGen()

		* *public void* Display()

		* *private void* FillCell()

		* *private void* FrameHorizontal()

		* *private void* FrameVertical()

	* ### Rules
		* *public static bool* AliveRule(*int* CellsAround)