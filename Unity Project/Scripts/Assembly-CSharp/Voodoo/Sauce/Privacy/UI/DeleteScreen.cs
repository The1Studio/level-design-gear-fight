using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(GraphicRaycaster))]
	[RequireComponent(typeof(Canvas))]
	public class DeleteScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string title;

			public string intro;

			public string emailTitle;

			public string idfaTitle;

			public string idfa;

			public string idfvTitle;

			public string idfv;

			public string deleteText;

			public UnityAction<string> deleteCallback;

			public string closeText;

			public UnityAction closeCallback;
		}

		[SerializeField]
		private TextMeshProUGUI _title;

		[SerializeField]
		private TextMeshProUGUI _intro;

		[SerializeField]
		private TextMeshProUGUI _emailTitle;

		[SerializeField]
		private TMP_InputField _email;

		[SerializeField]
		private TextMeshProUGUI _idfaTitle;

		[SerializeField]
		private TMP_InputField _idfa;

		[SerializeField]
		private TextMeshProUGUI _idfvTitle;

		[SerializeField]
		private TMP_InputField _idfv;

		[SerializeField]
		private Button _deleteButton;

		[SerializeField]
		private TextMeshProUGUI _deleteText;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private TextMeshProUGUI _closeText;

		private UnityAction<string> _deleteCallback;

		public void Initialize(Parameters p)
		{
		}

		private void RequestDelete()
		{
		}
	}
}
