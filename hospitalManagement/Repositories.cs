using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Repositories : IBasicActivities<Repository>
    {
        //Field
        private List<Repository> repositoryList;
        private long count;






        // Infor field
        //  Management field
        // Dynamic field
        // Properties


        internal List<Repository> RepositoryList { get => repositoryList; set => repositoryList = value; }
        public long Count { get => count; set => count = value; }

        // Constructors
        public Repositories()
        {
            repositoryList = new List<Repository>();
            this.Count = 0;
        }
        public Repositories(List<Repository> repositoryList, long count)
        {
            this.repositoryList = repositoryList;
            this.count = count;
        }

        // Destructors
        // Methods
        // in, output
        // General method
        // Other method

        public void AddItem()
        {
            Repository repository = new Repository();
            Console.WriteLine("New repository");
            repository.Input();
            repositoryList.Add(repository);
            Console.WriteLine("Done!");

        }

        public void AddItem(Repository value)
        {
            Console.WriteLine("New repository");
            repositoryList.Add(value);
            Console.WriteLine("Done!");
        }
        public void ShowInformation()
        {
            Console.WriteLine("Show information of all repositories");

            repositoryList.ForEach(value =>
            {
                value.Output();
                Console.WriteLine();
            });
            Console.WriteLine("Done!");

        }

        public Repository UpdateItem(string id)
        {
            Console.WriteLine("Update the repository");

            Repository res = null;
            repositoryList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    value.Input();
                    res = value;
                }

            });
            if (res == null)
            {
                Console.WriteLine($"Not found the repository with id: {id}");
            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool RemoveItem(string id)
        {
            Console.WriteLine("Remove the repository");

            bool res = false;
            repositoryList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    repositoryList.Remove(value);
                    res = true;
                }
            });
            if (res == false)
            {
                Console.WriteLine($"Not found repository with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public Repository FindItem(string id)
        {
            Console.WriteLine("Find the repository");

            Repository res = null;
            repositoryList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    res = value;
                }
            });
            if (res == null)
            {
                Console.WriteLine($"Not found repository with id: {id}");

            }
            else
            {
                Console.WriteLine("Done!");

            }
            return res;
        }

        public bool Clear()
        {
            Console.WriteLine("Clear all repositories");

            repositoryList.Clear();
            if (repositoryList.Count > 0)
            {
                Console.WriteLine("Failure!");
                return false;
            }
            this.Count = 0;
            Console.WriteLine("Done!");

            return true;

        }
        // Overriding
    }
}
