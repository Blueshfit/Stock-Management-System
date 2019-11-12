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
			sell.Quantity = item.Quantity;
			string query1 = "INSERT INTO Sell_tbl (ItemId,SellDate,ItemName,Quantity) VALUES (" + sell.ItemId + ",'" + sell.SellDate + "','" + sell.ItemName + "','"+sell.Quantity+"')";
			
			SqlCommand command1 = new SqlCommand(query1, connection);
			connection.Open();
			int rowEffect = command1.ExecuteNonQuery();
			connection.Close();
		}
		public List<Sell> GetAllSeelItemBewtweenDate(string fromDate,string toDate)
		{
			List<Sell> sellItem = new List<Sell>();
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Sell_tbl WHERE SellDate BETWEEN'" + fromDate + "' AND '" + toDate + "'";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			
			while (reader.Read())
			{
				Sell sell = new Sell();
				sell.ItemName = reader["ItemName"].ToString();
				sell.Quantity = reader["Quantity"].ToString();
				sellItem.Add(sell);
			}
			connection.Close();
			return sellItem;


		}
	}

}