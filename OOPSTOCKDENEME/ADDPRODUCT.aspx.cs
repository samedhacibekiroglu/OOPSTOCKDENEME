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
    public partial class ADDPRODUCT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           EntityProduct ent = new EntityProduct();
            ent.ProductName1 = TextBox1.Text;
            ent.ProductPrice1 = decimal.Parse(TextBox2.Text);
            ent.ProductPiece1 = int.Parse(TextBox3.Text);

            BllProduct.AddProduct(ent);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('THE PRODUCT HAS BEEN SUCCESSFULLY ADDED')", true);
            
        }
    }
}