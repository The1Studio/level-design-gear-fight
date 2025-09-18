using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Debugger.Widgets;
using Voodoo.Sauce.IAP;

namespace Voodoo.Sauce.Debugger
{
	public class IAPDebugScreen : Screen
	{
		[SerializeField]
		private TextMeshProUGUI lightMessage;

		[SerializeField]
		private Image errorIcon;

		[SerializeField]
		private TextMeshProUGUI errorMessage;

		[SerializeField]
		private TextMeshProUGUI _iapStatus;

		private DebugToggleButton premiumToggle;

		private DebugTextPair payloadCopyButton;

		private DebugButtonWithInputField restoreButton;

		private IAPDebugManager _manager;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private string GetLatestValidationPayload()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		internal void SetVoodooPremiumToggleState(bool isOn)
		{
		}

		internal void EnableRestoreButton(bool active)
		{
		}

		internal void CreateProductsButtons(List<IAPDebugProduct> products)
		{
		}

		private void ClearMessages()
		{
		}

		internal void DisplayLightMessage(string message)
		{
		}

		internal void DisplayErrorMessage(string message)
		{
		}

		private void OnRestorePurchasesSuccess(RestorePurchasesResult result)
		{
		}

		private void OnIAPStatusUpdate(IAPStatus iapStatus)
		{
		}
	}
}
