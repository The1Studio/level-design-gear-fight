using UnityEngine;

namespace Voodoo.Sauce.Privacy.UI
{
	public class PrivacyCanvas : MonoBehaviour, IPrivacyCanvas
	{
		[SerializeField]
		private PrivacyScreen _privacyScreenPrefab;

		[SerializeField]
		private LearnMoreScreen _learnMoreScreenPrefab;

		[SerializeField]
		private ParternsScreen _parternsScreenPrefab;

		[SerializeField]
		private SettingsScreen _settingsScreenPrefab;

		[SerializeField]
		private CmpSettingsScreen _cmpSettingsScreenPrefab;

		[SerializeField]
		private DeleteScreen _deleteScreenPrefab;

		[SerializeField]
		private AccessDataScreen _accessDataScreenPrefab;

		[SerializeField]
		private PopupScreen _popupScreenPrefab;

		[SerializeField]
		private LoadingScreen _loadingScreenPrefab;

		private PrivacyScreen _privacyScreen;

		private LearnMoreScreen _learnMoreScreen;

		private ParternsScreen _parternsScreen;

		private SettingsScreen _settingsScreen;

		private CmpSettingsScreen _cmpSettingsScreen;

		private DeleteScreen _deleteScreen;

		private AccessDataScreen _accessDataScreen;

		private PopupScreen _popupScreen;

		private LoadingScreen _loadingScreen;

		public void OpenPrivacyScreen(PrivacyScreen.Parameters p = null)
		{
		}

		public void ClosePrivacyScreen()
		{
		}

		public void OpenLearnMoreScreen(LearnMoreScreen.Parameters p = null)
		{
		}

		public void CloseLearnMoreScreen()
		{
		}

		public void OpenPartnersScreen(ParternsScreen.Parameters p = null)
		{
		}

		public void CloseParternsScreen()
		{
		}

		public void OpenSettingsScreen(SettingsScreen.Parameters p = null)
		{
		}

		public void CloseSettingsScreen()
		{
		}

		public void OpenCmpSettingsScreen(CmpSettingsScreen.Parameters p = null)
		{
		}

		public void CloseCmpSettingsScreen()
		{
		}

		public void OpenDeleteScreen(DeleteScreen.Parameters p = null)
		{
		}

		public void CloseDeleteScreen()
		{
		}

		public void OpenAccessDataScreen(AccessDataScreen.Parameters p = null)
		{
		}

		public void CloseAccessDataScreen()
		{
		}

		public void OpenPopupScreen(PopupScreen.Parameters p = null)
		{
		}

		public void ClosePopupScreen()
		{
		}

		public void OpenLoadingScreen()
		{
		}

		public void CloseLoadingScreen()
		{
		}
	}
}
