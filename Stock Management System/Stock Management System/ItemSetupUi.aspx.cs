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
	public partial class ItemSetupUi : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				BindAllCatagory();
				BindAllCompany();
			}
		}

		private void BindAllCompany()
		{
			CompanyManager companyManager = new CompanyManager();
			List<Company> companies = new List<Company>();
			companies = companyManager.GetAllCompanies();
			ddlCompany.DataTextField = "CompanyName";
			ddlCompany.DataValueField = "CompanyId";
			ddlCompany.DataSource = companies;
			ddlCompany.DataBind();
		}

		private void BindAllCatagory()
		{
			CatagoryManager catagoryManager = new CatagoryManager();
			List<Catagory> catagories = new List<Catagory>();
			catagories = catagoryManager.GetCatagories();
			ddlCatagory.DataTextField = "CatagoryName";
			ddlCatagory.DataValueField = "CatagoryId";
			ddlCatagory.DataSource = catagories;
			ddlCatagory.DataBind();
		
		}

		protected void saveButton_Click(object sender, EventArgs e)
		{

			int catagoryId =Convert.ToInt32( ddlCatagory.SelectedValue);
			int companyId =Convert.ToInt32( ddlCompany.SelectedValue);
			string itemName = inputItemName.Value;
			string reorderLevel = inputReorderLevel.Value;
			Item item = new Item(itemName, catagoryId, companyId, reorderLevel);
			InsertItem(item);
			ClearField();
		}

		private void InsertItem(Item item)
		{
			ItemManager itemManager = new ItemManager();
			string message = itemManager.InsertItem(item);
			messageLabel.Text = message;
			if(message== "Successfully setup Item")
			{
				messageLabel.ForeColor = Color.Green;
			}
			else if(message== "Reorder level updated successfully")
			{
				messageLabel.ForeColor = Color.Green;
			}
			else
			{
				messageLabel.ForeColor = Color.Red;

			}
		}
		private void ClearField()
		{
			inputItemName.Value = string.Empty;
			inputReorderLevel.Value = string.Empty;
		}
	}
}