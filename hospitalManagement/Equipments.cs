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
            Console.WriteLine("New the equipment");
            Console.WriteLine("Type of equipment(choose one): 1.Medical 2.Movement\n");
            string choice = Console.ReadLine();
            Equipment equipment = null;
            if (choice.ToLower() == "medical" || Int32.Parse(choice) == 1)
            {
                equipment = new MedicalEquipment();
            }
            else
            {
                Console.WriteLine("Choose type of the movement transportation:");
                int index = 0;
                int choiceTransportation = 0;
                string[] em = { nameof(Ambulance) };
                string[] nonEm = { nameof(WheelChair), nameof(AmbulatoryTransportation), nameof(FlightEscort), nameof(Stretcher) };

                {
                    Console.WriteLine($"{index}. {em[index++]}");
                }
                while (index - em.Length < nonEm.Length)
                {
                    Console.WriteLine($"{index}. {nonEm[index++ - em.Length]}");
                }
                choiceTransportation = Int32.Parse(Console.ReadLine());
                switch (choiceTransportation)
                {
                    case 0:
                        equipment = new Ambulance();
                        break;
                    case 1:
                        equipment = new WheelChair();
                        break;
                    case 2:
                        equipment = new AmbulatoryTransportation();
                        break;
                    case 3:
                        equipment = new FlightEscort();
                        break;
                    case 4:
                        equipment = new Stretcher();
                        break;
                };
            }
            equipment.Input();
            equipmentList.Add(equipment);
            this.Count++;
            Console.WriteLine("Done!");
        }

        public bool Clear()
        {
            Console.WriteLine("Clear all equipments");

            equipmentList.Clear();
            if (equipmentList.Count > 0)
            {
                Console.WriteLine("Failure!");

                return false;
            }
            this.Count = 0;
            Console.WriteLine("Done!");

            return true;
        }

        public Equipment FindItem(string id)
        {
            Console.WriteLine("Find the equipment");

            Equipment res = null;
            equipmentList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found equipment with id:{id}");

            }
            else
            {
                Console.WriteLine("Had found!");

            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the equipment");

            bool res = false;
            Equipment temp = null;
            foreach (var value in equipmentList)
            {
                if (value.Id == id)
                {
                    temp = value;
                    res = true;
                    this.Count--;
                }
            }
            equipmentList.Remove(temp);
            if (res == false)
            {
                Console.WriteLine($"Not found equipment with id:{id}");
            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public void ShowInformation()
        {

            Console.WriteLine($"\tShow information of all equipments");

            equipmentList.ForEach(value =>
            {
                value.Output();
                Console.WriteLine();
            });
            Console.WriteLine("Done!");
        }

        public Equipment UpdateItem(string id)
        {
            Console.WriteLine("Update the equipment");
            Equipment res = null;
            equipmentList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found equipment with id:{id}");
            }
            else
            {
                Console.WriteLine("Done!");
            }
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
