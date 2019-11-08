using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Stock_Management_System.DAL
{
	public class CompanyGateway
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
		public bool isExistCompany(string name)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Company_tbl WHERE CompanyName = '" + name + "'";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			if (reader.Read())
			{
				return true;
			}
			else
			{
				return false;
			}
			connection.Close();
		}
		public bool InsertComapny(string name)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "INSERT INTO Company_tbl (CompanyName) VALUES ('" + name + "')";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();

			int rowEffect = command.ExecuteNonQuery();
			if (rowEffect > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public List<Company> GetAllCompanies()
		{
			List<Company> companies = new List<Company>();
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Company_tbl";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Company company = new Company((int)reader["CompanyId"],reader["CompanyName"].ToString());
				
				companies.Add(company);
			}
			connection.Close();
			return companies;


		}
	}
}