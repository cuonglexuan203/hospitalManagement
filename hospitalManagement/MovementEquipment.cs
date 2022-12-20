using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal abstract class MovementEquipment : Equipment
    {
        //Field
        private int numberOfSeat;
        private string destination;

        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public string Destination { get => destination; set => destination = value; }

        // Constructors
        public MovementEquipment() { }
        public MovementEquipment(
            string id
            , string name
            , string description
            , float price
            , bool state
            , string origin
            , int quantity
            , int numberOfSeat
            , string destination
            ) : base(id, name, description, price, state, origin, quantity)
        {
            this.numberOfSeat = numberOfSeat;
            this.destination = destination;

        }
        // Destructors
        ~MovementEquipment() { }
        // Methods
        // in, output
        public override void Input()
        {
            base.Input();

            Console.Write("Number of seat:");
            numberOfSeat = Int32.Parse(Console.ReadLine());
            if (State == false)
            {
                Console.Write("Destination: ");
                destination = Console.ReadLine();
            }
            else
            {
                destination = "";
            }

        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Number of seat: {numberOfSeat}");
            if (State == true)
            {
                Console.WriteLine($"Destination: {destination}");

            }
        }
        // General method
        // Other method
        // Overriding


        public override string ToString()
        => base.ToString()
            + $"\nNumber of seat: {numberOfSeat}"
            + ((State == true) ? $"\nDestination: {destination}" : "");
    }
}
