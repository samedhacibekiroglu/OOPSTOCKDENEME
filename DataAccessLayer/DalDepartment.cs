using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITYLAYER;

namespace DataAccessLayer
{
    public class DalDepartment
    {
        public static List<EntityDepartment> DepartmentsList()
        {
            List<EntityDepartment> valuess = new List<EntityDepartment>();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_OOPDEPARTMENT", ConnectionClass.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartment ent = new EntityDepartment();
                ent.DepartmentId1 = Convert.ToInt16(dr["DEPARTMENTID"].ToString());
                ent.DepartmentName1 = dr["DEPARTMENTNAME"].ToString();
                valuess.Add(ent);
            }
            dr.Close();
            return valuess;
        }
        public static int AddDepartment(EntityDepartment p)
        {
            SqlCommand command1 = new SqlCommand("insert into TBL_OOPDEPARTMENT (DepartmentName) Values (@p1)", ConnectionClass.bgl);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            command1.Parameters.AddWithValue("@p1", p.DepartmentName1);
            return command1.ExecuteNonQuery();
        }
        }
    }
