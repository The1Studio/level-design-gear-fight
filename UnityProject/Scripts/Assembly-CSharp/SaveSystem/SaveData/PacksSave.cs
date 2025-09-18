using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class PacksSave : ServerBaseData
	{
		public class PackData
		{
			public bool IsUnlocked;

			public int XP;

			public int Level;

			public int XPPending;
		}

		public string ActivePackID;

		public Dictionary<string, PackData> Packs;

		public Dictionary<string, bool> UnlockPacks;

		public PackData GetOrCreatePackData(string id)
		{
			return null;
		}

		public void RemovePack(string id)
		{
		}

		public void UnlockPack(string id)
		{
		}

		public bool IsPackUnlocked(string id)
		{
			return false;
		}

		public void RemoveUnlockPack(string id)
		{
		}
	}
}
