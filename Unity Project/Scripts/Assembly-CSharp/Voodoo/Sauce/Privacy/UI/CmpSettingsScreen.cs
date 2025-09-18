using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(Canvas))]
	[RequireComponent(typeof(GraphicRaycaster))]
	public class CmpSettingsScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string title;

			public string intro;

			public UnityAction privacyPolicyAction;

			public string privacyPolicyText;

			public UnityAction accessDataAction;

			public string accessDataText;

			public UnityAction deleteDataCallback;

			public string deleteDataText;

			public UnityAction openCmpSettingsAction;

			public string openCmpSettingsText;

			public UnityAction closeCallback;

			public string closeText;
		}

		[SerializeField]
		private TextMeshProUGUI _titleText;

		[SerializeField]
		private TextMeshProUGUI _introText;

		[SerializeField]
		private Button _privacyPolicyButton;

		[SerializeField]
		private TextMeshProUGUI _privacyPolicyButtonText;

		[SerializeField]
		private Image _privacyPolicyButtonImage;

		[SerializeField]
		private Button _accessDataButton;

		[SerializeField]
		private TextMeshProUGUI _accessDataButtonText;

		[SerializeField]
		private Image _accessDataButtonImage;

		[SerializeField]
		private Button _deleteDataButton;

		[SerializeField]
		private TextMeshProUGUI _deleteDataButtonText;

		[SerializeField]
		private Image _deleteDataButtonImage;

		[SerializeField]
		private Button _openCmpSettingsButton;

		[SerializeField]
		private TextMeshProUGUI _openCmpSettingsButtonText;

		[SerializeField]
		private Image _openCmpSettingsButtonImage;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private TextMeshProUGUI _closeButtonText;

		public void Initialize(Parameters p)
		{
		}
	}
}
