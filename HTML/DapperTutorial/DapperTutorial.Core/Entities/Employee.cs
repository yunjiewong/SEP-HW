using System;
namespace DapperTutorial.Core.Entities
{
	public class Employee
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public decimal Salary { get; set; }

		public int DeptId { get; set; }

		//Navigational Properties
		public Department Dept { get; set; }

	}
}

