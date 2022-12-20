using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal interface IBill
    {
        void ExportBill();
        float CalcBill(); // calculate salary if doctor, calculate fee if patient
    }
}
