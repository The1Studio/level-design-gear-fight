using System.Collections.Generic;
using GearGame.Control;

namespace Items
{
	public class CurrencySystem : ItemSystem<CurrencySO>, ICurrencySaver
	{
		private static CurrencySystem _instance;

		private Dictionary<ItemNames, Currency> _currencyInstances;

		public CurrencySO[] Currencies { get; private set; }

		protected override void Initialize(CurrencySO[] settings)
		{
		}

		public override IEnumerable<Reward> Claim(ItemSO item, double amount, RaritySO rarity)
		{
			return null;
		}

		public void Save(Currency currency)
		{
		}

		public override void Save(IEnumerable<Reward> rewards)
		{
		}

		public override IEnumerable<Reward> GetRewards()
		{
			return null;
		}

		public override void ClearRewards()
		{
		}

		public static CurrencySO Get(ItemNames id)
		{
			return null;
		}

		public static CurrencySO Get(string currencyName)
		{
			return null;
		}

		public override void CancelItemsAnimation()
		{
		}

		public override void SetItemsAnimationtTimeScale(float timeScale)
		{
		}

		public override void OnDataReloaded()
		{
		}

		public static CurrencySO[] GetAllCurrencies()
		{
			return null;
		}
	}
}
