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
        private List<Doctor> doctors;
        private List<Patient> patients;
        // Infor field
        private string nameOfFaculty;


        //  Management field
        // Dynamic field
        // Properties
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
        }

        // Destructors
        ~Faculty() { }
        // Methods
        // in, output
        public void Input ()
        {
            Console.Write("Name: ");
            NameOfFaculty = Console.ReadLine();
            Console.Write("List of doctors: ");

        }
        // General method
        // Other method
        // Overriding
    }
}
