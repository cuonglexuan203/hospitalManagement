using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Doctor : Employee
    {


        private List<Patient> patientList;

        // Dynamic field
        // Properties

        internal List<Patient> PatientList { get => patientList; set => patientList = value; }

        // Constructors
        public Doctor() {
            patientList = new List<Patient>();
        }

        public Doctor(string id
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
        ) : base(id
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
            , salaries
            )
        {

            this.PatientList = patientList;
        }

        // Destructors
        ~Doctor() { }
        // Methods
        // in, Output
        public override void Input()
        {
            base.Input();
            //Console.WriteLine("The patient list: ");
            //Console.WriteLine("Number of patient in charge: ");
            //int i = Convert.ToInt32(Console.ReadLine());

            //for (int j = 0; j < i; j++)
            //{
            //    Patient patient = new Patient();
            //    patientList.Add(patient);
            //}
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("List of patients in charge: ");
            patientList.ForEach(value => { value.Output(); Console.WriteLine(); });
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
