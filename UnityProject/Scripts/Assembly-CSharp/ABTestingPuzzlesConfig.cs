using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingPuzzlesConfig
{
	public enum PuzzleConfigs
	{
		Control = 0,
		More = 1,
		Many = 2
	}

	private static ABTestingPuzzlesConfig config;

	public PuzzleConfigs PuzzleConfigValue;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingPuzzlesConfig GetConfig()
	{
		return null;
	}
}
