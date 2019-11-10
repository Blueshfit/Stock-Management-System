using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using Stock_Management_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System
{
	public partial class SearchVIewItemsSummaryUI : System.Web.UI.Page
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
				BindAllCatagory();
			}

		}
        private void BindAllCatagory()
		{
			CatagoryManager catagoryManager = new CatagoryManager();
			List<Catagory> catagories = new List<Catagory>();
			catagories = catagoryManager.GetCatagories();
			catagoryDDL.DataTextField = "CatagoryName";
			catagoryDDL.DataValueField = "CatagoryId";
			catagoryDDL.DataSource = catagories;
			catagoryDDL.DataBind();

		}

		private void BindAllCompany()
		{
			CompanyManager companyManager = new CompanyManager();
			List<Company> companies = new List<Company>();
			companies = companyManager.GetAllCompanies();
			companyDDL.DataTextField = "CompanyName";
			companyDDL.DataValueField = "CompanyId";
			companyDDL.DataSource = companies;
			companyDDL.DataBind();
			
		}

		protected void searchButton_Click(object sender, EventArgs e)
		{
			Item item = new Item();
			item.ComapnyId =Convert.ToInt32( companyDDL.SelectedValue);
			item.CatagoryId= Convert.ToInt32(catagoryDDL.SelectedValue);
			SearchAllItem(item);
			
			

		}

		private void SearchAllItem(Item item)
		{
			ItemManager itemManager = new ItemManager();
			List<CatagoryCompanyWISeItemView> items = new List<CatagoryCompanyWISeItemView>();
			items = itemManager.GetAllItems(item);
			itemSuumaryGridView.DataSource = items;
			itemSuumaryGridView.DataBind();
		}
	}
}