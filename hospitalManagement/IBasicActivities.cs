using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal interface IBasicActivities<T>
    {
        // 
        void AddItem();
        void ShowInformation();
        T UpdateItem(string id);
        bool RemoveItem(string id);
        T FindItem(string id);
        bool Clear();




    }
}
﻿
