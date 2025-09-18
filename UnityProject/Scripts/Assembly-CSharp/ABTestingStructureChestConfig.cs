using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingStructureChestConfig
{
	private static ABTestingStructureChestConfig config;

	public bool useStructureChests;

	public int structureChestStartingLevel;

	public int structureChestsPerFiftyLevels;

	public int[] forcedStructureChestLevels;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingStructureChestConfig GetConfig()
	{
		return null;
	}
}
