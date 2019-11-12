using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Models
{
	public class Stockout
	{
		public Stockout()
		{
		}

		public Stockout(string itemName, string companyName, string quantity)
		{
			ItemName = itemName;
			CompanyName = companyName;
			Quantity = quantity;
		}

		public string ItemName { set; get; }
		public string CompanyName { set; get; }
		public string Quantity { set; get; }

	}
}