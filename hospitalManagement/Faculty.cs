using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Faculty
    {
        //Field
        private string id;
        // Infor field
        private string name;
        private string description;
        private string room;
        //  Management field
        private Employees employeeList;
        private Patients patientList;
        // Dynamic field
        // Properties

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Room { get => room; set => room = value; }
      
        internal Patients PatientList { get => patientList; set => patientList = value; }
        internal Employees EmployeeList { get => employeeList; set => employeeList = value; }

        // Constructors
        public Faculty()
        {
            employeeList = new Employees();
            patientList = new Patients();
           

        }
        public Faculty(string id, string name, string description, string room, Employees employeeList, Patients patientList)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.room = room;
            this.employeeList = employeeList;
            this.patientList = patientList;
        }

        // Destructors
        ~Faculty() { }

        // Methods
        // in, output
        public virtual void Input()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
        }


        public virtual void Output()
        {
            Console.WriteLine("The faculty");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: ");
            Console.WriteLine($"Room: {Room}");
            Console.WriteLine($"The patients list: {patientList.Count}");
            patientList.ShowInformation();
            Console.WriteLine($"The employees list: {employeeList.Count}");
            employeeList.ShowInformation();
        }
        // General method
        // Other method
        // Overriding

        public void AddPatient()
        {

            this.PatientList.AddItem();
        }

        public void RemovePatient(string id)
        {
            this.PatientList.RemoveItem(id);
        }

        public void ShowAllPatients()
        {
            this.PatientList.ShowInformation();
        }

        public Patient FindPatient(string id)
        {
            return this.PatientList.FindItem(id);
        }

        public Patient UpdatePatient(string id)
        {
            return this.PatientList.UpdateItem(id);
        }

        public void AddEmployee()
        {
            this.EmployeeList.AddItem();
        }

        public void RemoveEmployee(string id)
        {
            this.EmployeeList.RemoveItem(id);
        }

        public void ShowAllEmployee()
        {
            this.EmployeeList.ShowInformation();
        }

        public Employee FindEmployee(string id)
        {
            return this.EmployeeList.FindItem(id);
        }

        public Employee UpdateEmployee(string id)
        {
            return this.EmployeeList.UpdateItem(id);
        }

        public void ClearPatient()
        {
            this.PatientList.Clear();
        }

        public void ClearEmployee()
        {
            this.EmployeeList.Clear();
        }
    }
}
