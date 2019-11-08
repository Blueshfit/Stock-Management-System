using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Stock_Management_System.DAL
{
	public class ItemGateway
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
		public bool InsertItem(Item item)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "INSERT INTO Item_tbl (ItemName, CatagoryId, CompanyId, ReorderLevel) VALUES('"+item.ItemName+"','"+item.CatagoryId+"','"+item.ComapnyId+"','"+item.ReorderLevel+"')";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			int rowEffect = command.ExecuteNonQuery();
			connection.Close();
			if (rowEffect > 0)
			{
				return true;
			}
			else { return false; }
		}
	}
}