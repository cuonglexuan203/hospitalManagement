using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Equipment
    {
        //Field
        private string id;

        // Infor field
        private string name;
        private string description;
        private float price;
        private bool state;
        private string origin;
        private int quantity;

        //  Management field
        // Dynamic field
        // Properties

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public float Price { get => price; set => price = value; }
        public bool State { get => state; set => state = value; }
        public string Origin { get => origin; set => origin = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        // Constructors
        public Equipment() { }
        public Equipment(string id
            , string name
            , string description
            , float price
            , bool state
            , string origin
            , int quantity
            )
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.state = state;
            this.origin = origin;
            this.quantity = quantity;
        }
        // Destructors
        ~Equipment() { }
        // Methods
        // in, output
        public virtual void Input()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
            Console.Write("Price: ");
            Price = float.Parse(Console.ReadLine());
            Console.Write("State(1: free, 0: other): ");
            State = Int32.Parse(Console.ReadLine()) == 1 ? true : false;
            Console.Write("Origin: ");
            Origin = Console.ReadLine();
            Console.Write("Quantity: ");
            Quantity = int.Parse(Console.ReadLine());

        }
        public virtual void Output()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price:C2}");
            Console.WriteLine($"State: {(State ? "Free" : "InWork")}");
            Console.WriteLine($"Origin: {Origin}");
            Console.WriteLine($"Quantity: {Quantity}");
        }


        // General method
        // Other method

        // Overriding
        public override string ToString()
        => $"Id: {Id}"
        + $"\nName: {Name}"
        + $"\nDescription: {Description}"
        + $"\nPrice: {Price}"
        + $"\nState: {State}"
        + $"\nOrigin: {Origin}"
        + $"\nQuantity: {Quantity}";
    }
}