using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(Canvas))]
	[RequireComponent(typeof(GraphicRaycaster))]
	public class PopupScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string title;

			public string message;

			public UnityAction closeCallback;

			public string closeButtonText;
		}

		[SerializeField]
		private TextMeshProUGUI _title;

		[SerializeField]
		private TextMeshProUGUI _message;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private TextMeshProUGUI _closeButtonText;

		private Action _closeCallback;

		public void Initialize(Parameters p)
		{
		}
	}
}
