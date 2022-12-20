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
        private Faculties faculties;
        private Repositories repo;

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
        public Faculties Faculties { get => faculties; set => faculties = value; }
        public Repositories Repo { get => repo; set => repo = value; }
        // Constructors
        public Hospital()
        {
            faculties = new Faculties();
            repo = new Repositories();
        }
        public Hospital(Faculties faculties, Repositories repo)
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
            Console.WriteLine("Some basic information of hospital:");
            Console.Write("Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Description: ");
            this.Description = Console.ReadLine();
            Console.Write("Address: ");
            this.Address = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("The information of hospital: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Number of faculty: {faculties.Count}");
            Console.WriteLine($"Number of repository: {repo.Count}");

        }
        // General method

        // Other method

        // Overriding

    }
}
