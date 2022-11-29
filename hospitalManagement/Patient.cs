using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement
{
    internal class Patient
    {
        //Field	
        private string id;

        // Infor field	
        private string firstname;
        private string lastname;
        private string dateofbirth;
        private string ethnic;
        private string religion;
        private string nationality;
        private string numberofhealthinsurance;
        private string career;
        private string address;
        private string phonenumber;
        private int gentle;
        private string relative;
        private string phonenumberofrelative;

        // Management field
        private string dateofhosspitaladmission;
        private string dateoghospitaldischarge;
        private long medicalexaminationfee;
        private long drugcosts;
        private long treatmnetcosts;
        private long advancefee;
        //private long 
        // Dynamic field	

        // Properties	

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        public string Dateofbirth
        {
            get { return this.dateofbirth; }
            set { this.dateofbirth = value; }
        }

        public string Ethnic
        {
            get { return this.ethnic; }
            set { this.ethnic = value; }
        }
        public string Religion
        {
            get { return this.religion; }
            set { this.religion = value; }
        }
        public string Nationality
        {
            get { return this.nationality; }
            set { this.nationality = value; }
        }
        public string Numberofhealthinsurance
        {
            get { return this.numberofhealthinsurance; }
            set { this.id = value; }
        }
        public string Career
        {
            get { return this.career; }
            set { this.career = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Phonenumber
        {
            get { return this.phonenumber; }
            set { this.phonenumber = value; }
        }
        public int Gentle
        {
            get { return this.gentle; }
            set { this.gentle = value; }
        }
        public string Relative
        {
            get { return this.relative; }
            set { this.relative = value; }
        }
        public string Phonenumberofrelative
        {
            get { return this.phonenumberofrelative; }
            set { this.phonenumberofrelative = value; }
        }


        // Constructors	
        public Patient()
        {

        }


        // Destructors	
        ~Patient() { }

        // Methods	

        // in, output

        void Input1(string firstName, string lastName, string dateOfBirth, string ethenic, string religion, string nationality, string numOfHealthInsurance, string career, string address, string phoneNum, int gender)
        {
            this.Firstname = firstName;
            this.Lastname = lastname;
            this.Dateofbirth = dateOfBirth;
            this.Ethnic = ethenic;
            this.Religion = religion;
            this.Nationality = nationality;
            this.Numberofhealthinsurance = numOfHealthInsurance;
            this.Career = career;
            this.Address = address;
            this.Phonenumber = phoneNum;
            this.Gentle = gender;
        }

        // General method

        // Other method	

        // Overriding	

    }
}
