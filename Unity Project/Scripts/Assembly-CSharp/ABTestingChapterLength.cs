using System;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingChapterLength
{
	private static ABTestingChapterLength config;

	public static int[] levelOffsets;

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingChapterLength GetConfig()
	{
		return null;
	}
}
