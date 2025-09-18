using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class SkillsSave : ServerBaseData
	{
		[Serializable]
		public class SkillData
		{
			public double Value;

			public bool HasGot;
		}

		public Dictionary<string, SkillData> Skills;

		public SkillData GetOrCreateSkillData(string id)
		{
			return null;
		}
	}
}
