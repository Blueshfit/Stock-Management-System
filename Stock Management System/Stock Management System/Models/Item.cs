using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Models
{
	public class Item
	{
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