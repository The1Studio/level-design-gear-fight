using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(Canvas))]
	[RequireComponent(typeof(GraphicRaycaster))]
	public class PrivacyScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string title;

			public string intro;

			public string outro;

			public string advertisingText;

			public UnityAction advertisingAction;

			public bool advertisingDefaultValue;

			public bool advertisingActive;

			public string analyticsText;

			public UnityAction analyticsAction;

			public bool analyticsDefaultValue;

			public bool analyticsActive;

			public string ageText;

			public UnityAction ageAction;

			public bool ageDefaultValue;

			public string accept;

			public UnityAction<PrivacyConsent> acceptCallback;

			public string learnMore;

			public UnityAction learnMoreAction;

			public bool automaticallyAccept;

			public bool isSeparatorsActive;
		}

		[SerializeField]
		private TextMeshProUGUI _title;

		[SerializeField]
		private TextMeshProUGUI _intro;

		[SerializeField]
		private TextMeshProUGUI _outro;

		[SerializeField]
		private ConsentLine _advertising;

		[SerializeField]
		private ConsentLine _analytics;

		[SerializeField]
		private ConsentLine _age;

		[SerializeField]
		private TextMeshProUGUI _acceptText;

		[SerializeField]
		private Button _acceptButton;

		[SerializeField]
		private TextMeshProUGUI _learnMore;

		[SerializeField]
		private Button _learnMoreButton;

		[SerializeField]
		private ScrollRect _body;

		[SerializeField]
		private Image _scrollbarHandle;

		[SerializeField]
		private GameObject[] _separators;

		private UnityAction<PrivacyConsent> _acceptCallback;

		public void Initialize(Parameters p)
		{
		}

		private void AcceptPrivacy()
		{
		}
	}
}
