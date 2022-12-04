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
        private string type;
        private float price;
        private bool state;
        private string origin;


        //  Management field
        // Dynamic field
        // Properties

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        public float Price { get => price; set => price = value; }
        public bool State { get => state; set => state = value; }
        public string Origin { get => origin; set => origin = value; }

        // Constructors
        public Equipment() { }
        public Equipment(string id
            , string name
            , string description
            , string type
            , float price
            , bool state
            , string origin)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.type = type;
            this.price = price;
            this.state = state;
            this.origin = origin;
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
            Console.Write("Type: ");
            Type = Console.ReadLine();
            Console.Write("Price: ");
            Price = float.Parse(Console.ReadLine());
            Console.Write("State(1: free, 0: other): ");
            State = Int32.Parse(Console.ReadLine()) == 1 ? true : false;
            Console.Write("Origin: ");
            Origin = Console.ReadLine();

        }
        public virtual void Output()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"State: {State}");
            Console.WriteLine($"Origin: {Origin}");
        }


        // General method
        // Other method

        // Overriding
        public override string ToString()
        => $"Id: {Id}"
        + $"\nName: {Name}"
        + $"\nDescription: {Description}"
        + $"\nType: {Type}"
        + $"\nPrice: {Price}"
        + $"\nState: {State}"
        + $"\nOrigin: {Origin}";
    }
}
