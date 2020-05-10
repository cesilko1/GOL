# Game of Life

v 1.2.0

using [Menu library](https://github.com/cesilko1/console_menu).

---

run `app.exe`

When you press start in menu, you shlould see cursor `X` which you can move by pressing arrow keys. Press `c` to revive cell or `x` to kill cell. Then you can press enter for start life.

---

* ## namespace GolWorld
	* ### Cell
		* Cell()

		* Cell(*char* Type, *char* DeadChar)

		* *public void* Show(*bool* Colored)

		* *public void* NextGen()

	* ### Cursor
		* Cursor(*int* WorldSizeX, *int* WorldSizeY, *int* X, *int* Y)

		* *public void* Show(*bool* Colored)

		* *public void* MoveRight()

		* *public void* MoveLeft()

		* *public void* MoveUp()

		* *public void* MoveDown()


	* ### World
		* World(*int* X, *int* Y)

		* World(*int* X, *int* Y, *bool* Colored)

		* *public void* ReviveCell(*int* X, *int* Y)

		* *public void* KillCell(*int* X, *int* Y)

		* *public int* GetCountOfCells(*int* X, *int* Y)

		* *public void* NextGen()

		* *public void* CellsNextGen()

		* *public void* Display()

		* *public void* OpenCursor()

		* *private void* FillCell()

		* *private void* FrameHorizontal()

		* *private void* FrameVertical()

	* ### Rules
		* *public static bool* AliveRule(*int* CellsAround)
