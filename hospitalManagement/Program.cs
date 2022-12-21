using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital ad = new Hospital();
            ad.Input();
            ad.AddRepository();
            ad.Repo.RepositoryList[0]?.AddEquipment();
            ad.Output();
            //ad.ShowAllRepository();
        }
    }
}
