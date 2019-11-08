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
	public class ItemGateway
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
		public bool InsertItem(Item item)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "INSERT INTO Item_tbl (ItemName, CatagoryId, CompanyId, ReorderLevel,Quantity) VALUES('"+item.ItemName+"','"+item.CatagoryId+"','"+item.ComapnyId+"','"+item.ReorderLevel+"','"+0+"')";
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
		public List<CatagoryCompanyWISeItemView> GetAllItems(Item item)
		{
			List<CatagoryCompanyWISeItemView> items = new List<CatagoryCompanyWISeItemView>();
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM CatagoryCompanyWiseViewItem WHERE CatagoryId = " + item.CatagoryId + " AND CompanyId =" + item.ComapnyId + ";";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				CatagoryCompanyWISeItemView companyWISeItemView = new CatagoryCompanyWISeItemView();
				companyWISeItemView.ItemName = reader["ItemName"].ToString();
				companyWISeItemView.CompanyName = reader["CompanyName"].ToString();
				companyWISeItemView.CatagoryName = reader["CatagoryName"].ToString();
				companyWISeItemView.Available_Quantity = reader["Available_Quantity"].ToString();
				companyWISeItemView.ReorderLevel = reader["ReorderLevel"].ToString();
				companyWISeItemView.CompanyId = (int)reader["CompanyId"];
				companyWISeItemView.CatagoryId = (int)reader["CatagoryId"];
				items.Add(companyWISeItemView);



					
			}
			connection.Close();
			return items;

		}
	}
}