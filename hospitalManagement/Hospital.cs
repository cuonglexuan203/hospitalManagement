using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Hospital
    {
        //Field
        private List<Faculty> faculties;
        private Repository repo;

        // Infor field
        private string name;
        private string description;
        private string address;


        //  Management field
        // Dynamic field
        // Properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Address { get => address; set => address = value; }
        public List<Faculty> Faculties { get => faculties; set => faculties = value; }
        public Repository Repo { get => repo; set => repo = value; }
        // Constructors
        public Hospital() { 
            faculties = new List<Faculty>();
        }
        public Hospital(List<Faculty> faculties, Repository repo)
        {
            this.Faculties = faculties;
            this.Repo = repo;
        }
        // Destructors
        ~Hospital() { }
        // Methods
        // in, output
        public void Input()
        {
            Console.WriteLine("Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Description: ");
            this.Description = Console.ReadLine();
            Console.WriteLine("Address: ");
            this.Address = Console.ReadLine();
            Console.WriteLine("Number of faculties: ");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < i; j++)
            {
                Faculty faculty = new Faculty();
                faculty.Input();
                Faculties.Add(faculty);
            }
            Repo.Input();
        }
        public void Output()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"List of faculties: ");
            faculties.ForEach(value => { value.Output(); Console.WriteLine(); });

        }
        // General method

        // Other method

        // Overriding

    }
}
