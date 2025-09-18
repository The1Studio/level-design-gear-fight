using System;
using System.Collections.Generic;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class RVValues
	{
		public Dictionary<string, int> RVEngagements;

		public void IncrementRVEngagement(string id)
		{
		}

		public int GetRVEngagement(string id)
		{
			return 0;
		}
	}
}
