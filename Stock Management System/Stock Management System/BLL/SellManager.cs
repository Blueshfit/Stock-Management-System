using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.BLL
{
	public class SellManager
	{
		SellGateway sellGateway = new SellGateway();
		public void InsertSell(List<Stockout>stockouts)
		{
			sellGateway.InsertSell(stockouts);
		}
		public List<Sell> GetAllSellitemBetweenDate(string fromDate,string toDate)
		{
			return sellGateway.GetAllSeelItemBewtweenDate(fromDate, toDate);
		}
	}
}