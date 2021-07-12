using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class DalProduct
    {
        public static List<EntityProduct> ProductList()
        {
            List<EntityProduct> valuess = new List<EntityProduct>();
            SqlCommand command = new SqlCommand("SELECT * FROM OOPTABLEPRODUCT", ConnectionClass.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                EntityProduct ent = new EntityProduct();
                ent.ProductId1 = int.Parse(dr["PRODUCTID"].ToString());
                ent.ProductName1 = dr["PRODUCTNAME"].ToString();
                ent.ProductPrice1 = decimal.Parse(dr["PRODUCTPRİCE"].ToString());
                ent.ProductPiece1 = int.Parse(dr["PRODUCTPİECE"].ToString());
                valuess.Add(ent);
            }
            dr.Close();
            return valuess;
        }
        public static int AddProduct(EntityProduct p)
        {
            SqlCommand command3 = new SqlCommand("insert into OOPTableProduct (PRODUCTNAME,PRODUCTPrice,PRODUCTPiece) values(@p1,@p2,@p3)", ConnectionClass.bgl);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@p1", p.ProductName1);
            command3.Parameters.AddWithValue("@p2", p.ProductPiece1);
            command3.Parameters.AddWithValue("@p3", p.ProductPrice1);
            return command3.ExecuteNonQuery();
        }
    }
}
