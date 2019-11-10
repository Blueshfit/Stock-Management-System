using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Stock_Management_System.DAL
{
	public class SellGateway
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
		public void InsertSell(Item item)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Item_tbl WHERE ItemId =" + item.ItemId + "";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			Sell sell = new Sell();
			while (reader.Read())
			{
				sell.ItemId = (int)reader["ItemId"];
				sell.ItemName = reader["ItemName"].ToString();
				

			}
			connection.Close();
			sell.SellDate = DateTime.Today.ToString();
			string query1 = "INSERT INTO Sell_tbl (ItemId,SellDate,ItemName) VALUES (" + sell.ItemId + ",'" + sell.SellDate + "','" + sell.ItemName + "')";
			
			SqlCommand command1 = new SqlCommand(query1, connection);
			connection.Open();
			int rowEffect = command1.ExecuteNonQuery();
			connection.Close();
		}
	}
}