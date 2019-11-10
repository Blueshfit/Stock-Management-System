using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;

namespace Stock_Management_System.DAL
{
	public class UserGateway :LogInForm
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;

		

		public bool Existuser(User user)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM User_tbl WHERE UserName='" + user.UserName + "'AND Password='" + user.Password + "'";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
            {

                Session["Name"] = user.UserName;
                HttpContext.Current.Response.Redirect("Index.aspx");
                return true;
			}
			else
			{
				return false;
			}
		}
	}
}