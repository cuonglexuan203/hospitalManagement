using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    public class AdmissionDate
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
        public AdmissionDate() { }
        public AdmissionDate(string hospitalAdmissionDate, string hospitalDischargeDate)
        {
            HospitalAdmissionDate = hospitalAdmissionDate;
            HospitalDischargeDate = hospitalDischargeDate;
        }
        // Destructors
        ~AdmissionDate() { }

        // Operators
        // Methods
        // in, output
        public void input()
        {
            Console.Write("hospitalAdmissionDate: ");
            HospitalAdmissionDate = Console.ReadLine();
            Console.Write("hospitalDischargeDate: ");
            HospitalDischargeDate = Console.ReadLine();
        }
        public void input(string hospitalAdmissionDate
 , string hospitalDischargeDate)
        {
            HospitalAdmissionDate = hospitalAdmissionDate;
            HospitalDischargeDate = hospitalDischargeDate;
        }
        public void output()
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
