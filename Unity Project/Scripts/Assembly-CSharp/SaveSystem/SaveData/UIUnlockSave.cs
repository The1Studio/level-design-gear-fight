using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class UIUnlockSave : ServerBaseData
	{
		public Dictionary<string, bool> UIAsset;

		public bool IsUnlocked(string assetID)
		{
			return false;
		}

		public void UnlockTab(string tabID)
		{
		}
	}
}
