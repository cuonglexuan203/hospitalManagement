using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Repository : IBasicActivities<Repository>
    {

        //Field
        private string id;

        // Infor field
        private string name;
        private string description;
        private string room;
        //  Management fields
        private List<Equipment> equipments;

        // Dynamic field
        // Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Room { get => room; set => room = value; }
        internal List<Equipment> Equipments { get => equipments; set => equipments = value; }
        // Constructors
        public Repository()
        {
            equipments = new List<Equipment>();
        }
        public Repository(string id, string name, string description, string room, List<Equipment> equipments)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Room = room;
            this.Equipments = equipments;
        }


        // Destructors
        ~Repository() { }
        // Methods
        // in, output
        public void Input()
        {

            Console.Write("Id: ");
            Id = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
            Console.Write("Room: ");
            Room = Console.ReadLine();
            Console.WriteLine("Number of equipment: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Equiment #{i}");
                Equipment temp = new Equipment();
                temp.Input();
                equipments.Add(temp);
            }

        }
        public void Output()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: ");
            Console.WriteLine($"Room: {Room}");
            Console.WriteLine("The equipment list: ");
            foreach (Equipment e in Equipments)
            {
                Console.WriteLine(e);

            }
        }



        // General method

        public Equipment FindEquipment(string id)
        {
            foreach (Equipment e in Equipments)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }
        // Other method
        public void ShowInformation()
        => this.Output();

        public void Add()
        => this.Input();

        public void UpdateInformation()
        => this.Input();


        public bool Remove(string id)
        {
            foreach (Equipment e in Equipments)
            {
                if (e.Id == id)
                {
                    equipments.Remove(e);
                    return true;
                }
            }
            return false;
        }

        Repository IBasicActivities<Repository>.Get()
        => this;

        // Overriding
    }
}
