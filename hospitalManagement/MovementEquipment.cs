using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class MovementEquipment : Equipment
    {
        //Field
        private string transportType;
        private int numberOfSeat;
        private string destination;
        private int quantity;

        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public string TransportType { get => transportType; set => transportType = value; }
        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public string Destination { get => destination; set => destination = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        // Constructors
        public MovementEquipment() { }
        public MovementEquipment(string id
            , string name
            , string description
            , string type
            , float price
            , bool state
            , string origin
            , string transportType
            , int numberOfSeat
            , string destination
            , int quantity
            ) : base(id, name, description, type, price, state, origin)
        {
            this.transportType = transportType;
            this.numberOfSeat = numberOfSeat;
            this.destination = destination;
            this.quantity = quantity;
        }
        // Destructors
        ~MovementEquipment() { }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();
            Console.Write("Transport type: ");
            transportType = Console.ReadLine();
            Console.Write("Number of seat:");
            numberOfSeat = Int32.Parse(Console.ReadLine());
            if (State == true)
            {
                Console.Write("Destination: ");
                destination = Console.ReadLine();
            }
            else
            {
                destination = "";
            }
            Console.Write("Quantity: ");
            quantity = Int32.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Transport type: {transportType}");
            Console.WriteLine($"Number of seat: {numberOfSeat}");
            if (State == true)
            {
                Console.WriteLine($"Destination: {destination}");

            }
            Console.WriteLine($"Quantity: {quantity} cars");
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
        => base.ToString() + $"\nTransport type: {transportType}" + $"\nNumber of seat: {numberOfSeat}" + ((State == true) ? $"\nDestination: {destination}" : "" + $"\nQuantity: {quantity} cars");
    }
}
