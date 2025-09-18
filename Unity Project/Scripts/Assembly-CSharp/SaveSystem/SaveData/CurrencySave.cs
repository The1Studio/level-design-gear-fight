using System;
using System.Collections.Generic;
using Items;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class CurrencySave : ServerBaseData
	{
		[Serializable]
		public class ScriptableCurrencyData
		{
			public double Value;

			public bool HasGot;

			public bool RanOut;
		}

		public Dictionary<string, double> CurrencyValues;

		public Dictionary<string, ScriptableCurrencyData> ScriptableCurrency;

		public Dictionary<string, string> CurrencyRewardsEvents;

		public Dictionary<ItemNames, CurrencySerializer> Currencies;

		public void IncrementCurrencyValue(string id, double value = 1.0)
		{
		}

		public double GetCurrencyValue(string id)
		{
			return 0.0;
		}

		public ScriptableCurrencyData GetOrCreateScriptableCurrency(string id)
		{
			return null;
		}

		public string GetCurrencyRewardEvent(string id)
		{
			return null;
		}

		public void SetCurrencyRewardEvent(string id, string value)
		{
		}

		public void DeleteCurrencyKey(string id)
		{
		}

		public void DeleteCurrencyRewardKey(string id)
		{
		}
	}
}
