using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using DataAccessLayer;
using BusıneesLogıcLayer;

namespace OOPSTOCKDENEME
{
    public partial class UPDATECUSTOMER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["CUSTOMERID"]);
            TextBox3.Text = x.ToString();
            EntityCustomers ent = new EntityCustomers();
            if (Page.IsPostBack==false)
            {
                List<EntityCustomers> cuslist = BLLCUSTOMER.BllBringCustomers(x);
                TextBox1.Text = cuslist[0].CustomerName1.ToString();
                TextBox2.Text = cuslist[0].CustomerSurname1.ToString();
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityCustomers ent = new EntityCustomers();
            ent.CustomerName1 = TextBox1.Text;
            ent.CustomerSurname1 = TextBox2.Text;
            ent.CustomerId1 = Convert.ToInt32(TextBox3.Text);
            BLLCUSTOMER.BllUpdateCustomer(ent);
            Response.Redirect("CUSTOMERS.aspx");
        }
    }
}