﻿using System;
namespace Maraes.Models.Users
{
    public class AuthenticationRequest
    {
		public string UserName { get; set; }

		public string Credentials { get; set; }

		public string GrantType { get; set; }
    }
}
