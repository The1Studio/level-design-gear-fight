using System.Threading.Tasks;
using UnityEngine.Events;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Privacy.UI
{
	public interface IPrivacyUIManager
	{
		void Initialize(IPrivacyUIManagerParameters p);

		Task<PrivacyConsent> GetPrivacyConsent();

		void OpenSettingsScreen(bool adsConsent, bool analyticsConsent, bool idfaAuthorizationStatusDeniedOrRestricted, DataScreenInfo dataInfo, UnityAction<PrivacyUpdate> updatePrivacy, UnityAction<string> deleteData, UnityAction<UserDetails> accessData, UnityAction tryOpenDebugger, UnityAction closeSettingsScreen);

		void CloseSettingsScreen();

		void OpenCmpSettingsScreen(bool idfaAuthorizationStatusDeniedOrRestricted, DataScreenInfo dataInfo, UnityAction openCmpSettings, UnityAction<string> deleteData, UnityAction<UserDetails> accessData, UnityAction tryOpenDebugger, UnityAction closeSettingsScreen);

		void CloseCmpSettingsScreen();

		void CloseDeleteScreen();

		void CloseAccessDataScreen();

		void ClosePopupScreen();

		void OpenPrivacyNotInitializedPopupScreen(UnityAction closeCallback, VoodooSettings voodooSettings, IPrivacyCanvas privacyCanvas);

		void OpenUpdatePrivacySuccessPopupScreen(UnityAction closeCallback);

		void OpenUpdatePrivacyErrorPopupScreen(UnityAction closeCallback);

		void OpenSuccessPopupScreen(UnityAction closeCallback);

		void OpenErrorPopupScreen(string errorMessage, UnityAction closeCallback);

		void OpenConnexionErrorPopupScreen(UnityAction closeCallback);

		void OpenEmailErrorPopupScreen(UnityAction closeCallback);

		void OpenLoadingScreen();

		void CloseLoadingScreen();
	}
}
