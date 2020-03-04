using System;

namespace GolWorld {

	public class Rules {

		//index of char in next generation
		public static int NextGenChar;

		//here is defined rules
		public static bool AliveRule(int[] CellsAround, bool ThisAlive, int AliveChar) {

			for(int i = 0; i < CellsAround.Length; i++) {

				if( (CellsAround[i] == 3 || CellsAround[i] == 2) && (ThisAlive == true) ) {
					NextGenChar = AliveChar;
					return true;
				}
				else if(CellsAround[i] > 2) {
					return false;
				}
				else if( (CellsAround[i] >= 4) && (ThisAlive == true) ) {
					return false;
				}
				else if(CellsAround[i] == 3 && (ThisAlive == false) ) {
					NextGenChar = i;
					return true;
				}

			}

			return false;

		}

	}

}