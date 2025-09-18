using System.Collections.Generic;
using UnityEngine;

namespace Features.Cheat.Scripts
{
	[CreateAssetMenu(fileName = "CheatSettings", menuName = "Voodoo/Cheat Settings", order = 0)]
	public class CheatSettings : ScriptableObject
	{
		private const string CHEAT_KEY_PREFIX = "Cheat";

		public List<string> Cheats;

		public static void EnableCheat(string cheat, bool enabled)
		{
		}

		public static bool IsCheatEnabled(string cheat)
		{
			return false;
		}
	}
}
