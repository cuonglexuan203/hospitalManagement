<<<<<<< HEAD
﻿using System;
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
=======
﻿
>>>>>>> 7066e33ae2820a3e2137f509070683434afe6b71
