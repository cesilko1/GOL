using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {
	public abstract class MenuItem {
		//==================== ATRIBUTES ====================//

		//item title
		protected string Title;

		//item data
		public ArrayList Data = new ArrayList();


		//==================== METHODS ====================//

		//action vhen pressed enter om menu item		
		public abstract bool Action();

		//show item in console
		public abstract string Show();

	}

}