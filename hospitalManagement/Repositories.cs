using System;
using System.Collections.Generic;
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
            Console.WriteLine("New repository:");
            repository.Input();
            repositoryList.Add(repository);
        }

        public void ShowInformation()
        {
            repositoryList.ForEach(value =>
            {
                value.Output();
                Console.WriteLine();
            });
        }

        public Repository UpdateItem(string id)
        {
            Repository res = null;
            repositoryList.ForEach(value =>
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
            repositoryList.ForEach(value =>
            {
                if (value.Id == id)
                {
                    repositoryList.Remove(value);
                    res = true;
                }
            });
            return res;
        }

        public Repository FindItem(string id)
        {
            Repository res = null;
            repositoryList.ForEach(value =>
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
            repositoryList.Clear();
            if (repositoryList.Count > 0)
            {
                return false;
            }
            this.Count = 0;
            return true;

        }
        // Overriding
    }
}
