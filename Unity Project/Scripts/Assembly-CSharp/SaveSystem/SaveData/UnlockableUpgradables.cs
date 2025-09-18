using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class UnlockableUpgradables : ServerBaseData
	{
		[Serializable]
		public class UnlockableUpgradableData
		{
			public int Level;

			public bool IsUnlocked;

			public bool Evolved;

			public int StartingLevel;

			public void IncrementLevel()
			{
			}
		}

		public Dictionary<string, UnlockableUpgradableData> UnlockableUpgradablesData;

		public UnlockableUpgradableData GetOrCreateUnlockableUpgradableData(string id)
		{
			return null;
		}
	}
}
