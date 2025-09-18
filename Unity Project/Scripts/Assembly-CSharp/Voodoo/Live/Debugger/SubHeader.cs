using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Live.Debugger
{
	public class SubHeader : MonoBehaviour
	{
		[SerializeField]
		protected TextMeshProUGUI _subHeaderCountText;

		[SerializeField]
		protected Transform _subHeaderArrowTR;

		[SerializeField]
		protected Toggle _toggleBtn;

		[Header("Prefabs")]
		public Label labelPrefab;

		public DebuggerKeyValuePair keyValuePair;

		public DebuggerKeyInputPair keyInputPair;

		protected readonly List<VoodooLiveDebugUI> LiveDebugUis;

		public void Init()
		{
		}

		private void OnValueChanged(bool value)
		{
		}
	}
}
