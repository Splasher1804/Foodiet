using System;
using System.Collections.Generic;


namespace MVCController.Models

{
	public class Meal
	{
		public int MealID { get; set; }
		public int MealType { get; set; }

		public int FoodID { get; set; }
		public Food	Food { get; set; }
		public ICollection<Food> Calories { get; set; }

		public virtual ICollection<Food> Foods { get; set; }
}
}
