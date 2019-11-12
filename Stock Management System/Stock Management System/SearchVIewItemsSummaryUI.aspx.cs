using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using Stock_Management_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;




namespace Stock_Management_System
{
	public partial class SearchVIewItemsSummaryUI : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
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

        protected void printReportButton_Click(object sender, EventArgs e)
        {
            int columnsCount = itemSuumaryGridView.HeaderRow.Cells.Count;
            // Create the PDF Table specifying the number of columns

            PdfPTable pdfTable = new PdfPTable(columnsCount);

            foreach (TableCell gridViewHeaderCell in itemSuumaryGridView.HeaderRow.Cells)
            {
                Font font = new Font();
                font.Color = new BaseColor(itemSuumaryGridView.HeaderStyle.ForeColor);

                PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));

                pdfCell.BackgroundColor = new BaseColor(itemSuumaryGridView.HeaderStyle.BackColor);

                pdfTable.AddCell(pdfCell);
            }

            foreach (GridViewRow gridViewRow in itemSuumaryGridView.Rows)
            {
                if (gridViewRow.RowType == DataControlRowType.DataRow)
                {
                    foreach (TableCell gridViewCell in gridViewRow.Cells)
                    {
                        Font font = new Font();
                        font.Color = new BaseColor(itemSuumaryGridView.RowStyle.ForeColor);

                        PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                        pdfCell.BackgroundColor = new BaseColor(itemSuumaryGridView.RowStyle.BackColor);

                        pdfTable.AddCell(pdfCell);
                    }
                }
            }

            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(pdfTable);
            pdfDocument.Close();

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition",
                "attachment;filename=Employees.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();

        }
    }
}