using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Models
{
	public class Catagory
	{
		public Catagory()
		{
		}

		public Catagory(string catagoryName)
		{
			CatagoryName = catagoryName;
		}

		public Catagory(int catagoryId, string catagoryName)
		{
			CatagoryId = catagoryId;
			CatagoryName = catagoryName;
		}

		public int CatagoryId { set; get; }
		public string CatagoryName { set; get; }
	}
}