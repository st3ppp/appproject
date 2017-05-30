using System.Threading.Tasks;
using Maraes.Models.Users;

namespace Maraes.Services.Interfaces
{
	public interface IProfileService
	{
		Task<UserProfile> GetCurrentProfileAsync();

		Task<UserAndProfileModel> SignUp(UserAndProfileModel profile);

		Task UploadUserImageAsync(UserProfile profile, string imageAsBase64);
	}
}
