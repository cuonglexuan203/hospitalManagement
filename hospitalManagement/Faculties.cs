using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Faculties : IBasicActivities<Faculty>
    {
        //Field	
        private List<Faculty> facultyList;
        private long count;



        // Infor field	
        //  Management field	
        // Dynamic field	
        // Properties	
        public long Count { get => count; set => count = value; }
        internal List<Faculty> FacultyList { get => facultyList; set => facultyList = value; }
        // Constructors	

        public Faculties()
        {
            facultyList = new List<Faculty>();
            this.Count = 0;
        }
        public Faculties(List<Faculty> facultyList, long count)
        {
            this.FacultyList = facultyList;
            this.Count = count;
        }

        // Destructors	
        ~Faculties() { }
        // Methods	
        // in, output	
        // General method	
        // Other method	
        public void AddItem()
        {
            Faculty faculty = new Faculty();
            Console.WriteLine("New faculty");
            faculty.Input();
            facultyList.Add(faculty);
            Console.WriteLine("Done!");
        }

        public void AddItem(Faculty value)
        {
            Console.WriteLine("New faculty");
            facultyList.Add(value);
            Console.WriteLine("Done!");
        }

        public bool Clear()
        {
            Console.WriteLine("Clear all faculties");

            facultyList.Clear();
            if (facultyList.Count > 0)
            {
                Console.WriteLine("Failure!");
                return false;
            }
            this.Count = 0;
            Console.WriteLine("Done!");

            return true;
        }

        public Faculty FindItem(string id)
        {
            Console.WriteLine("Find the faculty");

            Faculty res = null;
            facultyList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found faculty with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");
            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the faculty");

            bool res = false;
            facultyList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    facultyList.Remove(value);
                    res = true;
                }
            });
            if (res == false)
            {
                Console.WriteLine($"Not found faculty with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public void ShowInformation()
        {
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Show information of all faculties");

            facultyList.ForEach(value =>
            {
                value.Output();
                Console.WriteLine();
            });
            Console.WriteLine("Done!");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public Faculty UpdateItem(string id)
        {
            Console.WriteLine("Update the faculty");

            Faculty res = null;
            facultyList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }

            });
            if (res == null)
            {
                Console.WriteLine($"Not found the faculty with id: {id}");
            }
            else
            {
                Console.WriteLine("Done!");
            }
            return res;
        }
        // Overriding	

    }
}
