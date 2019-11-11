using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.BLL
{
	public class CompanyManager
	{
		CompanyGateway companyGateway = new CompanyGateway();
		public string InsertCompany(string name)
		{
			if (companyGateway.isExistCompany(name))
			{
				return "Company name already exist.";
			}
			else
			{
				if (companyGateway.InsertComapny(name))
				{
					return "Succesfully setup Company";
				}
				else
				{
					return "Cannot save the Company.";
				}
			}
		}
		public List<Company> GetAllCompanies()
		{
			return companyGateway.GetAllCompanies();
		}

        public void UpdateCompanyName(int companyId, string companyName)
        {
            companyGateway.UpdateCompany(companyId,companyName);
        }
	}
}