using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using BusıneesLogıcLayer;
using DataAccessLayer;

namespace OOPSTOCKDENEME
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDepartment> DepList = BllDepartment.BllListDepartment();
            Repeater1.DataSource = DepList;
            Repeater1.DataBind();

            
        }
    }
}