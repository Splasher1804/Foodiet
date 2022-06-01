using System;
using System.Collections.Generic;

namespace MVCController.Models

{
	public class Users
	{
		public int ID { get; set; } //cheie primara
		public string Ussrname { get; set; }
		
		public Array Meals_History { get; set; }

		public virtual ICollection<Meal> Meals { get; set; } //nav property
}
}
