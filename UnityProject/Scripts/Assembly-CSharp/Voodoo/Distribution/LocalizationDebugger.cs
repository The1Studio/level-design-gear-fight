using UnityEngine;

namespace Voodoo.Distribution
{
	public sealed class LocalizationDebugger : MonoBehaviour
	{
		private const KeyCode _debugKeyForNextLanguage = KeyCode.L;

		private const KeyCode _debugKeyForLongestStringMode = KeyCode.O;

		public bool longestStringModeEnabled;

		private int _forcedIndex;

		private string[] _languageCodes;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
