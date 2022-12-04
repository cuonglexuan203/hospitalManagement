using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Repositories repositories = new Repositories();
            //repositories.AddItem();
            //repositories.ShowInformation();


            //Faculties faculties = new Faculties();
            //faculties.AddItem();
            //faculties.ShowInformation();

            Patient pa = new Patient();
            pa.Input();

            pa.ExportBill();
        }
    }
}
