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
    public partial class StockOutUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("LogInForm.aspx");
            }
            if (!IsPostBack)
			{
				BindAllCompany();
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
			int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			string quantity = stockOutQuantityTextBox.Text;
			Item item = new Item(itemId, companyId, quantity);
			StockOutQuantitySell(item);
			BindAllCompany();
			BindAllItem(itemId);

		}

		private void StockOutQuantitySell(Item item)
		{
			StockManager stockManager = new StockManager();
			SellManager sellManager = new SellManager();
			string message = stockManager.StockOutQuantity(item);
			messageLabel.Text = message;
			if (message == "Successfully stocked out items.")
			{
				messageLabel.ForeColor = Color.Green;
				sellManager.InsertSell(item);
			}
			else
			{
				messageLabel.ForeColor = Color.Red;
			}
		}

		protected void itemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			SetItemData(itemId);
		}

		protected void damageButton_Click(object sender, EventArgs e)
		{
			int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			string quantity = stockOutQuantityTextBox.Text;
			Item item = new Item(itemId, companyId, quantity);
			StockOutQuantity(item);
			BindAllCompany();
			BindAllItem(itemId);
		}
		private void StockOutQuantity(Item item)
		{
			StockManager stockManager = new StockManager();
			
			string message = stockManager.StockOutQuantity(item);
			messageLabel.Text = message;
			if (message == "Successfully stocked out items.")
			{
				messageLabel.ForeColor = Color.Green;
				
			}
			else
			{
				messageLabel.ForeColor = Color.Red;
			}
		}

		protected void lostButton_Click(object sender, EventArgs e)
		{
			int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			string quantity = stockOutQuantityTextBox.Text;
			Item item = new Item(itemId, companyId, quantity);
			StockOutQuantity(item);
			BindAllCompany();
			BindAllItem(itemId);
		}
	}
}