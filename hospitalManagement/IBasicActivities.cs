using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal interface IBasicActivities
    {
        // 
        void ShowInformation();

        void Add();
        void UpdateInformation();
        void Remove();
        void Get();



    }
}
