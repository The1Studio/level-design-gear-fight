using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(Canvas))]
	[RequireComponent(typeof(GraphicRaycaster))]
	public class LearnMoreScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string header;

			public string intro;

			public string game;

			public string ads;

			public string bug;

			public string outro;

			public UnityAction backCallback;

			public string back;
		}

		[SerializeField]
		private TextMeshProUGUI _headerText;

		[SerializeField]
		private Image _bodyScrollbarHandle;

		[SerializeField]
		private TextMeshProUGUI _introText;

		[SerializeField]
		private TextMeshProUGUI _gameText;

		[SerializeField]
		private Image _gameImage;

		[SerializeField]
		private TextMeshProUGUI _adsText;

		[SerializeField]
		private Image _adsImage;

		[SerializeField]
		private TextMeshProUGUI _bugText;

		[SerializeField]
		private Image _bugImage;

		[SerializeField]
		private TextMeshProUGUI _outroText;

		[SerializeField]
		private Button _backButton;

		[SerializeField]
		private TextMeshProUGUI _backButtonText;

		[SerializeField]
		private Image _backButtonImage;

		public void Initialize(Parameters p)
		{
		}
	}
}
