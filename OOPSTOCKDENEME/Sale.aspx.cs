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
    public partial class Sale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                List<EntitySales> SalesLis = BllSales.BllSalesList();
                Repeater1.DataSource = SalesLis;
                Repeater1.DataBind();    
        }
    }
}