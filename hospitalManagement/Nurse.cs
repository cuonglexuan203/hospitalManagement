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
        // Infor field
        //  Management field
        // Dynamic field
        // Properties
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
        , List<string> patientIdList
        , ComeAndLeaveDate admissionDates
        , Salary salaries
        , List<Patient> patientList) : base(id,
                                            firstName,
                                            lastName,
                                            age,
                                            gentle,
                                            description,
                                            address,
                                            email,
                                            phone,
                                            facultyId,
                                            departmentId,
                                            state,
                                            admissionDates,
                                            salaries,
                                            patientList)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gentle = gentle;
            this.Description = description;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.FacultyId = facultyId;
            this.DepartmentId = departmentId;
            this.State = state;
            this.AdmissionDates = admissionDates;
            this.Salaries = salaries;
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
