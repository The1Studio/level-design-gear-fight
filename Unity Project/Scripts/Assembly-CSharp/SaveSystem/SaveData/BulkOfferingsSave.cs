using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class BulkOfferingsSave : ServerBaseData
	{
		public int ActiveOfferIndex;

		public Dictionary<string, bool> BulkOfferingSave;

		public void SetBulkOfferingBool(string id, bool value)
		{
		}

		public bool GetBulkOfferingBool(string id)
		{
			return false;
		}

		public void ClearBulkOffering()
		{
		}
	}
}
