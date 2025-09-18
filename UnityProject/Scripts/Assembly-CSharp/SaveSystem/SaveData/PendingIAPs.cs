using System;
using System.Collections.Generic;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class PendingIAPs
	{
		public Dictionary<string, int> CurrentPendingIAPs;
	}
}
