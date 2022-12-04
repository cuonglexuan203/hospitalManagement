using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Doctors: IBasicActivities<Doctor>
    {
        //field
        private List<Doctor> doctorList;
        private long count;


        // Infor field
        //  Management field
        // Dynamic 
        // Properties
        public long Count { get => count; set => count = value; }
        internal List<Doctor> DoctorList { get => doctorList; set => doctorList = value; }


        // Constructors

        public Doctors()
        {
            doctorList = new List<Doctor>();
            count = 0;
        }
        public Doctors(List<Doctor> doctorList, long count)
        {
            this.doctorList = doctorList;
            this.count = count;
        }

        public void AddItem()
        {
            Console.WriteLine("Add doctor");

            Doctor doctor = new Doctor();
            doctor.Input();
            doctorList.Add(doctor);
            this.Count++;
            Console.WriteLine("Done!");

        }

        public void AddItem(Doctor value)
        {
            Console.WriteLine("Add doctor");

            doctorList.Add(value);
            this.Count++;
            Console.WriteLine("Done!");

        }

        public bool Clear()
        {
            Console.WriteLine("Clear all doctors");

            doctorList.Clear();
            if (doctorList.Count > 0)
            {
                Console.WriteLine("Failure");
                return false;
            }
            this.Count = 0;
            Console.WriteLine("Done!");
            return true;
        }

        public Doctor FindItem(string id)
        {
            Doctor res = null;
            doctorList.ForEach(value =>
            {
                if (value.DoctorId == id)
                {
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found doctor with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the Doctor");

            bool res = false;
            doctorList.ForEach(value =>
            {
                if (value.DoctorId == id)
                {
                    doctorList.Remove(value);
                    res = true;
                    this.Count--;
                }
            });
            if (res == false)
            {
                Console.WriteLine($"Not found doctor with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Show information of all doctors");

            doctorList.ForEach(value => { value.Output(); Console.WriteLine(); });
            Console.WriteLine("Done!");
        }

        public Doctor UpdateItem(string id)
        {
            Console.WriteLine("Update the doctor");

            Doctor res = null;
            doctorList.ForEach(value =>
            {
                if (value.DoctorId == id)
                {
                    value.Input();
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found the doctor with id:{id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }
    }
}
