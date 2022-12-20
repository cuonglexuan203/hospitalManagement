using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    class Nurses:IBasicActivities<Nurse>
    {
        //field
        private List<Nurse> nurseList;
        private long count;


        // Infor field
        //  Management field
        // Dynamic 
        // Properties

        public long Count { get => count; set => count = value; }
        internal List<Nurse> NurseList { get => nurseList; set => nurseList = value; }

        // Constructors

        public Nurses()
        {
            nurseList = new List<Nurse>();
            count = 0;
        }
        public Nurses(List<Nurse> nurseList, long count)
        {
            this.nurseList = nurseList;
            this.count = count;
        }

        

        public void AddItem()
        {
            Console.WriteLine("Add nurse");

            Nurse nurse = new Nurse();
            nurse.Input();
            nurseList.Add(nurse);
            this.Count++;
            Console.WriteLine("Done!");

        }

        public void AddItem(Nurse value)
        {
            Console.WriteLine("Add nurse");

            nurseList.Add(value);
            this.Count++;
            Console.WriteLine("Done!");

        }

        public bool Clear()
        {
            Console.WriteLine("Clear all nurses");

            nurseList.Clear();
            if (nurseList.Count > 0)
            {
                Console.WriteLine("Failure");
                return false;
            }
            this.Count = 0;
            Console.WriteLine("Done!");
            return true;
        }

        public Nurse FindItem(string id)
        {
            Nurse res = null;
            nurseList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found nurse with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the nurse");

            bool res = false;
            nurseList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    nurseList.Remove(value);
                    res = true;
                    this.Count--;
                }
            });
            if (res == false)
            {
                Console.WriteLine($"Not found nurse with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Show information of all nurses");

            nurseList.ForEach(value => { value.Output(); Console.WriteLine(); });
            Console.WriteLine("Done!");
        }

        public Nurse UpdateItem(string id)
        {
            Console.WriteLine("Update the nurse");

            Nurse res = null;
            nurseList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found the nurse with id:{id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }
    }
}
