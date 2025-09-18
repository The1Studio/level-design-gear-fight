using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingMiniBossesConfig
{
	private static ABTestingMiniBossesConfig config;

	public bool useMiniBosses;

	public int miniBossStartingLevel;

	public int numberOfBossesPerFiftyLevels;

	public int[] forcedMiniBossLevels;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingMiniBossesConfig GetConfig()
	{
		return null;
	}
}
