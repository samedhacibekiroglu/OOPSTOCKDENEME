using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ENTITYLAYER;

namespace BusıneesLogıcLayer
{
    public class BllDepartment
    {
        public static List<EntityDepartment> BllListDepartment()
        {
            return DalDepartment.DepartmentsList();

        }
        public static int AddDepartment(EntityDepartment p)
        {
            if (p.DepartmentName1 != null && p.DepartmentName1 !="")
            {
                return DalDepartment.AddDepartment(p);
            }
            return -1;
        }

    }
}
