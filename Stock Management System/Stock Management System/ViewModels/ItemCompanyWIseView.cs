using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.ViewModels
{
	public class ItemCompanyWIseView
	{
		public ItemCompanyWIseView()
		{
		}

		public ItemCompanyWIseView(string itemName, string companyname, int itemId, int companyId)
		{
			ItemName = itemName;
			Companyname = companyname;
			ItemId = itemId;
			CompanyId = companyId;
		}

		public string ItemName { set; get; }
		public string Companyname { set; get; }
		public int ItemId { set; get; }
		public int CompanyId { set; get; }
		public string Quantity { set; get; }
	}
}