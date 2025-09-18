using System;
using Gameplay.Blessings;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class BlessingsData : ServerBaseData
	{
		public bool UnlimitedBlessings;

		public BlessingData[] Blessings;
	}
}
