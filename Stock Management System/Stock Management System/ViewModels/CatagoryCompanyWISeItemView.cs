using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.ViewModels
{
	public class CatagoryCompanyWISeItemView
	{
		public CatagoryCompanyWISeItemView()
		{
		}

		public CatagoryCompanyWISeItemView(string itemName, string companyName, string catagoryName, string available_Quantity, string reorderLevel)
		{
			ItemName = itemName;
			CompanyName = companyName;
			CatagoryName = catagoryName;
			Available_Quantity = available_Quantity;
			ReorderLevel = reorderLevel;
		}

		public CatagoryCompanyWISeItemView(string itemName, string companyName, string catagoryName, string available_Quantity, string reorderLevel, int companyId, int catagoryId)
		{
			ItemName = itemName;
			CompanyName = companyName;
			CatagoryName = catagoryName;
			Available_Quantity = available_Quantity;
			ReorderLevel = reorderLevel;
			CompanyId = companyId;
			CatagoryId = catagoryId;
		}

		public string ItemName { set; get; }
		public string CompanyName { set; get; }
		public string CatagoryName { set; get; }
		public string Available_Quantity { set; get; }
		public string ReorderLevel { set; get; }
		public int CompanyId { set; get; }
		public int CatagoryId { set; get; }
	}
}