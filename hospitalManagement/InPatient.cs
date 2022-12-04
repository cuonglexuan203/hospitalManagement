using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
   internal class InPatient:Patient
    {
        //Field	
        // Infor field	
        private string room;

        // Management field	
        // Dynamic field	
        // Properties	
        public string Room { get => room; set => room = value; }

        // Constructors	
        public InPatient()
        {

        }

        public InPatient(string firstName
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
        , string room) : base(firstName, lastName, dateOfBirth, ethnic, religion, nationality, numberOfHealthInsurance, career, address, phonenumber, gentle, relative, phoneNumberOfRelative, fees, admissionDates)
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
            this.Room = room;
        }


        // Destructors	
        ~InPatient() { }


        // Methods	

        // in, output

        // General method

        // Other method	

        // Overriding	
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Room: ");
            Room = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Room: {Room} ");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
