using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Obstetrics : Faculty
    {
        //Field
        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        // Constructors
        public Obstetrics()
        {

        }

        public Obstetrics(string id, string name, string description, string room, Doctors doctorList, Patients patientList)
        {
            Id = id;
            Name = name;
            Description = description;
            Room = room;
            DoctorList = doctorList;
            PatientList = patientList;
        }
        // Destructors
        ~ Obstetrics()
        {

        }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
        }

        public override void Input1()
        {
            base.Input1();
        }

        public override void Output()
        {
            base.Output();
        }
        // General method
        // Other method
        // Overriding
    }
}
