using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingGemGears
{
	private static ABTestingGemGears config;

	public bool useGemGears;

	public int gemGearStartingLevel;

	public int numberOfGemGearsPerFiftyLevels;

	public int fightsBetweenShowingPremiumIncomeGear;

	public int thresholdForPremiumIncomeGear;

	public int numberOfGearsThatWeCanAffordThreshold;

	public float chanceOfPremiumGear;

	public int[] forcedGemGearLevels;

	public string[] potentialGearGUIDS;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingGemGears GetConfig()
	{
		return null;
	}
}
