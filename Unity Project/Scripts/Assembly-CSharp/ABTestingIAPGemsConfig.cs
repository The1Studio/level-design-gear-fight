using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingIAPGemsConfig
{
	private static ABTestingIAPGemsConfig config;

	public int[] gemsPerChapter;

	public int gemsPerLevelAfterChapterDrops;

	public bool adTicketsEnabled;

	public int startingLevelToShowDiamondOffersInPremiumShop;

	public float chanceOfDiamondOfferInPremiumShop;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingIAPGemsConfig GetConfig()
	{
		return null;
	}
}
