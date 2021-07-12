using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusıneesLogıcLayer;
using DataAccessLayer;
using ENTITYLAYER;

namespace OOPSTOCKDENEME
{
    public partial class ADDSALE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM OOPTableProduct", ConnectionClass.bgl);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownListProduct.DataValueField = "PRODUCTID";
            DropDownListProduct.DataTextField = "PRODUCTNAME";
            DropDownListProduct.DataSource = dt;
            DropDownListProduct.DataBind();

            SqlCommand command1 = new SqlCommand("SELECT STAFFID,(STAFFNAME + ' '+STAFFSURNAME) AS 'STAFFNAMESURNAME' FROM Tbl_OOPSTAFFMANAGER", ConnectionClass.bgl);
            SqlDataAdapter da1 = new SqlDataAdapter(command1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            DropDownListStaff.DataValueField = "STAFFID";
           DropDownListStaff.DataTextField = "STAFFNAMESURNAME";
            DropDownListStaff.DataSource = dt1;
            DropDownListStaff.DataBind();

            SqlCommand command2 = new SqlCommand("SELECT CUSTOMERID,(CUSTOMERNAME + ' '+CUSTOMERSURNAME) AS 'CUSTOMERNAMESURNAME' FROM TableCustomer", ConnectionClass.bgl);
            SqlDataAdapter da2 = new SqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            DropDownListCustomer.DataValueField = "CUSTOMERID";
            DropDownListCustomer.DataTextField = "CUSTOMERNAMESURNAME";
            DropDownListCustomer.DataSource = dt2;
            DropDownListCustomer.DataBind();
        }
    }
}