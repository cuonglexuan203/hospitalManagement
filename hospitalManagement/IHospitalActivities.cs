using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal interface IHospitalActivities
    {
        void AddFaculty();
        void AddRepository();
        void RemoveFaculty(string id);
        void RemoveRepository(string id);
        void ShowFaculty(string id);
        void ShowRepository(string id);
        void ShowAllFaculty();
        void ShowAllRepository();

        void UpdateFaculty(string id);
        void UpdateRepository(string id);
        void ClearFaculty();
        void ClearRepository();
    }
}
