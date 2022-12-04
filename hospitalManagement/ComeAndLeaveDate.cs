using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    public class ComeAndLeaveDate
    {
        //Field
        private string hospitalAdmissionDate;
        private string hospitalDischargeDate;



        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public string HospitalAdmissionDate { get => hospitalAdmissionDate; set => hospitalAdmissionDate = value; }
        public string HospitalDischargeDate { get => hospitalDischargeDate; set => hospitalDischargeDate = value; }

        // Constructors
        public ComeAndLeaveDate() 
        {
            
        }
        public ComeAndLeaveDate(string hospitalAdmissionDate, string hospitalDischargeDate)
        {
            HospitalAdmissionDate = hospitalAdmissionDate;
            HospitalDischargeDate = hospitalDischargeDate;
        }
        // Destructors
        ~ComeAndLeaveDate() { }

        // Operators
        // Methods
        // in, Output
        public void Input()
        {
            Console.Write("hospitalAdmissionDate: ");
            HospitalAdmissionDate = Console.ReadLine();
            Console.Write("hospitalDischargeDate: ");
            HospitalDischargeDate = Console.ReadLine();
        }
        public void Input(string hospitalAdmissionDate
 , string hospitalDischargeDate)
        {
            HospitalAdmissionDate = hospitalAdmissionDate;
            HospitalDischargeDate = hospitalDischargeDate;
        }
        public void Output()
        {
            Console.WriteLine($"HospitalAdmissionDate: {HospitalAdmissionDate}");
            Console.WriteLine($"HospitalDischargeDate: {HospitalDischargeDate}");
        }
        // General method
        // Other method
        // Overriding
        public override string ToString()
            => $"\nHospital admission date: {HospitalAdmissionDate}" + $"\nHospital discharge date: {HospitalDischargeDate}";
    }
}
