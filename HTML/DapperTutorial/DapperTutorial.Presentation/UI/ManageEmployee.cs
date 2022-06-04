using System;
using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;
using DapperTutorial.Presentation.Menu;

namespace DapperTutorial.Presentation.UI
{
	public class ManageEmployee
	{
		EmployeeRepository employeeRepository = new EmployeeRepository();

        private void AddEmployee()
        {
            Employee e = new Employee();
            Console.Write("Enter First Name: ");
            e.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            e.LastName = Console.ReadLine();
            Console.Write("Enter Salary ==>");
            e.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Department Id: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());

            employeeRepository.Insert(e);

        }

        private void GetAllEmployees()
        {
            IEnumerable<Employee> employees = employeeRepository.GetAll();
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FirstName} \t {item.Salary} \t {item.Dept.DName}");
            }
        }
        private void UpdateEmployee()
        {
            Employee e = new Employee();
            Console.Write("Enter First Name: ");
            e.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            e.LastName = Console.ReadLine();
            Console.Write("Enter Salary ==>");
            e.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Department Id: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());

            if (employeeRepository.update(e) > 0)
            {
                Console.WriteLine("Successfully Updated!");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }

        private void DeleteEmployee()
        {
            Console.Write("Enter Id Number to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            employeeRepository.DeleteById(id);
        }

        private void GetEmployee()
        {
            Console.Write("Enter Id Number to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            employeeRepository.GetById(id);
        }

        public void Run()
        {

            //Do While loop here that uses Enums and Switches to continously ask for operation till exit
            AddEmployee();
            GetAllEmployees();

            int id;
            do
            {
                Console.WriteLine(" Insert:1, Delete:2, Update:3, PrintOneEmployee:4, PrintAll:5, Exit:6");
                Console.Write("Enter options to begin: ");
                id = Convert.ToInt32(Console.ReadLine());
                switch (id)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        DeleteEmployee();
                        break;
                    case 3:
                        UpdateEmployee();
                        break;
                    case 4:
                        GetEmployee();
                        break;
                    case 5:
                        GetAllEmployees();
                        break;
                    default:
                        Console.Write("Re-enter options to begin: ");
                        break;
                }
            } while (id == 6);
           

            


        }
    }
}

