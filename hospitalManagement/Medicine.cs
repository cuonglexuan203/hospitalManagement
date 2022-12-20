using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Medicine
    {
        //Field
        private string id;
        // Infor field
        private string name;
        private string description;
        private string type;
        private string dosage;
        private string storage;
        private float weight;
        private string serialNumber;
        private ComeAndLeaveDate expiryDate;


        //  Management field
        // Dynamic field
        // Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public string Storage { get => storage; set => storage = value; }
        public float Weight { get => weight; set => weight = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public ComeAndLeaveDate ExpiryDate { get => expiryDate; set => expiryDate = value; }

        // Constructors
        public Medicine()
        {
            expiryDate = new ComeAndLeaveDate();
        }
        public Medicine(string id
            , string name
            , string description
            , string type
            , string dosage
            , string storage
            , float weight
            , string serialNumber
            , ComeAndLeaveDate expiryDate)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.type = type;
            this.dosage = dosage;
            this.storage = storage;
            this.weight = weight;
            this.serialNumber = serialNumber;
            this.expiryDate = expiryDate;
        }
        // Destructors
        ~Medicine() { }
        // Methods
        // in, output
        public void Input()
        {
            Console.Write("Id: ");
            id = Console.ReadLine();
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Description: ");
            description = Console.ReadLine();
            Console.Write("Type: ");
            type = Console.ReadLine();
            Console.Write("Dosage: ");
            dosage = Console.ReadLine();
            Console.Write("Storage: ");
            storage = Console.ReadLine();
            Console.Write("Weight: ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("The serial number: ");
            serialNumber = Console.ReadLine();
            Console.WriteLine("The expiry date");
            expiryDate.Input();
        }
        public void Output()
        {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Dosage: {dosage}");
            Console.WriteLine($"Storage: {storage}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"SerialNumber: {serialNumber}");
            Console.WriteLine(expiryDate);
        }



        // General method

        // Other method


        // Overriding
        public override string ToString()
        => $"Id: {id}"
        + $"\nName: {name}"
        + $"\nDescription: {description}"
        + $"\nType: {type}"
        + $"\nDosage: {dosage}"
        + $"\nStorage: {storage}"
        + $"\nWeight: {weight}"
        + $"\nSerialNumber: {serialNumber}"
        + $"\n{expiryDate}";
    }
}
