using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.BLL
{
	public class CatagoryManager
	{
		CatagoryGateway catagoryGateway = new CatagoryGateway();
		public string Insertcatagory(Catagory catagory)
		{
            
            if (catagoryGateway.ExistCatagory(catagory))
			{
				return "Already Exist";
			}
			else
			{
				int rowEffect = catagoryGateway.InsertCatagory(catagory);
				if (rowEffect > 0)
				{
					return "Successfully added the catagory";
				}
				else
				{
					return "Cannot add the catagory.";
				}
			}
		}
		public List<Catagory> GetCatagories()
		{
			return catagoryGateway.GetAllCatagories();
		}

        public void UpdateCatagoryName(int catagoryId, string catagoryName)
        {
            catagoryGateway.UpdateCatagory(catagoryId,catagoryName);
        }

	}
}