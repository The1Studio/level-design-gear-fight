using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(GraphicRaycaster))]
	[RequireComponent(typeof(Canvas))]
	public class ParternsScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string header;

			public string intro;

			public string advertising;

			public IEnumerable<string> advertisingUrls;

			public string analytics;

			public IEnumerable<string> analyticsUrls;

			public UnityAction backCallback;

			public string back;
		}

		[SerializeField]
		private TextMeshProUGUI _headerText;

		[SerializeField]
		private TextMeshProUGUI _introText;

		[SerializeField]
		private TextMeshProUGUI _advertisingText;

		[SerializeField]
		private Transform _advertisingContent;

		[SerializeField]
		private TextMeshProUGUI _analyticsText;

		[SerializeField]
		private Transform _analyticsContent;

		[SerializeField]
		private Button _backButton;

		[SerializeField]
		private TextMeshProUGUI _backButtonText;

		[SerializeField]
		private Image _backButtonImage;

		[SerializeField]
		private Image _scrollbarHandle;

		[SerializeField]
		private PrivacyPolicyElement _privacyPolicyElementPrefab;

		public void Initialize(Parameters p)
		{
		}

		private void InstantiatePrivacyPolicyElements(Transform content, IEnumerable<string> texts)
		{
		}
	}
}
