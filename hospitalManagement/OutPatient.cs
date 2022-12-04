using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class OutPatient:Patient
    {
        //Field	
        // Infor field	
        // Management field	
        private string ordinalNumber;
        private string appointmentDate;
        // Dynamic field	
        // Properties

        public string OrdinalNumber { get => ordinalNumber; set => ordinalNumber = value; }
        public string AppointmentDate { get => appointmentDate; set => appointmentDate = value; }

        // Constructors	
        public OutPatient()
        {

        }

        public OutPatient(string ordinalNumber, string appointmentDate)
        {
            this.ordinalNumber = ordinalNumber;
            this.appointmentDate = appointmentDate;
        }

        // Destructors	
        ~OutPatient() { }



        // Methods	

        // in, output

        // General method

        // Other method	

        // Overriding	

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Ordinal Number: ");
            OrdinalNumber = Console.ReadLine();
            Console.WriteLine("Appointment Date: ");
            AppointmentDate = Console.ReadLine();
        }


        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Ordinal Number: {OrdinalNumber}");
            Console.WriteLine($"Appointment Date: {AppointmentDate}");
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
