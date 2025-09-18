using System;

namespace Voodoo.Live.Sample.Utils
{
	public static class InventorySystem
	{
		public static Action<int> OnCoinsChanged;

		public static Action<int> OnTicketsChanged;

		private const string INVENTORY_COINS_KEY = "coins_key";

		private const string INVENTORY_TICKETS_KEY = "tickets_key";

		private static int _coinsAmount;

		private static int _ticketsAmount;

		private static int CoinsAmount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private static int TicketsAmount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		static InventorySystem()
		{
		}

		public static void AddCoins(int amount)
		{
		}

		public static void AddTickets(int amount)
		{
		}

		public static int GetCoins()
		{
			return 0;
		}

		public static int GetTickets()
		{
			return 0;
		}

		private static void SaveInventory()
		{
		}
	}
}
