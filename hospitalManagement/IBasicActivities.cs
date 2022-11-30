﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal interface IBasicActivities : IRegistration
    {
        // 
        void ShowInformation();
        void ExportBill();
        float CalcBill(); // calculate salary if doctor, calculate fee if patient

        void UpdateInformation();



    }
}