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
	public partial class CompanySetUpUi : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ShowAllCOmpanies();

		}

		protected void saveButton_Click(object sender, EventArgs e)
		{
			string companyName = inputCompanyName.Value;
			string message = SetupCOmpnay(companyName);
			messageLabel.Text = message;
			if(message== "Succesfully setup Company")
			{
				messageLabel.ForeColor = Color.Green;
				
			}
			else
			{
				messageLabel.ForeColor = Color.Red;
			}
			ShowAllCOmpanies();
			inputCompanyName.Value = string.Empty;
		}

		private string SetupCOmpnay(string companyName)
		{
			CompanyManager companyManager = new CompanyManager();
			return companyManager.InsertCompany(companyName);
		}
		private void ShowAllCOmpanies()
		{
			CompanyManager companyManager = new CompanyManager();
			List<Company> companies = new List<Company>();
		    companies=companyManager.GetAllCompanies();
			companyGridView.DataSource = companies;
			companyGridView.DataBind();
		}
	}
}