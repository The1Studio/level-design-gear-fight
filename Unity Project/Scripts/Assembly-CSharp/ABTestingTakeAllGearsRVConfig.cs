using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingTakeAllGearsRVConfig
{
	private static ABTestingTakeAllGearsRVConfig config;

	public float frequencyOfBeingShown;

	public int minFightsBetweenBeingShownAgain;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingTakeAllGearsRVConfig GetConfig()
	{
		return null;
	}
}
