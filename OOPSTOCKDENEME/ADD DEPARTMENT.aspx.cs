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
    public partial class ADD_DEPARTMENT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityDepartment ent = new EntityDepartment();
            ent.DepartmentName1 = TextBox1.Text;
            BllDepartment.AddDepartment(ent);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('THE DEPARTMENT HAS BEEN SUCCESSFULLY ADDED')", true);
        }
    }
}