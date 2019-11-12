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
		public List<Item> GetAllItemOfTheCompany(int id)
		{
			return stockgateway.GetAllItemOfTheCompany(id);
		}
		public Item GetItem(int itemId)
		{
			return stockgateway.GetItem(itemId);
		}
		public string StockInQuantity(Item item)
		{
			if (stockgateway.StockInItemQuantity(item))
			{
				return "Successfully stocked in items.";
			}
			else
			{
				return "Cannot stockin in items.";
			}
		}
		public string StockOutQuantity(Item item)
		{
			if (stockgateway.StockOutItemQuantity(item))
			{
				return "Successfully stocked out items.";
			}
			else
			{
				return "Cannot stockin out items.";
			}
		}
	}
}