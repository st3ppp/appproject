using System.Threading.Tasks;

namespace Maraes.Services.Interfaces
{
	public interface IMediaPickerService
	{
		Task<string> PickImageAsBase64String();
	}
}
