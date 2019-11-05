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
    public partial class CatagorySetupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			ShowAllCatagories();

		}

		protected void catagorySaveButton_Click(object sender, EventArgs e)
		{
			string catagoryName = catagoryId.Value;
			Catagory catagory = new Catagory(catagoryName);
			string message=InsertCatagroy(catagory);
			messageLabel.Text = message;
			ShowAllCatagories();
		}

		private string InsertCatagroy(Catagory catagory)
		{
			CatagoryManager catagoryManager = new CatagoryManager();
			return catagoryManager.Insertcatagory(catagory);
			
		}
		private void ShowAllCatagories()
		{
			CatagoryManager catagoryManager = new CatagoryManager();
			List<Catagory> catagories = new List<Catagory>();
			catagories = catagoryManager.GetCatagories();
			catagoryGridView.DataSource = catagories;
			catagoryGridView.DataBind();
		}
	}
}