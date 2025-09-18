using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingTroopPackOffer
{
	public enum TroopOfferType
	{
		None = 0,
		ThreeDays = 1,
		SingleDay = 2
	}

	public TroopOfferType[] TroopOffer;

	private static ABTestingTroopPackOffer config;

	public TroopOfferType OfferType => default(TroopOfferType);

	public static void Init()
	{
	}

	public static ABTestingTroopPackOffer GetConfig()
	{
		return null;
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}
}
