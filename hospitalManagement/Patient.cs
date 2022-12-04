using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Patient:IBill
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
        private ComeAndLeaveDate admissionDates;

        private List<Doctor> doctorList; 
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
        internal ComeAndLeaveDate AdmissionDates { get => admissionDates; set => admissionDates = value; }
        internal List<Doctor> DoctorList { get => doctorList; set => doctorList = value; }





        //
        // Constructors	

        public Patient(string firstName
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
        , List<Doctor> doctorList)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.ethnic = ethnic;
            this.religion = religion;
            this.nationality = nationality;
            this.numberOfHealthInsurance = numberOfHealthInsurance;
            this.career = career;
            this.address = address;
            this.phonenumber = phonenumber;
            this.gentle = gentle;
            this.relative = relative;
            this.phoneNumberOfRelative = phoneNumberOfRelative;
            this.fees = fees;
            this.admissionDates = admissionDates;
            this.doctorList = doctorList;
        }

        public Patient()
        {
            Fees = new Fee();
            AdmissionDates = new ComeAndLeaveDate();
            DoctorList = new List<Doctor>();
        }


        // Destructors	
        ~Patient() { }
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
                     ComeAndLeaveDate admissionDates,
                     List<Doctor> doctorList)
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
            foreach (Doctor i in doctorList)
            {
                this.doctorList.Add(i);
            }
        }
        public virtual void Input()
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
            Console.WriteLine("Number of medical doctors: ");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < i; j++)
            {
                Doctor doctor = new Doctor();
                doctor.Input();
                doctorList.Add(doctor);
            }
        }
        public virtual void Output()
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
            Console.WriteLine("List of medical doctors: ");
            doctorList.ForEach(value => { value.Output(); Console.WriteLine(); });

        }


        // General method

        // Other method	



        // Overriding	
        public override string ToString()
       => $"Id: {id}"
       + $"Id: {Id}"
       + $"FirstName: {FirstName}"
       + $"LastName: {LastName} "
       + $"DateOfBirth: {DateOfBirth} "
       + $"Ethnic: {Ethnic} "
       + $"Religion: {Religion} "
       + $"Nationality: {Nationality} "
       + $"NumberOfHealthInsurance: {NumberOfHealthInsurance} "
       + $"Career: {Career} "
       + $"Address: {Address} "
       + $"Phonenumber: {Phonenumber} "
       + $"Gentle: {Gentle} "
       + $"Relative: {Relative} "
       + $"PhoneNumberOfRelative: {PhoneNumberOfRelative} "
       + $"Fees: {Fees} "
       + $"AdmissionDates: {AdmissionDates} "
       + $"List of medical doctor: {doctorList}";

        public void ExportBill()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("             RECEIPT             ");
            Console.WriteLine($"Receipt Date: {now}");
            Console.WriteLine($"ID of patient: {Id}");
            Console.WriteLine($"Fullname of patient: " + FirstName + " " + LastName);
            Console.WriteLine($"Number of Health Insurance: {NumberOfHealthInsurance}");
            DataTable table = new DataTable("Receipt Table");
            table.Columns.Add("Ordinal number");
            table.Columns.Add("Description");
            table.Columns.Add("Cost");
            table.Rows.Add(1,"Drug", Fees.DrugCosts);
            table.Rows.Add(2,"Treatment", Fees.TreatmentCosts);
            table.Rows.Add(3, "Advance fee", Fees.AdvanceFee);

            foreach (DataColumn c in table.Columns)
            {
                Console.Write($"{c.ColumnName,15}");
            }
            Console.WriteLine();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Console.Write($"{table.Rows[i]["Ordinal number"],15}");             
                Console.Write($"{table.Rows[i]["Description"],15}");      
                Console.Write($"{table.Rows[i]["Cost"],15}");       
                Console.WriteLine();
            }
            float t = CalcBill();
            Console.WriteLine($"Subtotal: {t}");
            Console.WriteLine($"Tax: {t * 8 / 100}");
            Console.WriteLine($"TOTAL: {t + (t * 8 / 100)}");
        }

        public float CalcBill()
        => Fees.DrugCosts + Fees.TreatmentCosts + Fees.AdvanceFee;

    }
}
