using Stock_Management_System.DAL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.BLL
{
	public class UserManager
	{
		UserGateway gateway = new UserGateway();
		public bool isExistUseer(User user)
		{
			return gateway.Existuser(user);
		}
	}
}