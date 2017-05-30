using System.Threading.Tasks;
namespace Maraes.Services.Interfaces
{
	public interface IDialogService
	{
		Task ShowAlertAsync(string message, string title, string buttonLabel);
	}
}
