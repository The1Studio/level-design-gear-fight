using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingIapOffer
{
	public enum TroopOfferType
	{
		None = 0,
		A = 1,
		B = 2
	}

	private static ABTestingIapOffer config;

	public TroopOfferType TroopOffer;

	public bool SpecialOfferEnabled;

	public static void Init()
	{
	}

	public static ABTestingIapOffer GetConfig()
	{
		return null;
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}
}
