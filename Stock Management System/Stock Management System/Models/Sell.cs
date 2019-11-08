using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Models
{
	public class Sell
	{
		public Sell()
		{
		}

		public Sell(int itemId, string sellDate)
		{
			ItemId = itemId;
			SellDate = sellDate;
		}

		public Sell(int sellId, int itemId, string sellDate)
		{
			SellId = sellId;
			ItemId = itemId;
			SellDate = sellDate;
		}

		public int SellId { set; get; }
		public int ItemId { set; get; }
		public string SellDate { set; get; }
		public string ItemName { set; get; }
	}
}