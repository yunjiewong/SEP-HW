using System;
using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;

namespace DapperTutorial.Presentation.UI
{
	public class ManageDepartment
	{
		//Dependency injection

		DepartmentRepository departmentRepository;
		public ManageDepartment()
		{
			departmentRepository = new DepartmentRepository();
		}

		private void AddDepartment()
        {
			Department d = new Department();
			Console.Write("Enter Name of Department: ");
			d.DName = Console.ReadLine();
			Console.Write("Enter Location: ");
			d.Loc = Console.ReadLine();

			if (departmentRepository.Insert(d) > 0)
            {
				Console.WriteLine("Successfully Inserted!");
            }
            else
            {
				Console.WriteLine("Error!");
			}
		}

		private void UpdateDepartment()
        {
			Department d = new Department();
			Console.Write("Enter Name of Department: ");
			d.DName = Console.ReadLine();
			Console.Write("Enter Location: ");
			d.Loc = Console.ReadLine();

			if (departmentRepository.Update(d) > 0)
			{
				Console.WriteLine("Successfully Updated");
			}
			else
			{
				Console.WriteLine("Error");
			}

		}
		private void DeleteDepartment()
		{
			Console.Write("Enter Id Number to Delete: ");
			int id = Convert.ToInt32(Console.ReadLine());
			departmentRepository.DeleteById(id);
		}

		private void ReadAllDepartments()
		{
			IEnumerable<Department> departments = departmentRepository.GetAll();
			foreach (var item in departments)
			{
				Console.WriteLine($"{item.Id} \t {item.DName} \t {item.Loc}");
			}
		}

		public void run()
        {
			AddDepartment();

			ReadAllDepartments();
		}
	}
}

