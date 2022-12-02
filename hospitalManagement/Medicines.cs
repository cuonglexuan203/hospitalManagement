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
            Medicine medicine = new Medicine();
            medicine.Input();
            medicineList.Add(medicine);
            this.Count++;
        }
        public void AddItem(Medicine value)
        {
            medicineList.Add(value);
            this.Count++;
        }
        public void ShowInformation()
        {
            medicineList.ForEach(value => { value.Output(); Console.WriteLine(); });
        }

        public Medicine UpdateItem(string id)
        {
            Medicine res = null;
            medicineList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }
            });
            return res;
        }

        public bool RemoveItem(string id)
        {
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
            return res;
        }

        public bool Clear()
        {
            medicineList.Clear();
            if (medicineList.Count > 0)
            {
                return false;
            }
            this.Count = 0;
            return true;
        }



        // Overriding
    }
}
