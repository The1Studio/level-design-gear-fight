using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingDoubleSpeedConfig
{
	private static ABTestingDoubleSpeedConfig config;

	public int speedUpMinLevelToShow;

	public bool isDiscountedSpeedPrice;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingDoubleSpeedConfig GetConfig()
	{
		return null;
	}
}
