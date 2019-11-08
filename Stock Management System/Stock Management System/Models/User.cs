using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Models
{
	public class User
	{
		public User()
		{
		}

		public User(string userName, string password)
		{
			UserName = userName;
			Password = password;
		}

		public User(int userId, string userName, string password)
		{
			UserId = userId;
			UserName = userName;
			Password = password;
		}

		public int UserId { set; get; }
		public string UserName { set; get; }
		public string Password { set; get; }
	}
}