using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Patients:IBasicActivities<Patient>
    {
        //Field	
        private List<Patient> patientList;
        private long count;

        // Infor field	
        //  Management field	
        // Dynamic field	
        // Properties	

        public long Count { get => count; set => count = value; }
        internal List<Patient> PatientList { get => patientList; set => patientList = value; }


        // Constructors	
        public Patients()
        {
            patientList = new List<Patient>();
            count = 0;
        }

        public Patients(List<Patient> patientList, long count)
        {
            this.patientList = patientList;
            this.count = count;
        }


        // Destructors	
        ~Patients() { }

        // Methods	
        // in, output
        // General method	
        // Other method


        public void AddItem()
        {
            Console.WriteLine("Add patient");

            Patient patient = new Patient();
            patient.Input();
            patientList.Add(patient);
            this.Count++;
            Console.WriteLine("Done!");

        }

        public void ShowInformation()
        {
            Console.WriteLine("Show information of all patients");

            patientList.ForEach(value => { value.Output(); Console.WriteLine(); });
            Console.WriteLine("Done!");
        }

        public Patient UpdateItem(string id)
        {
            Console.WriteLine("Update the patient");

            Patient res = null;
            patientList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found the patient with id:{id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the patient");

            bool res = false;
            patientList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    patientList.Remove(value);
                    res = true;
                    this.Count--;
                }
            });
            if (res == false)
            {
                Console.WriteLine($"Not found patient with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public Patient FindItem(string id)
        {
            Patient res = null;
            patientList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found patient with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool Clear()
        {
            Console.WriteLine("Clear all patients");

            patientList.Clear();
            if (patientList.Count > 0)
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
