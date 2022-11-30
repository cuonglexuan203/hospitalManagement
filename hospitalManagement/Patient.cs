using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Patient : IBasicActivities
    {
        //Field	
        private string id;

        // Infor field	
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string ethnic;
        private string religion;
        private string nationality;
        private string numberOfHealthInsurance;
        private string career;
        private string address;
        private string phonenumber;
        private int gentle;
        private string relative;
        private string phoneNumberOfRelative;

        // Management field
        private Fee fees;
        private AdmissionDate admissionDates;

        //private long 
        // Dynamic field	

        // Properties	


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Ethnic { get => ethnic; set => ethnic = value; }
        public string Religion { get => religion; set => religion = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string NumberOfHealthInsurance { get => numberOfHealthInsurance; set => numberOfHealthInsurance = value; }
        public string Career { get => career; set => career = value; }
        public string Address { get => address; set => address = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public int Gentle { get => gentle; set => gentle = value; }
        public string Relative { get => relative; set => relative = value; }
        public string PhoneNumberOfRelative { get => phoneNumberOfRelative; set => phoneNumberOfRelative = value; }
        public string Id { get => id; set => id = value; }
        internal Fee Fees { get => fees; set => fees = value; }
        internal AdmissionDate AdmissionDates { get => admissionDates; set => admissionDates = value; }



        //
        // Constructors	

        // public Patient(string firstName
        // , string lastName
        // , string dateOfBirth
        // , string ethnic
        // , string religion
        // , string nationality
        // , string numberOfHealthInsurance
        // , string career
        // , string address
        // , string phonenumber
        // , int gentle
        // , string relative
        // , string phoneNumberOfRelative
        // , Fee fees
        // , AdmissionDate admissionDates)
        // {
        //     this.firstName = firstName;
        //     this.lastName = lastName;
        //     this.dateOfBirth = dateOfBirth;
        //     this.ethnic = ethnic;
        //     this.religion = religion;
        //     this.nationality = nationality;
        //     this.numberOfHealthInsurance = numberOfHealthInsurance;
        //     this.career = career;
        //     this.address = address;
        //     this.phonenumber = phonenumber;
        //     this.gentle = gentle;
        //     this.relative = relative;
        //     this.phoneNumberOfRelative = phoneNumberOfRelative;
        //     this.fees = fees;
        //     this.admissionDates = admissionDates;
        // }


        // Destructors	
        // Methods	

        // in, output
        public void Input(string firstName,
                     string lastName,
                     string dateOfBirth,
                     string ethnic,
                     string religion,
                     string nationality,
                     string numberOfHealthInsurance,
                     string career,
                     string address,
                     string phonenumber,
                     int gentle,
                     string relative,
                     string phoneNumberOfRelative,
                     Fee fees,
                     AdmissionDate admissionDates)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Ethnic = ethnic;
            Religion = religion;
            Nationality = nationality;
            NumberOfHealthInsurance = numberOfHealthInsurance;
            Career = career;
            Address = address;
            Phonenumber = phonenumber;
            Gentle = gentle;
            Relative = relative;
            PhoneNumberOfRelative = phoneNumberOfRelative;
            Fees = fees;
            AdmissionDates = admissionDates;
        }
        public void Input()
        {
            Console.WriteLine("Id: ");
            Id = Console.ReadLine();
            Console.Write("FirstName: ");
            FirstName = Console.ReadLine();
            Console.Write("LastName: ");
            LastName = Console.ReadLine();
            Console.Write("DateOfBirth: ");
            DateOfBirth = Console.ReadLine();
            Console.Write("Ethnic: ");
            Ethnic = Console.ReadLine();
            Console.Write("Religion: ");
            Religion = Console.ReadLine();
            Console.Write("Nationality: ");
            Nationality = Console.ReadLine();
            Console.Write("NumberOfHealthInsurance: ");
            NumberOfHealthInsurance = Console.ReadLine();
            Console.Write("Career: ");
            Career = Console.ReadLine();
            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.Write("Phonenumber: ");
            Phonenumber = Console.ReadLine();
            Console.Write("Gentle: ");
            Gentle = Int32.Parse(Console.ReadLine()) == 0 ? 0 : 1;
            Console.Write("Relative: ");
            Relative = Console.ReadLine();
            Console.Write("PhoneNumberOfRelative: ");
            PhoneNumberOfRelative = Console.ReadLine();
            Console.WriteLine("Fees: ");
            Fees.Input();
            Console.WriteLine("AdmissionDates: ");
            AdmissionDates.Input();
        }
        public void Output()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"FirstName: {FirstName} ");
            Console.WriteLine($"LastName: {LastName} ");
            Console.WriteLine($"DateOfBirth: {DateOfBirth} ");
            Console.WriteLine($"Ethnic: {Ethnic} ");
            Console.WriteLine($"Religion: {Religion} ");
            Console.WriteLine($"Nationality: {Nationality} ");
            Console.WriteLine($"NumberOfHealthInsurance: {NumberOfHealthInsurance} ");
            Console.WriteLine($"Career: {Career} ");
            Console.WriteLine($"Address: {Address} ");
            Console.WriteLine($"Phonenumber: {Phonenumber} ");
            Console.WriteLine($"Gentle: {Gentle} ");
            Console.WriteLine($"Relative: {Relative} ");
            Console.WriteLine($"PhoneNumberOfRelative: {PhoneNumberOfRelative} ");
            Console.WriteLine($"Fees: {Fees} ");
            Console.WriteLine($"AdmissionDates: {AdmissionDates} ");
        }


        // General method

        // Other method	


        public void ShowInformation()
        {
            throw new NotImplementedException();
        }
        public float CalcBill()
        {
            throw new NotImplementedException();
        }

        public void ExportBill()
        {
            throw new NotImplementedException();
        }

        public void UpdateInformation()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }
        // Overriding	

    }
}
