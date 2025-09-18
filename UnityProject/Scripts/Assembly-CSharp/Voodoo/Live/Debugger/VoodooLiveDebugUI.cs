using UnityEngine;
using UnityEngine.Events;

namespace Voodoo.Live.Debugger
{
	public class VoodooLiveDebugUI
	{
		public Label labelPrefab;

		public DebuggerKeyValuePair keyValuePair;

		public DebuggerKeyInputPair keyInputPair;

		public Transform rootObject;

		public Label label;

		public virtual void Init()
		{
		}

		public void CreateValuePair(string key, string value)
		{
		}

		public void CreateInputPair(string key, string value, UnityAction<string> onEdit)
		{
		}
	}
}
