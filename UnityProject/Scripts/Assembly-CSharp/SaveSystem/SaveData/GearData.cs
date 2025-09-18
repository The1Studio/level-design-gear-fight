using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class GearData : ServerBaseData
	{
		public Dictionary<string, int> GearInts;

		public Dictionary<string, string> GearStrings;

		public int LastCheckLevelGearUnlock;

		public bool ShowHideGearsOpen;

		public int GemGearSeed;

		public int FightCooldownForPremiumIncomeGear;

		public int LastShownCustomGearGemGearLevel;

		public void SetGearInt(string id, int value)
		{
		}

		public void IncrementGearInt(string id, int amount = 1)
		{
		}

		public int GetGearInt(string id)
		{
			return 0;
		}

		public void SetGearBool(string id, bool value)
		{
		}

		public bool GetGearBool(string id)
		{
			return false;
		}

		public void SetGearString(string id, string value)
		{
		}

		public string GetGearString(string id)
		{
			return null;
		}

		public bool HasKey(string id)
		{
			return false;
		}

		public void RemoveGearString(string id)
		{
		}
	}
}
