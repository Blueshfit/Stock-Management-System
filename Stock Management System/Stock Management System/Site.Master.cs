using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            if (Session["name"] == null)
            {
                user.InnerText = "Logged Out";
                logOut.Visible = false;
                catSetUp.Visible = false;
                companySetUp.Visible = false;
                itemSetUp.Visible = false;
                stockIn.Visible = false;
                stockOut.Visible = false;
                avis.Visible = false;
                vibd.Visible = false;
            }
            else
            {
                string username = (string)Session["name"];
                user.InnerText = "Logged in as " + username;
                logIn.Visible = false;
            }

        }
    }
}