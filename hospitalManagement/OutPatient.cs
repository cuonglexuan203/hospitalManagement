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

        public OutPatient(string firstName
        , string lastName
        , string dateOfBirth
        , string ethnic
        , string religion
        , string nationality
        , string numberOfHealthInsurance
        , string career
        , string address
        , string phonenumber
        , int gentle
        , string relative
        , string phoneNumberOfRelative
        , Fee fees
        , ComeAndLeaveDate admissionDates
        , string ordinalNumber
        , string appointmentDate) : base(firstName, lastName, dateOfBirth, ethnic, religion, nationality, numberOfHealthInsurance, career, address, phonenumber, gentle, relative, phoneNumberOfRelative, fees, admissionDates)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Ethnic = ethnic;
            this.Religion = religion;
            this.Nationality = nationality;
            this.NumberOfHealthInsurance = numberOfHealthInsurance;
            this.Career = career;
            this.Address = address;
            this.Phonenumber = phonenumber;
            this.Gentle = gentle;
            this.Relative = relative;
            this.PhoneNumberOfRelative = phoneNumberOfRelative;
            this.Fees = fees;
            this.AdmissionDates = admissionDates;
            this.OrdinalNumber = ordinalNumber;
            this.AppointmentDate = appointmentDate;
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
