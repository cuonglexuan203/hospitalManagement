using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Repository : IRepositoryActivities
    {

        //Field
        private string id;

        // Infor field
        private string name;
        private string description;
        private string room;
        //  Management fields
        private Medicines medicineList;
        private Equipments equipmentList;

        // Dynamic field
        // Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Room { get => room; set => room = value; }
        internal Medicines MedicinesList { get => medicineList; set => medicineList = value; }
        internal Equipments EquipmentsList { get => equipmentList; set => equipmentList = value; }

        // Constructors
        public Repository()
        {
            medicineList = new Medicines();
            equipmentList = new Equipments();
        }

        public Repository(string id, string name, string description, string room, Medicines medicinesList, Equipments equipmentsList)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.room = room;
            this.medicineList = medicinesList;
            this.equipmentList = equipmentsList;
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
            Console.Write("Room number: ");
            Room = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("The repository");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: ");
            Console.WriteLine($"Room: {Room}");
            Console.WriteLine($"The equipment list: {medicineList.Count + equipmentList.Count}");
            Console.WriteLine($"The medicine list: {medicineList.Count}");
            medicineList.ShowInformation();
            Console.WriteLine($"The equipment list: {equipmentList.Count}");
            EquipmentsList.ShowInformation();
        }



        // General method
        // Overriding
        public override string ToString()
        => $"Id: {Id}" +
            $"\nName: {Name}" +
            $"\nDescription: {Description}" +
            $"\nRoom: {Room}" +
            $"\nMedicines count: {MedicinesList.Count} " +
            $"\nEquipment count: {EquipmentsList.Count}";

        public void AddMedicine()
        {

            this.MedicinesList.AddItem();
        }

        public void RemoveMedicine(string id)
        {
            this.MedicinesList.RemoveItem(id);
        }

        public Medicine FindMedicine(string id)
        {
            return this.MedicinesList.FindItem(id);
        }

        public Medicine UpdateMedicine(string id)
        {
            return this.MedicinesList.UpdateItem(id);
        }

        public void AddEquipment()
        {
            this.EquipmentsList.AddItem();
        }

        public void RemoveEquipment(string id)
        {
            this.EquipmentsList.RemoveItem(id);
        }

        public Equipment FindEquipment(string id)
        {
            return this.EquipmentsList.FindItem(id);
        }

        public Equipment UpdateEquipment(string id)
        {
            return this.EquipmentsList.UpdateItem(id);
        }

        public void ClearMedicine()
        {
            this.MedicinesList.Clear();
        }

        public void ClearEquipment()
        {
            this.EquipmentsList.Clear();
        }
    }
}
