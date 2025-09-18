namespace Voodoo.Live
{
	public class VirtualCurrencyPrice : IPrice
	{
		public string currencyType { get; set; }

		public int amount { get; set; }

		public string type { get; set; }
	}
}
