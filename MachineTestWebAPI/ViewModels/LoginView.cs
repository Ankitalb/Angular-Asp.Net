using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineTestWebAPI.ViewModels
{
	public class LoginView
	{

		public LoginView()
		{

		}

		public LoginView(decimal lId, string username, string password, string userType)
		{
			LId = lId;
			Username = username;
			Password = password;
			UserType = userType;
		}

		public decimal? LId{ get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string? UserType { get; set; }

	}
}
