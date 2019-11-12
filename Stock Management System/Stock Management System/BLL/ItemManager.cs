using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using Stock_Management_System.ViewModels;
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
			if (itemGateway.IsExistItem(item))
			{
				if (item.ReorderLevel == "0")
				{
					return "Already exist";
				}
				else
				{
					if (itemGateway.UpdateItem(item))
					{
						return "Reorder level updated successfully";
					}
				}
			}
			if (item.Quantity ==string.Empty)
			{
				item.Quantity = "0";
			}
			
			else
			{
				item.Quantity = item.Quantity;
			}
			if (item.ReorderLevel == string.Empty)
			{
				item.ReorderLevel = "0";
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
		public List<CatagoryCompanyWISeItemView> GetAllItems(Item item)
		{
			return itemGateway.GetAllItems(item);
		}
	}
}