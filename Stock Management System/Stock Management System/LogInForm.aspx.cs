using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System
{
    public partial class LogInForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

		protected void loginButton_Click(object sender, EventArgs e)
		{
			string name = userId.Value;
			string password = passwordId.Value;
			User user = new User(name,password);
			if (GetLoginUser(user))
			{
				HttpCookie cookie = new HttpCookie("UserInfo");
				cookie["Name"] = user.UserName;
				cookie["Password"] = user.Password;
				Response.Cookies.Add(cookie);
				Response.Redirect("CatagorySetupPage.aspx");

			}
			else
			{
				message.Text = "User Not Found";
			}
		
		}

		private bool GetLoginUser(User user)
		{
			UserManager userManager = new UserManager();
			bool isExist = userManager.isExistUseer(user);
			return isExist;
			
		}
	}
}