using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABHapticFeedback
{
	private static ABHapticFeedback _config;

	public bool IsEnabled;

	public static void Init()
	{
	}

	public static ABHapticFeedback GetConfig()
	{
		return null;
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}
}
