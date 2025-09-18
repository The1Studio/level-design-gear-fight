using System;
using System.Collections.Generic;
using GearGame.SingleLoad;

namespace SaveSystem
{
	public class GameSaveConverter : IGameSaveConverter
	{
		public void ConvertToSaveData()
		{
		}

		private DateTime GetDateTimeFromString(string str)
		{
			return default(DateTime);
		}

		private void HandleBlessingsSave(KeyValuePair<string, object> kvp)
		{
		}

		private Dictionary<string, object> GetSaveObjects()
		{
			return null;
		}

		private List<WorldMetaLockManager.UnlockDetail> GetUnlockDetailsFromString(string str)
		{
			return null;
		}

		public void TryRestoreScriptableGears()
		{
		}
	}
}
