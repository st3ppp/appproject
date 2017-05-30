using System.Threading.Tasks;

namespace Maraes.Services.Interfaces
{
	public interface IAuthenticationService
	{
		bool IsAuthenticated { get; }

		Task<bool> LoginAsync(string userName, string password);

		Task LogoutAsync();

		int GetCurrentUserId();
	}
}
