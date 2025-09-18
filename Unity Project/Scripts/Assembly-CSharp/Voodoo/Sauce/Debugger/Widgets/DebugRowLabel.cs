using TMPro;
using UnityEngine;

namespace Voodoo.Sauce.Debugger.Widgets
{
	public class DebugRowLabel : Widget
	{
		[SerializeField]
		private TextMeshProUGUI rowName;

		[SerializeField]
		private TextMeshProUGUI rowValuePrefab;

		[SerializeField]
		private Transform rowValuesParent;

		public void SetRowName(string text)
		{
		}

		public void AddRows(string[] texts)
		{
		}
	}
}
