using System;
using System.Collections.Generic;
using GearGame.SingleLoad;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class MetaSave : ServerBaseData
	{
		public Dictionary<string, string> StringsDictionary;

		public List<WorldMetaLockManager.UnlockDetail> UnlockDetails;

		public string GetString(string key)
		{
			return null;
		}

		public void SetString(string key, string value)
		{
		}
	}
}
