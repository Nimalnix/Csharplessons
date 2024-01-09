using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class Employee
    {

            public int EmployeeId { get; set; }//get-->returns the value;; set-->get the value from the user and holds it;;
            public string EmployeeName { get; set; }
            public string Designation { get; set; }
            public string Department { get; set; }
        }
        class Program3
        {
            static List<Employee> employees = new List<Employee>();

           public static void Main()
            {
                bool isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Retrieve Employee Details");
                    Console.WriteLine("3. Edit Employee Details");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddEmployee();
                            break;
                        case 2:
                            RetrieveEmployee();
                            break;
                        case 3:
                            EditEmployee();
                            break;
                        case 4:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            public static void AddEmployee()
            {
                Console.WriteLine("Enter Employee Id: ");
                int id = int.Parse((Console.ReadLine()));
                Console.WriteLine("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Designation: ");
                string designation = Console.ReadLine();
                Console.WriteLine("Enter Department: ");
                string department = Console.ReadLine();

                employees.Add(new Employee
                {
                    EmployeeId = id,
                    EmployeeName = name,
                    Designation = designation,
                    Department = department
                });

                Console.WriteLine("Employee details added successfully.");
            }

            static void RetrieveEmployee()
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Employee Id: {employee.EmployeeId}");
                    Console.WriteLine($"Employee Name: {employee.EmployeeName}");
                    Console.WriteLine($"Designation: {employee.Designation}");
                    Console.WriteLine($"Department: {employee.Department}");
                    Console.WriteLine("-------------------------------");
                }
            }

            static void EditEmployee()
            {
                Console.WriteLine("Enter the Employee Id to edit details: ");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var employee in employees)
                {
                    id = employee.EmployeeId;

                    if (employee == null)
                    {
                        Console.WriteLine("Employee not found.");
                    }
                    else
                    {
                        Console.WriteLine("Enter new Employee Name: ");
                        employee.EmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter new Designation: ");
                        employee.Designation = Console.ReadLine();
                        Console.WriteLine("Enter new Department: ");
                        employee.Department = Console.ReadLine();
                        Console.WriteLine("Employee details updated successfully.");
                    }
                }
            }
        }
     
    }

