using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System
{
	public partial class ViewItemBetweenDatesUI : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void searchButton_Click(object sender, EventArgs e)
		{
			string fromDate = fromDateTextBox.Value;
			string toDate = toDateTextBox.Value;
			DateTime aDate = Convert.ToDateTime(fromDate);
			DateTime bDate = Convert.ToDateTime(toDate);
			int result = DateTime.Compare(aDate, bDate);
			if (result > 0)
			{
				messageLabel.Text = "Date is not correct";
				messageLabel.ForeColor = Color.Red;
			}

			GetAllItemSell(fromDate, toDate);
		}

		private void GetAllItemSell(string fromDate, string toDate)
		{
			SellManager sellManager = new SellManager();
			List<Sell> Sells = new List<Sell>();
			Sells = sellManager.GetAllSellitemBetweenDate(fromDate, toDate);
			sellGridView.DataSource = Sells;
			sellGridView.DataBind();
		}
	}
}