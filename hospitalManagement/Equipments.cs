using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Equipments : IBasicActivities<Equipment>
    {
        //Field
        private List<Equipment> equipmentList;
        private long count;

        // Infor field
        //  Management field
        // Dynamic field
        // Properties
        public long Count { get => count; set => count = value; }
        internal List<Equipment> EquipmentList { get => equipmentList; set => equipmentList = value; }

        // Constructors
        public Equipments()
        {
            equipmentList = new List<Equipment>();
            count = 0;
        }
        public Equipments(List<Equipment> equipmentList, long count)
        {
            this.equipmentList = equipmentList;
            this.count = count;
        }
        // Destructors
        ~Equipments() { }
        // Methods
        // in, output
        // General method
        // Other method
        public void AddItem()
        {
            Console.WriteLine("Type of equipment(choose one): 1.Medical 2.Movement\n");
            string choice = Console.ReadLine();
            Equipment equipment = null;
            if (choice.ToLower() == "medical" || Int32.Parse(choice) == 1)
            {
                equipment = new MedicalEquipment();

            }
            else
            {
                equipment = new MovementEquipment();
            }
            equipment.Input();
            equipmentList.Add(equipment);
            this.Count++;
        }
        public void AddItem(MedicalEquipment value)
        {

            equipmentList.Add(value);
            this.Count++;
        }
        public void AddItem(MovementEquipment value)
        {

            equipmentList.Add(value);
            this.Count++;
        }
        public bool Clear()
        {
            equipmentList.Clear();
            if (equipmentList.Count > 0)
            {
                return false;
            }
            this.Count = 0;
            return true;
        }

        public Equipment FindItem(string id)
        {
            Equipment res = null;
            equipmentList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    res = value;
                }
            });
            return res;
        }

        public bool RemoveItem(string id)
        {
            bool res = false;
            equipmentList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    equipmentList.Remove(value);
                    res = true;
                    this.Count--;
                }
            });
            return res;
        }

        public void ShowInformation()
        {
            equipmentList.ForEach(value =>
            {
                value.Output();
                Console.WriteLine();
            });
        }

        public Equipment UpdateItem(string id)
        {
            Equipment res = null;
            equipmentList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }
            });
            return res;
        }

        // Overriding
        public static Equipments operator +(Equipments a, Equipments b)
        {
            Equipments res = new Equipments();
            res.EquipmentList.AddRange(a.EquipmentList);
            res.EquipmentList.AddRange(b.EquipmentList);
            res.Count = a.Count + b.Count;
            return res;
        }
        public static Equipments operator -(Equipments a, Equipments b)
        {
            Equipments res = new Equipments();
            res.EquipmentList.AddRange(a.EquipmentList);
            res.Count = a.Count;
            foreach (Equipment e in b.EquipmentList)
            {
                res.EquipmentList.RemoveAll(x => x.Id == e.Id);
            }
            res.Count = res.EquipmentList.Count;
            return res;
        }
        public static Equipments operator -(Equipments a, Equipment b)
        {
            Equipments res = new Equipments();
            res.EquipmentList = a.EquipmentList;
            res.EquipmentList.RemoveAll(x => x.Id == b.Id);
            res.Count = res.EquipmentList.Count;
            return res;
        }
    }
}
