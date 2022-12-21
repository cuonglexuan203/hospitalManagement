using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Employees : IBasicActivities<Employee>
    {
        //Field	
        private List<Employee> employeeList;
        private long count;


        // Infor field	
        //  Management field	
        // Dynamic field	
        // Properties	
        internal List<Employee> EmployeeList { get => employeeList; set => employeeList = value; }
        public long Count { get => count; set => count = value; }
        // Constructors	
        public Employees()
        {
            EmployeeList= new List<Employee>();
            count = 0;
        }

        public Employees(List<Employee> employeeList, long count)
        {
            this.employeeList = employeeList;
            this.count = count;
        }


        // Destructors	
        ~Employees() { }

        // Methods	
        // in, output
        // General method	
        // Other method


        public void AddItem()
        {
            Console.WriteLine("New the Employee");
            Console.WriteLine("Type of Employee (choose one): 1.Doctor 2.Nurse\n");
            string choice = Console.ReadLine();
            Employee employee = null;
            if (choice.ToLower() == "Doctor" || Int32.Parse(choice) == 1)
            {
                employee = new Doctor();
            }
            else
            {
                employee = new Nurse();
            }
            employee.Input();
            employeeList.Add(employee);
            this.Count++;
            Console.WriteLine("Done!");
        }



        public void ShowInformation()
        {
            Console.WriteLine("Show information of all employees");

            for (int i = 0; i < employeeList.Count; i++)
            {
                employeeList[i].Output();
            }
            Console.WriteLine("Done!");
        }

        public Employee UpdateItem(string id)
        {
            Console.WriteLine("Update the employee");

            Employee res = null;
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].Id == id)
                    employeeList[i].Input();
            }
            if (res == null)
            {
                Console.WriteLine($"Not found the employee with id:{id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the employee");

            bool res = false;
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].Id == id)
                {
                    if (employeeList[i].Id == id)
                    {
                        employeeList.Remove(employeeList[i]);
                        res = true;
                        this.Count--;
                    }
                }
            }
            if (res == false)
            {
                Console.WriteLine($"Not found employee with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public Employee FindItem(string id)
        {
            Employee res = null;
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].Id == id)
                    res = employeeList[i];
            }
            if (res == null)
            {
                Console.WriteLine($"Not found employee with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool Clear()
        {
            Console.WriteLine("Clear all employee");

            employeeList.Clear();
            if (employeeList.Count > 0)
            {
                Console.WriteLine("Failure");
                return false;
            }
            this.Count = 0;
            Console.WriteLine("Done!");
            return true;
        }

        // Overriding	


    }
}
