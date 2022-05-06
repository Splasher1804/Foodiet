using System;
using System.Collections.Generic;
using System.Text;

public class Meal
{
	public Meal()
	{
		public int MealID { get; set; }
		public string Meal_Name { get; set; }

		public virtual ICollection<Food> Foods { get; set; }
}
}
