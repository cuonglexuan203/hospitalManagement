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
        private int quantity;
        private ComeAndLeaveDate expiryDate;

        // Infor field
        // Management field
        // Dynamic field
        // Properties
        public string MedicalType { get => medicalType; set => medicalType = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public ComeAndLeaveDate ExpiryDate { get => expiryDate; set => expiryDate = value; }
        // Constructors
        public MedicalEquipment() { }
        public MedicalEquipment(string id
            , string name
            , string description
            , string type
            , float price
            , bool state
            , string origin
            , string medicalType
            , int quantity
            , ComeAndLeaveDate expiryDate) : base(id, name, description, type, price, state, origin)
        {
            this.MedicalType = medicalType;
            this.Quantity = quantity;
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
            Console.Write("Quantity: ");
            quantity = Int32.Parse(Console.ReadLine());
            expiryDate.Input();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Medical type: {medicalType}");
            Console.WriteLine($"Quantity: {quantity} boxs");
            expiryDate.Output();
        }
        // General method
        // Other method
        // Overriding
        public override void ShowInformation()
        {
            this.Output();
        }
        public override void Add()
        {

        }
        public override void UpdateInformation()
        {
            this.Input();
        }
        public override bool Remove(string id)
        {
            return true;
        }
        public override string ToString()
        => base.ToString() + $"\nMedical type: {medicalType}" + $"\nQuantity: {quantity} boxs" + expiryDate;

    }
}
