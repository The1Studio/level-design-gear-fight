using System;
using Core.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Settings
{
	public class ConfirmationPopup : Popup
	{
		[SerializeField]
		private TextMeshProUGUI _message;

		[SerializeField]
		private Button _confirmButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Sprite _dangerousChoiceSprite;

		public void Init(string message, (string, Action) onConfirm, (string, Action) onCancel)
		{
		}

		private void SetButtonData(Button button, (string, Action) buttonData)
		{
		}

		public void SetDangerousChoice()
		{
		}

		protected override void OnClose()
		{
		}
	}
}
