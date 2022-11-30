using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
<<<<<<< HEAD
    internal interface IBasicActivities 
    {
        // 
        void ShowInformation();
       
=======
    internal interface IBasicActivities<T>
    {
        // 
        void ShowInformation();

        void Add();
>>>>>>> a0c544d50fa6956626ea0b7f1a62dbe833cfba82
        void UpdateInformation();
        void Remove();
        T Get();



    }
}
