using Core.UI;
using GearGame.UI;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Settings
{
	public class LanguagePopUp : Popup
	{
		[SerializeField]
		private Transform _contentRoot;

		[SerializeField]
		private LanguageSelectionButton _languageSelectionButtonPrefab;

		[SerializeField]
		private ScrollRect _scrollRect;

		private bool _isInitialized;

		private string _selectedLanguage;

		private UISettingsMenuController _settingsMenu;

		private ConfirmationPopup _confirmationPopup;

		public void Open(UISettingsMenuController settingsMenuController)
		{
		}

		private void Initialize()
		{
		}

		private void OnLanguageButtonClicked(string languageID)
		{
		}

		private void OnConfirmButtonClicked()
		{
		}

		private void OnCancelButtonClicked()
		{
		}
	}
}
