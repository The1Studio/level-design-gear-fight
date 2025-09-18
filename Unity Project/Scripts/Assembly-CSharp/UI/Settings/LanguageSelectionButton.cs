using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Settings
{
	public class LanguageSelectionButton : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _languageText;

		[SerializeField]
		private Button _button;

		private Action _onClick;

		public void Initialize(string language, Action onClick)
		{
		}

		private void OnClick()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
