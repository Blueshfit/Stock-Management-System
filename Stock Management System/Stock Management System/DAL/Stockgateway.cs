using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Stock_Management_System.DAL
{
	public class Stockgateway
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
		public List<Item> GetAllItemOfTheCompany(int companyId)
		{
			List<Item> items = new List<Item>();
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Item_tbl WHERE CompanyId =" + companyId + "";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{

				Item item = new Item();
				item.ItemId = (int)reader["ItemId"];
				item.ItemName = reader["ItemName"].ToString();
				item.ReorderLevel = reader["ReorderLevel"].ToString();
				items.Add(item);

			}
			connection.Close();
			return items;

		}
	}
}