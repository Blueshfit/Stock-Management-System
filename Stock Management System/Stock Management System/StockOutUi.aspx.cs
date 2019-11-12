using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using Stock_Management_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System
{
    public partial class StockOutUi : System.Web.UI.Page
    {
		DataRow dr;
		DataTable dt = new DataTable();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				BindAllCompany();
			}
			if (!Page.IsPostBack)
			{
				if (ViewState["Records"] == null)
				{
					dt.Columns.Add("Item");
					dt.Columns.Add("Company");
					dt.Columns.Add("Quantity");
					ViewState["Records"] = dt;
				}
			}

			

			
		}
		private void BindAllCompany()
		{
			CompanyManager companyManager = new CompanyManager();
			List<Company> companies = new List<Company>();
			companies = companyManager.GetAllCompanies();
			companyDropDownList.DataTextField = "CompanyName";
			companyDropDownList.DataValueField = "CompanyId";
			companyDropDownList.DataSource = companies;
			companyDropDownList.DataBind();
			int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			BindAllItem(companyId);
		}
		protected void companyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			BindAllItem(companyId);

		}

		private void BindAllItem(int companyId)
		{
			StockManager stockManager = new StockManager();
			List<Item> items = new List<Item>();
			itemDropDownList.Items.Clear();
			items = stockManager.GetAllItemOfTheCompany(companyId);
			itemDropDownList.DataTextField = "ItemName";
			itemDropDownList.DataValueField = "ItemId";
			itemDropDownList.DataSource = items;
			itemDropDownList.DataBind();
			if (itemDropDownList.SelectedValue != string.Empty)
			{
				int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
				SetItemData(itemId);
			}

		}
		private void SetItemData(int itemId)
		{
			StockManager stockManager = new StockManager();
			Item item = new Item();
			item = stockManager.GetItem(itemId);
			reorderLabelSet.Text = item.ReorderLevel;
			availableQuantityLabelSet.Text = item.Quantity;


		}

		protected void sellButton_Click(object sender, EventArgs e)
		{
			//int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			//int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			//string quantity = stockOutQuantityTextBox.Text;
			//Item item = new Item(itemId, companyId, quantity);
			//StockOutQuantitySell(item);
			//BindAllCompany();

			//BindAllItem(itemId);
			List<Stockout> stockouts = new List<Stockout>();
			foreach (GridViewRow row in stockOutGridView.Rows)
			{

				Stockout stockout = new Stockout();
				string itemName = row.Cells[0].Text;
				string companyName = row.Cells[1].Text;
				string Quantity = row.Cells[2].Text;
				stockout.ItemName = itemName;
				stockout.CompanyName = companyName;
				stockout.Quantity = Quantity;
				stockouts.Add(stockout);
			}
			StockManager stockManager = new StockManager();
			stockManager.StockOutQuantity(stockouts);
			


		}

		//private void StockOutQuantitySell(Item item)
		//{
		//	StockManager stockManager = new StockManager();
		//	SellManager sellManager = new SellManager();
		//	string message = stockManager.StockOutQuantity(item);
		//	messageLabel.Text = message;
		//	if (message == "Successfully stocked out items.")
		//	{
		//		messageLabel.ForeColor = Color.Green;
		//		sellManager.InsertSell(item);
		//	}
		//	else
		//	{
		//		messageLabel.ForeColor = Color.Red;
		//	}
		//}

		protected void itemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			SetItemData(itemId);
		}

		protected void damageButton_Click(object sender, EventArgs e)
		{
			List<Stockout> stockouts = new List<Stockout>();
			foreach (GridViewRow row in stockOutGridView.Rows)
			{

				Stockout stockout = new Stockout();
				string itemName = row.Cells[0].Text;
				string companyName = row.Cells[1].Text;
				string Quantity = row.Cells[2].Text;
				stockout.ItemName = itemName;
				stockout.CompanyName = companyName;
				stockout.Quantity = Quantity;
				stockouts.Add(stockout);
			}
			StockManager stockManager = new StockManager();
			stockManager.StockOutQuantity(stockouts);
		}
		

	

		protected void lostButton_Click(object sender, EventArgs e)
		{
			List<Stockout> stockouts = new List<Stockout>();
			foreach (GridViewRow row in stockOutGridView.Rows)
			{

				Stockout stockout = new Stockout();
				string itemName= row.Cells[0].Text;
				string companyName= row.Cells[1].Text;
				string Quantity= row.Cells[2].Text;
				stockout.ItemName = itemName;
				stockout.CompanyName = companyName;
				stockout.Quantity = Quantity;
				stockouts.Add(stockout);
			}
			StockManager stockManager = new StockManager();
			stockManager.StockOutQuantity(stockouts);

			//int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			//int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			//string quantity = stockOutQuantityTextBox.Text;
			//Item item = new Item(itemId, companyId, quantity);
			//StockOutQuantity(item);
			//BindAllCompany();
			//BindAllItem(itemId);
		}

		protected void addButton_Click(object sender, EventArgs e)
		{
			int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			string quantity = stockOutQuantityTextBox.Text;
			Item item = new Item(itemId, companyId, quantity);
			
			ItemCompanyWIseView items = new ItemCompanyWIseView();
			StockManager stockManager = new StockManager();
			if (stockManager.IsGeaterQuanity(item))
			{
				messageLabel.Text = "Available quantity is less than stock out quantity";
			}
			else
			{
				items = stockManager.GetStcokOutItem(item);
				//dr = dt.NewRow();
				//dr["Item"] = items.ItemName;
				//dr["Company"] = items.Companyname;
				//dr["Quantity"] = item.Quantity;
				dt = (DataTable)ViewState["Records"];

				dt.Rows.Add(items.ItemName, items.Companyname, items.Quantity);
				stockOutGridView.DataSource = dt;
				stockOutGridView.DataBind();
			}
		
			BindAllCompany();
			BindAllItem(itemId);
		}
	}
}