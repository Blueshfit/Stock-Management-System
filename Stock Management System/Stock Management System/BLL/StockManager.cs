using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.BLL
{
	public class StockManager
	{
		Stockgateway stockgateway = new Stockgateway();
		public List<Item> GetAllItemOfTheCompany(int name)
		{
			return stockgateway.GetAllItemOfTheCompany(name);
		}
	}
}