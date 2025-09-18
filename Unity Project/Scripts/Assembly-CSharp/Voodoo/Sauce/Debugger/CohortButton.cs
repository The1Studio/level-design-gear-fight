using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class CohortButton : Widget
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private TextMeshProUGUI titleText;

		public void SetTitleText(string text)
		{
		}

		public void SetOnClickListener(UnityAction onClickAction)
		{
		}
	}
}
