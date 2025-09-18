using System;
using System.Collections.Generic;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class ScriptableLevelData
	{
		[Serializable]
		public class LevelData
		{
			public bool Completed;
		}

		public Dictionary<string, LevelData> LevelsData;

		public LevelData GetOrCreateLevelData(string id)
		{
			return null;
		}
	}
}
