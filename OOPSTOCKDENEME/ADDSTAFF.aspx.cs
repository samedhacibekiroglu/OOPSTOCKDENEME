using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ENTITYLAYER;
using DataAccessLayer;
using BusıneesLogıcLayer;

namespace OOPSTOCKDENEME
{
    public partial class ADDSTAFF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_OOPDEPARTMENT", ConnectionClass.bgl);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataValueField = "DEPARTMENTID";
            DropDownList1.DataTextField = "DEPARTMENTNAME";
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
    }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntıtyStaff ent = new EntıtyStaff();
            ent.StaffName1 = TextBox1.Text;
            ent.StaffSurname2 = TextBox2.Text;
            ent.StaffSalary1=decimal.Parse(TextBox3.Text);
            ent.StaffDepartment1 = int.Parse(DropDownList1.SelectedValue);
            BLLSTAFF.AddStaff(ent);
            Response.Redirect("Staff.aspx");
        }
    }
}