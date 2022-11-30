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
        private List<Medicine> medicines;
        private List<Equipment> equipments;


        // Dynamic field
        // Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Room { get => room; set => room = value; }
        internal List<Medicine> Medicines { get => medicines; set => medicines = value; }
        internal List<Equipment> Equipments { get => equipments; set => equipments = value; }
        // Constructors
        public Repository() { }
        public Repository(string id, string name, string description, string room, List<Medicine> medicines, List<Equipment> equipments)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Room = room;
            this.Medicines = medicines;
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
            Console.WriteLine("Medicines: ");
            Medicines.Input();
            Console.WriteLine("Equipments: ");
            Equipments.Input();

        }
        public void Output()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: ");
            Console.WriteLine($"Room: {Room}");
            Console.WriteLine("The medicine list:");
            foreach (Medicine i in Medicines)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The equipment list: ");
            foreach (Equipment e in Equipments)
            {
                Console.WriteLine(e);

            }
        }



        // General method
        public Medicine FindMedicine(string id)
        {
            foreach (Medicine m in Medicines)
            {
                if (m.id == id)
                {
                    return m;
                }
            }
        }
        public Equipment FindEquipment(string id)
        {
            foreach (Equipment e in Equipments)
            {
                if (e.id == id)
                {
                    return e;
                }
            }
        }
        // Other method
        public void ShowInformation()
        => this.Output();

        public void Add()
        => this.Input();

        public void UpdateInformation()
        => this.Input();

        public void Remove()
        {
            throw new NotImplementedException();
        }

        Repository IBasicActivities<Repository>.Get()
        => this;
        // Overriding
    }
}
