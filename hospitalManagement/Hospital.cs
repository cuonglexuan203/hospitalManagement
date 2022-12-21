using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Hospital : IHospitalActivities
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
            Console.Write("Do you want to show the faculty information?(1.yes, 0.no): ");
            int choice = Int32.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Faculties.ShowInformation();
            }
            Console.Write("Do you want to show the repository information?(1.yes, 0.no): ");
            choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Repo.ShowInformation();
            }



        }
        // General method

        // Other method
        public void AddFaculty()
        {
            this.Faculties.AddItem();
        }
        public void AddRepository()
        {
            this.Repo.AddItem();
        }
        public void RemoveFaculty(string id)
        {
            this.Faculties.RemoveItem(id);
        }
        public void RemoveRepository(string id)
        {
            this.Repo.RemoveItem(id);
        }
        public void ShowFaculty(string id)
        {
            this.Faculties.FindItem(id).Output();
        }
        public void ShowRepository(string id)
        {
            this.Repo.FindItem(id).Output();
        }
        public void ShowAllFaculty()
        {
            this.Faculties.ShowInformation();
        }
        public void ShowAllRepository()
        {
            this.Repo.ShowInformation();
        }

        public void UpdateFaculty(string id)
        {
            this.Faculties.UpdateItem(id);
        }

        public void UpdateRepository(string id)
        {
            this.Repo.UpdateItem(id);
        }
        // Overriding

    }
}
