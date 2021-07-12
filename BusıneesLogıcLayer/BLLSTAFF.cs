using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;
using BusıneesLogıcLayer;

namespace BusıneesLogıcLayer
{
    public class BLLSTAFF
    {
        public static List<EntıtyStaff> BllStaffList()
        {
            return DallStaff.StaffList();
        }
        public static int AddStaff(EntıtyStaff p)
        {
            if (p.StaffName1 != " " && p.StaffSurname2 != " " && p.StaffDepartment1 != 0 )
            {
                return DallStaff.AddStaff(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
