using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Medicines : IBasicActivities<Medicine>
    {
        //Field
        private List<Medicine> medicineList;
        private long count;

        // Infor field
        //  Management field
        // Dynamic 
        // Properties
        public long Count { get => count; set => count = value; }
        public List<Medicine> MedicineList { get => medicineList; set => medicineList = value; }
        // Constructors
        public Medicines()
        {
            medicineList = new List<Medicine>();
            count = 0;
        }
        public Medicines(List<Medicine> medicineList, long count)
        {
            this.MedicineList = medicineList;
            this.Count = count;
        }


        // Destructors
        // Methods
        // in, output
        // General method
        // Other method
        public void AddItem()
        {
            Console.WriteLine("Add medicine");

            Medicine medicine = new Medicine();
            medicine.Input();
            medicineList.Add(medicine);
            this.Count++;
            Console.WriteLine("Done!");

        }
        public void AddItem(Medicine value)
        {
            Console.WriteLine("Add medicine");

            medicineList.Add(value);
            this.Count++;
            Console.WriteLine("Done!");

        }
        public void ShowInformation()
        {
            Console.WriteLine("Show information of all medicines");

            medicineList.ForEach(value => { value.Output(); Console.WriteLine(); });
            Console.WriteLine("Done!");

        }

        public Medicine UpdateItem(string id)
        {
            Console.WriteLine("Update the medicine");

            Medicine res = null;
            medicineList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found the medicine with id:{id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the medicine");

            bool res = false;
            medicineList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    medicineList.Remove(value);
                    res = true;
                    this.Count--;
                }
            });
            if (res == false)
            {
                Console.WriteLine($"Not found medicine with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public Medicine FindItem(string id)
        {
            Medicine res = null;
            medicineList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found medicine with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool Clear()
        {
            Console.WriteLine("Clear all medicines");

            medicineList.Clear();
            if (medicineList.Count > 0)
            {
                Console.WriteLine("Failure");
                return false;
            }
            this.Count = 0;
            Console.WriteLine("Done!");
            return true;
        }



        // Overriding
    }
}
