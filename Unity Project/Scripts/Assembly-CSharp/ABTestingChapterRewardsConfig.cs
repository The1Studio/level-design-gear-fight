using System;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Core;

[Serializable]
public class ABTestingChapterRewardsConfig
{
	private static ABTestingChapterRewardsConfig config;

	public bool chapterRewardsActive;

	public int[] gemsPerChapter;

	public int gemsPerLevelAfterChapterDrops;

	private static event Action<ABTestingChapterRewardsConfig> onInitialized
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

	public static void SubscribeOnInitFinishedEvent(Action<ABTestingChapterRewardsConfig> onInitFinished)
	{
	}

	public static void UnSubscribeOnInitFinishedEvent(Action<ABTestingChapterRewardsConfig> onInitFinished)
	{
	}

	private static void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
	{
	}

	public static ABTestingChapterRewardsConfig GetConfig()
	{
		return null;
	}
}
