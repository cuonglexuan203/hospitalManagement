using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hospitalManagement
{
    internal abstract class Employee : IBill
    {
        //Field
        private string id;

        // Infor field
        private string firstName;

        private string lastName;

        private int age;

        private int gentle;

        private string description;

        private string address;

        private string email;

        private string phone;

        //  Management field
        private string facultyId;

        private string departmentId;

        private bool state;


        private ComeAndLeaveDate admissionDates;

        private Salary salaries;

        // Dynamic field
        // Properties
        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int Gentle { get => gentle; set => gentle = value; }
        public string Description { get => description; set => description = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string FacultyId { get => facultyId; set => facultyId = value; }
        public string DepartmentId { get => departmentId; set => departmentId = value; }
        public bool State { get => state; set => state = value; }
        public ComeAndLeaveDate AdmissionDates { get => admissionDates; set => admissionDates = value; }
        public Salary Salaries { get => salaries; set => salaries = value; }
        // Constructors

        public Employee() {
            AdmissionDates = new ComeAndLeaveDate();
            Salaries = new Salary();
        }

        public Employee(string Id
        , string firstName
        , string lastName
        , int age
        , int gentle
        , string description
        , string address
        , string email
        , string phone
        , string facultyId
        , string departmentId
        , bool state
        , ComeAndLeaveDate admissionDates
        , Salary salaries
        )
        {
            this.Id = Id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gentle = gentle;
            this.description = description;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.facultyId = facultyId;
            this.departmentId = departmentId;
            this.state = state;
            this.admissionDates = admissionDates;
            this.salaries = salaries;
        }


        // Destructors
        ~Employee() { }
        // Methods
        // in, output
        public virtual void Input()
        {
            Console.Write("Employee Id: ");
            Id = Console.ReadLine();
            Console.Write("FirstName: ");
            FirstName = Console.ReadLine();
            Console.Write("LastName: ");
            LastName = Console.ReadLine();
            Console.Write("Age: ");
            Age = Int32.Parse(Console.ReadLine());
            Console.Write("Gentle (0: male, 1: female): ");
            Gentle = Int32.Parse(Console.ReadLine());
            Console.Write("Description: ");
            Description = Console.ReadLine();
            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Phone: ");
            Phone = Console.ReadLine();
            Console.Write("FacultyId: ");
            FacultyId = Console.ReadLine();
            Console.Write("DepartmentId: ");
            DepartmentId = Console.ReadLine();
            Console.Write("State(1: free, other: 0): ");
            State = Int32.Parse(Console.ReadLine()) == 1 ? true : false;
            Console.Write("AdmissionDates: ");
            AdmissionDates.Input();
            Console.Write("Salaries: ");
            Salaries.Input();


        }
        public virtual void Output()
        {
            Console.WriteLine("Employee Id: {0}", Id);
            Console.WriteLine("FirstName: {0}", FirstName);
            Console.WriteLine("LastName: {0}", LastName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Gentle: {0}", Gentle);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Phone: {0}", Phone);
            Console.WriteLine("FacultyId: {0}", FacultyId);
            Console.WriteLine("DepartmentId: {0}", DepartmentId);
            Console.WriteLine("State: {0}", State);
            Console.WriteLine("AdmissionDates:");
            AdmissionDates.Output();
            Console.WriteLine("Salaries: ");
            Salaries.Output();

        }

        // General method
        // Other method
        // Overriding
        public virtual void ExportBill()
        {

            Console.WriteLine($"The salary ( basis + bonus, allowance ): {CalcBill()}");
        }
        public virtual float CalcBill()
        => Salaries.Basic + Salaries.Bonus + Salaries.Allowance;








    }
}
