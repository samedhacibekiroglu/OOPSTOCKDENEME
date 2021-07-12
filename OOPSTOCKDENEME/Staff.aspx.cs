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
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntıtyStaff> StaffLis = BLLSTAFF.BllStaffList();
            Repeater1.DataSource = StaffLis;
            Repeater1.DataBind();
        }
    }
}