using Stock_Management_System.Models;
using Stock_Management_System.ViewModels;
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
		
		public void StockOutItemQuantity(List<Stockout> stockouts)
		{
			foreach (Stockout stockout in stockouts)
			{
				string company = stockout.CompanyName;
				SqlConnection connection = new SqlConnection(connectionString);
				string query = "SELECT * FROM Company_tbl WHERE CompanyName = '" + company + "'";
				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				Item aItem = new Item();
				while (reader.Read())
				{
					aItem.ComapnyId = (int)reader["CompanyId"];

				}
				connection.Close();
				

				double quantity;
				
				string query1 = "SELECT Quantity FROM Item_tbl WHERE ItemName ='" + stockout.ItemName + "' AND CompanyId =" + aItem.ComapnyId + "";
				SqlCommand command1 = new SqlCommand(query1, connection);
				connection.Open();
				SqlDataReader reader1 = command1.ExecuteReader();

				Item aItem1 = new Item();
				while (reader1.Read())
				{
					aItem1.Quantity = reader1["Quantity"].ToString();


				}
				connection.Close();
				quantity = Convert.ToDouble(aItem1.Quantity);

				double stockIn = Convert.ToInt32(stockout.Quantity);
				
				
					double availableQuantity = quantity - stockIn;

					string inputQuantity = availableQuantity.ToString();
					string updateQuery = "UPDATE Item_tbl SET Quantity ='" + inputQuantity + "' WHERE ItemName= '" + stockout.ItemName + "' AND CompanyId =" + aItem.ComapnyId + "";
					SqlCommand command2 = new SqlCommand(updateQuery, connection);
				connection.Open();
					
					int rowEffect = command2.ExecuteNonQuery();
				connection.Close();


			}
		}
		public ItemCompanyWIseView GetStockOutItem(Item item)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM ItemCompanyWIseView WHERE ItemId =" + item.ItemId + " AND CompanyId =" + item.ComapnyId + "";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			ItemCompanyWIseView aItem = new ItemCompanyWIseView();
			while (reader.Read())
			{
				aItem.ItemName = reader["ItemName"].ToString();
				aItem.Companyname = reader["COmpanyName"].ToString();


			}
			aItem.Quantity = item.Quantity;
			connection.Close();
			return aItem;
		}
		public bool IsGeaterQuanity(Item item)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Item_tbl WHERE ItemId =" + item.ItemId + " AND CompanyId =" + item.ComapnyId + "";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			Item aItem = new Item();
			while (reader.Read())
			{
				aItem.Quantity = reader["Quantity"].ToString();

			}
			connection.Close();
			double value = Convert.ToDouble(aItem.Quantity);
			double value1 = Convert.ToDouble(item.Quantity);
			if (value < value1)
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