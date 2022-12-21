using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal interface IRepositoryActivities
    {
        //
        void AddMedicine();
        void RemoveMedicine(string id);
        Medicine FindMedicine(string id);
        Medicine UpdateMedicine(string id);
        //
        void AddEquipment();
        void RemoveEquipment(string id);
        Equipment FindEquipment(string id);
        Equipment UpdateEquipment(string id);
    }
}
