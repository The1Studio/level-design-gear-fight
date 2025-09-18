using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingStarterPackOffer
{
	private static ABTestingStarterPackOffer config;

	public bool Enabled;

	public static void Init()
	{
	}

	public static ABTestingStarterPackOffer GetConfig()
	{
		return null;
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}
}
