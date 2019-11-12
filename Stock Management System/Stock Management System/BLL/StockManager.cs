using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using Stock_Management_System.ViewModels;
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
		public void StockOutQuantity(List<Stockout> stockouts)
		{
			stockgateway.StockOutItemQuantity(stockouts);
		
		}
		public ItemCompanyWIseView GetStcokOutItem(Item item)
		{
			return stockgateway.GetStockOutItem(item);
		}
		public bool IsGeaterQuanity(Item item)
		{
			if (stockgateway.IsGeaterQuanity(item))
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