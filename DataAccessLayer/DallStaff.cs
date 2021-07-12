using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
 public   class DallStaff
    {
        public static List<EntıtyStaff> StaffList()
        {
            List<EntıtyStaff> valuess = new List<EntıtyStaff>();
            SqlCommand command = new SqlCommand("DEPARTMANPRO", ConnectionClass.bgl);
            command.CommandType = CommandType.StoredProcedure;
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                EntıtyStaff ent = new EntıtyStaff();
                ent.StaffId1 = int.Parse(dr["STAFFID"].ToString());
                ent.StaffName1 = dr["STAFFNAME"].ToString();
                ent.StaffSurname2 = dr["STAFFSURNAME"].ToString();
                ent.StaffSalary1 = decimal.Parse(dr["STAFFSALARY"].ToString());
                // ent.StaffDepartment1 = int.Parse(dr["STAFFDEPARTMENT"].ToString());
                ent.StaffDep1 = dr["DEPARTMENTNAME"].ToString();
                ent.StaffPhoto1 = dr["STAFFPHOTO"].ToString();
                valuess.Add(ent);
            }
            dr.Close();
            return valuess;
        }
        public static int AddStaff(EntıtyStaff p)
        {
            SqlCommand command4 = new SqlCommand("insert into Tbl_OOPSTAFFMANAGER (STAFFNAME,STAFFSURNAME,STAFFDEPARTMENT,STAFFSALARY) values(@p1,@p2,@p3,@p4)", ConnectionClass.bgl);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("@p1", p.StaffName1);
            command4.Parameters.AddWithValue("@p2", p.StaffSurname2);
            command4.Parameters.AddWithValue("@p3", p.StaffDepartment1);
            command4.Parameters.AddWithValue("@p4", p.StaffSalary1);
            return command4.ExecuteNonQuery();
        }
    }
}
