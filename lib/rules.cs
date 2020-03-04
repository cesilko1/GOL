using System;

namespace GolWorld {

	public class Rules {
		//here is defined rules
		public static bool AliveRule(int CellsAround, bool ThisAlive) {


			if( (CellsAround == 3 || CellsAround == 2) && (ThisAlive == true) ) {
				return true;
			}
			else if(CellsAround < 2) {
				return false;
			}
			else if( (CellsAround >= 4) && (ThisAlive == true) ) {
				return false;
			}
			else if(CellsAround == 3 && (ThisAlive == false) ) {
				return true;
			}
			else {
				return false;
			}


		}

	}

}