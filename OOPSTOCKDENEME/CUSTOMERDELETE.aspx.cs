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
    public partial class CUSTOMERDELETE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["CUSTOMERID"]);
            EntityCustomers ent = new EntityCustomers();
            ent.CustomerId1 = x;
            BLLCUSTOMER.BllCustomerDelete(ent.CustomerId1);
            Response.Redirect("CUSTOMERS.aspx");
        }
    }
}