using System;
namespace Assignment4.Entity
{
	public class Department
	{ 
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Location { get; set; }

		public override string ToString()
		{
			return "ID: " + Id + " Name: " + Name+" Location: "+Location;
		}

	}
}

