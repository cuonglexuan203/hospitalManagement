using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class MedicalEquipment : Equipment
    {
        //
        // Field
        private string medicalType;
        private ComeAndLeaveDate expiryDate;

        // Infor field
        // Management field
        // Dynamic field
        // Properties
        public string MedicalType { get => medicalType; set => medicalType = value; }
        public ComeAndLeaveDate ExpiryDate { get => expiryDate; set => expiryDate = value; }
        // Constructors
        public MedicalEquipment()
        {
            expiryDate = new ComeAndLeaveDate();
        }
        public MedicalEquipment(string id
            , string name
            , string description
            , string type
            , float price
            , bool state
            , string origin
            , string medicalType
            , int quantity
            , ComeAndLeaveDate expiryDate) : base(id, name, description, price, state, origin, quantity)
        {
            this.MedicalType = medicalType;
            this.ExpiryDate = expiryDate;
        }


        // Destructors
        ~MedicalEquipment() { }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
            Console.Write("Medical type: ");
            medicalType = Console.ReadLine();

            expiryDate.Input();
        }
        public override void Output()
        {
            Console.WriteLine($"The information of {this.GetType().Name}");
            base.Output();
            Console.WriteLine($"Medical type: {medicalType}");

            expiryDate.Output();
        }
        // General method
        // Other method
        // Overriding


        public override string ToString()
        => base.ToString() + $"\nMedical type: {medicalType}" + expiryDate;

    }
}
