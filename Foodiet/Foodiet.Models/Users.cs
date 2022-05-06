using System;
using System.Collections.Generic;

public class Users
{
	public Users()
	{
		public int ID { get; set; } //cheie primara
		public string Ussrname { get; set; }

		public virtual ICollection<Meal> Meals { get; set; } //nav property
}
}
