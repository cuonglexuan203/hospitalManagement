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
        private Doctors doctorList;
        private Patients patientList;
        // Dynamic field
        // Properties

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Room { get => room; set => room = value; }
        internal Doctors DoctorList { get => doctorList; set => doctorList = value; }
        internal Patients PatientList { get => patientList; set => patientList = value; }

        // Constructors
        public Faculty()
        {
            doctorList = new Doctors();
            patientList = new Patients();
           

        }
        public Faculty(string id, string name, string description, string room, Doctors doctorList, Patients patientList)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.room = room;
            this.doctorList = doctorList;
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

        public virtual void Input1()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
            Console.WriteLine("List of doctors: ");
            Console.WriteLine("Number of doctors: ");
            int i = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < i; j++)
            {
                Doctor doctor = new Doctor();
                DoctorList.AddItem(doctor);
            }

            Console.WriteLine("The patient list: ");
            Console.WriteLine("Number of patient in charge: ");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < k; j++)
            {
                Patient patient = new Patient();
                PatientList.AddItem(patient);
            }
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
            Console.WriteLine($"The doctors list: {doctorList.Count}");
            doctorList.ShowInformation();
        }
        // General method
        // Other method
        // Overriding
    }
}
