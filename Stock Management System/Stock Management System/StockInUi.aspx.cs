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
    public partial class StockInUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			int companyId;
			if (!IsPostBack)
			{
				BindAllCompany();

			     companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
				//BindAllItem(companyId);
			}
			 companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			BindAllItem(companyId);

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

		protected void saveButton_Click(object sender, EventArgs e)
		{
			int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			string quantity = stockInQuantityTextBox.Text;
			Item item = new Item(itemId, companyId, quantity);
			StockInQuantity(item);
			BindAllCompany();
			BindAllItem(itemId);

		}

		private void StockInQuantity(Item item)
		{
			StockManager stockManager = new StockManager();
			string message = stockManager.StockInQuantity(item);
			messageLabel.Text = message;
			if(message== "Successfully stocked in items.")
			{
				messageLabel.ForeColor = Color.Green;
			}
			else
			{
				messageLabel.ForeColor = Color.Red;
			}
		}

		protected void companyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int companyId =Convert.ToInt32( companyDropDownList.SelectedValue);
			BindAllItem(companyId);

		}

		private void BindAllItem(int companyId)
		{
			StockManager stockManager = new StockManager();
			List<Item> items = new List<Item>();

			items = stockManager.GetAllItemOfTheCompany(companyId);
			itemDropDownList.DataTextField = "ItemName";
			itemDropDownList.DataValueField = "ItemId";
			itemDropDownList.DataSource = items;
			itemDropDownList.DataBind();
			if (itemDropDownList.SelectedValue!=string.Empty)
			{
				int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
				SetItemData(itemId);
			}

		}
		private void SetItemData( int itemId)
		{
			StockManager stockManager = new StockManager();
			Item item = new Item();
			item = stockManager.GetItem(itemId);
			reorderLabelSet.Text = item.ReorderLevel;
			availableQuantityLabelSet.Text = item.Quantity;


		}

		protected void itemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
			SetItemData(itemId);
		}
	}
}