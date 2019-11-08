using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Models
{
	public class Company
	{
		public Company(string companyName)
		{
			CompanyName = companyName;
		}

		public Company(int comapnyId, string companyName)
		{
			CompanyId = comapnyId;
			CompanyName = companyName;
		}

		public int CompanyId { set; get; }
		public string CompanyName { set; get; }
	}
}