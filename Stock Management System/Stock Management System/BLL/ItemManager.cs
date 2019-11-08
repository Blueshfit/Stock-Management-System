using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.BLL
{
	public class ItemManager
	{
		ItemGateway itemGateway = new ItemGateway();
		public string InsertItem(Item item)
		{
			if (item.Quantity ==string.Empty)
			{
				item.Quantity = "0";
			}
			else
			{
				item.Quantity = item.Quantity;
			}
			if (itemGateway.InsertItem(item))
			{
				return "Successfully setup Item";
			}
			else
			{
				return "Cannot setup the Item.";
			}
		}
	}
}