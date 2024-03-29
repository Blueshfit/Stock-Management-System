﻿using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Stock_Management_System.DAL
{
	public class CatagoryGateway
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
	      public bool ExistCatagory(Catagory catagory)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			string query = "SELECT *FROM Catagory_tbl WHERE CatagoryName ='" + catagory.CatagoryName + "'";
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

		public int InsertCatagory(Catagory catagory)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "INSERT INTO Catagory_tbl (CatagoryName) VALUES('" + catagory.CatagoryName + "')";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			int rowEffect = command.ExecuteNonQuery();
			connection.Close();
			return rowEffect;
		}
		public List<Catagory> GetAllCatagories()
		{
			List<Catagory> catagories = new List<Catagory>();
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Catagory_tbl";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Catagory catagory = new Catagory();
				catagory.CatagoryId = (int)reader["CatagoryId"];
				catagory.CatagoryName = reader["CatagoryName"].ToString();

				catagories.Add(catagory);
			}
			connection.Close();
			return catagories;


		}

	}
}