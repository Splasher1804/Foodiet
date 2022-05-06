using System;
using System.Collections.Generic;
using System.Text;

public class Meal
{
	public Meal()
	{
		public int MealID { get; set; }
		public Array Meal_Array { get; set; }
		public int MealCalories { get; set; }

		public virtual ICollection<Food> Foods { get; set; }
}
}
