using System;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingDifficultyConfig
{
	private static ABTestingDifficultyConfig config;

	public float difficultyExponentialScaler;

	public bool useNIVConfig;

	public float additionalTroopsWhenBehindMultiplier;

	public float additionalBrutesWhenBehindMultiplier;

	public float[] customNIVConfiguration;

	public static double[] AllDifficulties;

	public static event Action OnInitialized
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void Init()
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	private static void ParseCustomConfig(float[] values)
	{
	}

	public static ABTestingDifficultyConfig GetConfig()
	{
		return null;
	}
}
