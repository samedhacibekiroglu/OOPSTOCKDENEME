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
    public class DalCustomer
    {
        public static List<EntityCustomers> CustomerList()
        {
            List<EntityCustomers> valuess = new List<EntityCustomers>();
            SqlCommand command = new SqlCommand("Select * From TableCustomer", ConnectionClass.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                EntityCustomers ent = new EntityCustomers();
                ent.CustomerId1 = int.Parse(dr["CUSTOMERID"].ToString());
                ent.CustomerName1 = dr["CUSTOMERNAME"].ToString();
                ent.CustomerSurname1 = dr["CUSTOMERSURNAME"].ToString();
                valuess.Add(ent);
            }
            dr.Close();
            return valuess;
        }
        public static int AddCustomer(EntityCustomers p)
        {
            SqlCommand command2 = new SqlCommand("insert into TableCustomer (CUSTOMERNAME,CUSTOMERSURNAME) values(@p1,@p2)", ConnectionClass.bgl);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            command2.Parameters.AddWithValue("@p1", p.CustomerName1);
            command2.Parameters.AddWithValue("@p2", p.CustomerSurname1);
            return command2.ExecuteNonQuery();
        }
        public static bool DeleteCustomer(int p)
        {
            SqlCommand command3 = new SqlCommand("Delete From TableCustomer where CUSTOMERID=@P1", ConnectionClass.bgl);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@P1", p);
            return command3.ExecuteNonQuery() > 0;
        }
        public static List<EntityCustomers> BringCustomers(int id)
        {
            List<EntityCustomers> valuess = new List<EntityCustomers>();
            SqlCommand command = new SqlCommand("Select * From TableCustomer WHERE CUSTOMERID=@P1", ConnectionClass.bgl);
            command.Parameters.AddWithValue("@p1", id);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                EntityCustomers ent = new EntityCustomers();
                //ent.CustomerId1 = int.Parse(dr["CUSTOMERID"].ToString());
                ent.CustomerName1 = dr["CUSTOMERNAME"].ToString();
                ent.CustomerSurname1 = dr["CUSTOMERSURNAME"].ToString();
                valuess.Add(ent);
            }
            dr.Close();
            return valuess;
        }
        public static bool UpdateCustomer(EntityCustomers p)
        {
            SqlCommand command = new SqlCommand("Update TableCustomer SET CustomerName=@p1,CustomerSurname=@p2 where CustomerId=@p3", ConnectionClass.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1", p.CustomerName1);
            command.Parameters.AddWithValue("@p2", p.CustomerSurname1);
            command.Parameters.AddWithValue("@p3", p.CustomerId1);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
