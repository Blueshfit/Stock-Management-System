using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Models
{
	public class Item
	{
		public Item()
		{
		}

		public Item(int itemId, int comapnyId, string quantity)
		{
			ItemId = itemId;
			ComapnyId = comapnyId;
			Quantity = quantity;
		}

		public Item(string itemName, int catagoryId, int comapnyId, string reorderLevel)
		{
			ItemName = itemName;
			CatagoryId = catagoryId;
			ComapnyId = comapnyId;
			ReorderLevel = reorderLevel;
		}

		public Item(string itemName, int catagoryId, int comapnyId, string reorderLevel, string quantity)
		{
			ItemName = itemName;
			CatagoryId = catagoryId;
			ComapnyId = comapnyId;
			ReorderLevel = reorderLevel;
			Quantity = quantity;
		}

		public Item(int itemId, string itemName, int catagoryId, int comapnyId, string reorderLevel, string quantity)
		{
			ItemId = itemId;
			ItemName = itemName;
			CatagoryId = catagoryId;
			ComapnyId = comapnyId;
			ReorderLevel = reorderLevel;
			Quantity = quantity;
		}

		public int ItemId { set; get; }
		public string ItemName { set; get; }
		public int CatagoryId { set; get; }
		public int ComapnyId { set; get; }
		public string ReorderLevel { set; get; }
		public string Quantity { set; get; }
	}
}