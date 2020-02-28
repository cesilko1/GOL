using System;

namespace GolWorld {

	public class Rules {

		//here is defined rules
		public static bool AliveRule(int CellsAround) {

			if(CellsAround == 2 || CellsAround == 3) {
				return true;
			}

			else if(CellsAround <= 2) {
				return false;
			}

			else {
				return false;
			}

		}

	}

}