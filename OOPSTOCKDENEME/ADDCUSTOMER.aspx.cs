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
    public partial class ADDCUSTOMER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityCustomers ent = new EntityCustomers();
            ent.CustomerName1 = TextBox1.Text;
            ent.CustomerSurname1 = TextBox2.Text;
            BLLCUSTOMER.AddCustomer(ent);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('THE CUSTOMER HAS BEEN SUCCESSFULLY ADDED')", true);
        }
        
    }
}