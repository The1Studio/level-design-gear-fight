using Core.UI;
using TMPro;
using UnityEngine;

namespace GearGame.UI
{
	public class UISettingsMenuController : Popup
	{
		[SerializeField]
		private GameObject inGameEndRun;

		[SerializeField]
		private GameObject restorePurchasesRoot;

		[SerializeField]
		private Animator restorePurchasesAnimator;

		[Header("Localization")]
		[SerializeField]
		private TextMeshProUGUI _languageButtonText;

		[SerializeField]
		private CloudSettingsUI _cloudSettingsUI;

		protected void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Activate(bool isIngame)
		{
		}

		public void RefreshCloudSettings()
		{
		}

		public void OnExitButtonPressed()
		{
		}

		public void OpenGDPR()
		{
		}

		public void OpenDiscord()
		{
		}

		public void OnLanguageButtonPressed()
		{
		}

		public void OnRestorePurchasesPressed()
		{
		}

		private void RestoreCompleted(RestorePurchasesResult result)
		{
		}

		public void ExitGame()
		{
		}
	}
}
