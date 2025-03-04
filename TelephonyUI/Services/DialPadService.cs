using Radzen;
using TelephonyUI.Shared.Components._HomePage.CallPopUps;

namespace TelephonyUI.Services
{
	public class DialPadService
	{
		private readonly DialogService _dialogService;

		public DialPadService(DialogService dialogService)
		{
			_dialogService = dialogService;
		}

		public void OpenDialPad()
		{
			_dialogService.Open<DialPadDialog>(
				title: "",         // Title in the popup
				parameters: new Dictionary<string, object>()
				{
					// Pass any data you want as parameters here
				},
				options: new DialogOptions()
				{
					Width = "350px",       // Customize size
					Height = "580px",
					CloseDialogOnOverlayClick = true,
					CloseDialogOnEsc = true,
					CssClass = "rz-border-radius-6"
				}
			);
		}
	}
}
