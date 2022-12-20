using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Nurse : Employee
    {
        //Field
        private List<Patient> patientList;


        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        internal List<Patient> PatientList { get => patientList; set => patientList = value; }

        // Constructors
        public Nurse()
        {

        }
        public Nurse(string id
        , string firstName
        , string lastName
        , int age
        , int gentle
        , string description
        , string address
        , string email
        , string phone
        , string facultyId
        , string departmentId
        , bool state
        , ComeAndLeaveDate admissionDates
        , Salary salaries
        , List<Patient> patientList) : base(id
            , firstName
            , lastName
            , age
            , gentle
            , description
            , address
            , email
            , phone
            , facultyId
            , departmentId
            , state
            , admissionDates
            , salaries)
        {

            this.PatientList = patientList;
        }

        // Destructors
        ~Nurse() { }
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
        public override void ExportBill()
        {
            base.ExportBill();
        }

        public override float CalcBill()
        {
            return base.CalcBill();
        }
    }
}
