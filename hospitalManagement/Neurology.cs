using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Neurology:Faculty
    {
        //Field
        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        // Constructors
        public Neurology()
        {

        }

        public Neurology(string id, string name, string description, string room, Employees employeeList, Patients patientList) : base(id, name, description, room, employeeList, patientList)
        {
        }
        // Destructors
        ~ Neurology()
        {

        }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
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
