using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
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

		protected void saveButton_Click(object sender, EventArgs e)
		{

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
			itemDropDownList.Items.Clear();
			items = stockManager.GetAllItemOfTheCompany(companyId);
			itemDropDownList.DataTextField = "ItemName";
			itemDropDownList.DataValueField = "ItemId";
			itemDropDownList.DataSource = items;
			itemDropDownList.DataBind();
		}
	}
}