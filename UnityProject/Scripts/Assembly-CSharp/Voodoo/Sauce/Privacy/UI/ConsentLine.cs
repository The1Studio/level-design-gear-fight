using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	public class ConsentLine : MonoBehaviour
	{
		public class Parameters
		{
			public string text;

			public UnityAction buttonAction;

			public bool isChecked;

			public bool isLocked;

			public UnityAction<bool> toggleEvent;
		}

		[SerializeField]
		private SimpleCheckbox _checkbox;

		[SerializeField]
		private TextMeshProUGUI _text;

		[SerializeField]
		private Button _button;

		public void Initialize(Parameters p)
		{
		}

		public bool IsChecked()
		{
			return false;
		}

		public void AddButtonListener(UnityAction action)
		{
		}
	}
}
