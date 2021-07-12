using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
   public class EntıtyStaff
    {
        private int StaffId;
        private string StaffName;
        private string StaffSurname;
        private string StaffPhoto;
        private int StaffDepartment;
        private decimal StaffSalary;
        private string StaffDep;

        public int StaffId1 { get => StaffId; set => StaffId = value; }
        public string StaffName1 { get => StaffName; set => StaffName = value; }
        
        public string StaffSurname2 { get => StaffSurname; set => StaffSurname = value; }
        public string StaffPhoto1 { get => StaffPhoto; set => StaffPhoto = value; }
        public int StaffDepartment1 { get => StaffDepartment; set => StaffDepartment = value; }
        public decimal StaffSalary1 { get => StaffSalary; set => StaffSalary = value; }
        public string StaffDep1 { get => StaffDep; set => StaffDep = value; }
    }
}
