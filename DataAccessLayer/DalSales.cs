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
   public class DalSales
    {
        public static List<EntitySales> SalesList()
        {
            List<EntitySales> valuess = new List<EntitySales>();
            SqlCommand command = new SqlCommand("SATISLLLAR", ConnectionClass.bgl);
            
            command.CommandType = CommandType.StoredProcedure;
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                EntitySales ent = new EntitySales();
                ent.SaleId1 = int.Parse(dr["SALEID"].ToString());
                ent.ProductName1 = dr["PRODUCTNAME"].ToString();
                ent.StaffName1 = dr["STAFF"].ToString();
                ent.Amount1 = decimal.Parse(dr["AMOUNT"].ToString());
                //ent.StaffSurname1 = dr["STAFFSURNAME"].ToString();
                ent.CustomerName1 = dr["CUSTOMER"].ToString();
                //ent.CustomerSurname1 = dr["CUSTOMERSURNAME"].ToString();
                valuess.Add(ent);
            }
            dr.Close();
            return valuess;
        }
    }
}
