using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(GraphicRaycaster))]
	[RequireComponent(typeof(Canvas))]
	public class SettingsScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string title;

			public string intro;

			public bool advertisingValue;

			public string advertising;

			public IEnumerable<string> advertisingUrls;

			public bool analyticsValue;

			public string analytics;

			public IEnumerable<string> analyticsUrls;

			public UnityAction privacyPolicyAction;

			public string privacyPolicyText;

			public UnityAction accessDataAction;

			public string accessDataText;

			public UnityAction deleteDataCallback;

			public string deleteDataText;

			public UnityAction<PrivacyUpdate> saveAction;

			public string saveText;

			public UnityAction closeCallback;

			public string closeText;
		}

		[SerializeField]
		private TextMeshProUGUI _titleText;

		[SerializeField]
		private TextMeshProUGUI _introText;

		[SerializeField]
		private SimpleCheckbox _advertisingCheckbox;

		[SerializeField]
		private TextMeshProUGUI _advertisingText;

		[SerializeField]
		private Transform _advertisingContent;

		[SerializeField]
		private SimpleCheckbox _analyticsCheckbox;

		[SerializeField]
		private TextMeshProUGUI _analyticsText;

		[SerializeField]
		private Transform _analyticsContent;

		[SerializeField]
		private Button _privacyPolicyButton;

		[SerializeField]
		private TextMeshProUGUI _privacyPolicyButtonText;

		[SerializeField]
		private Button _accessDataButton;

		[SerializeField]
		private TextMeshProUGUI _accessDataButtonText;

		[SerializeField]
		private Button _deleteDataButton;

		[SerializeField]
		private TextMeshProUGUI _deleteDataButtonText;

		[SerializeField]
		private Button _saveButton;

		[SerializeField]
		private TextMeshProUGUI _saveButtonText;

		[SerializeField]
		private Image _saveButtonImage;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private TextMeshProUGUI _closeButtonText;

		[SerializeField]
		private Image[] _scrollbarHandles;

		[SerializeField]
		private PrivacyPolicyElement _privacyPolicyElementPrefab;

		private UnityAction<PrivacyUpdate> _saveAction;

		public void Initialize(Parameters p)
		{
		}

		private void SavePrivacy()
		{
		}

		private void InstantiatePrivacyPolicyElements(Transform content, IEnumerable<string> texts)
		{
		}
	}
}
