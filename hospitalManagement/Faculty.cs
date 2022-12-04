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
<<<<<<< HEAD
        private string id;
        // Infor field
        private string name;
        private string description;
        private string room;
=======
        private List<Doctor> doctors;
        private List<Patient> patients;
        // Infor field
        private string nameOfFaculty;


>>>>>>> 7066e33ae2820a3e2137f509070683434afe6b71
        //  Management field
        private Doctors doctorList;
        private Patients patientList;
        // Dynamic field
        // Properties
<<<<<<< HEAD

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
=======
        public string NameOfFaculty { get => nameOfFaculty; set => nameOfFaculty = value; }
        internal List<Doctor> Doctors { get => doctors; set => doctors = value; }
        internal List<Patient> Patients { get => patients; set => patients = value; }
        // Constructors
        public Faculty()
        {

        }

        public Faculty(List<Doctor> doctors, List<Patient> patients, string nameOfFaculty)
        {
            this.doctors = doctors;
            this.patients = patients;
            this.nameOfFaculty = nameOfFaculty;
>>>>>>> 7066e33ae2820a3e2137f509070683434afe6b71
        }

        // Destructors
        ~Faculty() { }
<<<<<<< HEAD

        // Methods
        // in, output
        public void Input()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
        }

        public void Output()
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
=======
        // Methods
        // in, output
        public void Input ()
        {
            Console.Write("Name: ");
            NameOfFaculty = Console.ReadLine();
            Console.Write("List of doctors: ");

>>>>>>> 7066e33ae2820a3e2137f509070683434afe6b71
        }
        // General method
        // Other method
        // Overriding
    }
}
