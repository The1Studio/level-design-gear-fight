using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingGetAllGearsRVConfig
{
	private static ABTestingGetAllGearsRVConfig config;

	public bool showInAllPremiumShopsAlso;

	public float lowHPFactor;

	public float troopsGotPastFactor;

	public float baselinePercentChance;

	public int minTurnToShow;

	public int minLevelToShow;

	public int minFightsBetweenShowing;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingGetAllGearsRVConfig GetConfig()
	{
		return null;
	}
}
