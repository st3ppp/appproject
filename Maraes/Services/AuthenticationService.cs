using System;
using Maraes.Helpers;
using Maraes.Services.Interfaces;
using System.Threading.Tasks;
using Maraes.Models.Users;

namespace Maraes.Services
{
    public class AuthenticationService : IAuthenticationService
    {
		private readonly IRequestProvider _requestProvider;

		public bool IsAuthenticated => !string.IsNullOrEmpty(Settings.AccessToken);

		public AuthenticationService(IRequestProvider requestProvider)
		{
			_requestProvider = requestProvider;
		}

		public async Task<bool> LoginAsync(string userName, string password)
		{
			var auth = new AuthenticationRequest
			{
				UserName = userName,
				Credentials = password,
				GrantType = "password"
			};

            UriBuilder builder = new UriBuilder(GlobalSettings.ApplicationURL);
			builder.Path = "api/login";

			string uri = builder.ToString();

			AuthenticationResponse authenticationInfo = await _requestProvider.PostAsync<AuthenticationRequest, AuthenticationResponse>(uri, auth);
			Settings.UserId = authenticationInfo.UserId;
			Settings.ProfileId = authenticationInfo.ProfileId;
			Settings.AccessToken = authenticationInfo.AccessToken;

			return true;
		}

		public Task LogoutAsync()
		{
			Settings.RemoveUserId();
			Settings.RemoveProfileId();
			Settings.RemoveAccessToken();
			//Settings.RemoveCurrentBookingId();

			return Task.FromResult(false);
		}

		public int GetCurrentUserId()
		{
			return Settings.UserId;
		}
    }
}
