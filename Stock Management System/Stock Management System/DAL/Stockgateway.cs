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
		public Item GetItem(int itemId)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			string query = "SELECT * FROM Item_tbl WHERE ItemId =" + itemId + "";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			Item item = new Item();
			while (reader.Read())
			{
				item.ReorderLevel = reader["ReorderLevel"].ToString();
				item.Quantity = reader["Quantity"].ToString();
			}
			connection.Close();
			return item;
		}
		public bool StockInItemQuantity(Item item)
		{
			double quantity;
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT Quantity FROM Item_tbl WHERE ItemId ='" + item.ItemId + "' AND CompanyId ='" + item.ComapnyId + "'";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			
			Item aItem = new Item();
			while (reader.Read())
			{
				 aItem.Quantity=reader["Quantity"].ToString();
				

			}
			connection.Close();
			quantity = Convert.ToDouble(aItem.Quantity);
			
			double stockIn = Convert.ToInt32(item.Quantity);
			double availableQuantity = quantity + stockIn;
			string inputQuantity = availableQuantity.ToString();
			string updateQuery = "UPDATE Item_tbl SET Quantity ='" + inputQuantity + "' WHERE ItemId= " + item.ItemId + " AND CompanyId =" + item.ComapnyId + "";
			SqlCommand command1 = new SqlCommand(updateQuery, connection);
			connection.Open();
			int rowEffect = command1.ExecuteNonQuery();
			if (rowEffect > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool StockOutItemQuantity(Item item)
		{
			double quantity;
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT Quantity FROM Item_tbl WHERE ItemId ='" + item.ItemId + "' AND CompanyId ='" + item.ComapnyId + "'";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			Item aItem = new Item();
			while (reader.Read())
			{
				aItem.Quantity = reader["Quantity"].ToString();


			}
			connection.Close();
			quantity = Convert.ToDouble(aItem.Quantity);

			double stockIn = Convert.ToInt32(item.Quantity);
			if (stockIn > quantity)
			{
				return false;
			}
			else
			{
				double availableQuantity = quantity - stockIn;

				string inputQuantity = availableQuantity.ToString();
				string updateQuery = "UPDATE Item_tbl SET Quantity ='" + inputQuantity + "' WHERE ItemId= " + item.ItemId + " AND CompanyId =" + item.ComapnyId + "";
				SqlCommand command1 = new SqlCommand(updateQuery, connection);
				connection.Open();
				int rowEffect = command1.ExecuteNonQuery();
				if (rowEffect > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}
}