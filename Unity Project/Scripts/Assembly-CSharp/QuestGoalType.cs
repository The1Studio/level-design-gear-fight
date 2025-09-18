using System;

[Serializable]
public class QuestGoalType
{
	public static readonly QuestGoalTypeTag WinWithoutDamage;

	public static readonly QuestGoalTypeTag WinUsingOnlyGear1Speed;

	public static readonly QuestGoalTypeTag WinUsingOnlyGear2Speed;

	public static readonly QuestGoalTypeTag ItemCollect;

	public static readonly QuestGoalTypeTag ItemConsume;

	public static readonly QuestGoalTypeTag LevelsWon;

	public static readonly QuestGoalTypeTag LevelUnlock;

	public static readonly QuestGoalTypeTag EntitySpawn;

	public static readonly QuestGoalTypeTag EntityUpgrade;

	public static readonly QuestGoalTypeTag EntityDestroy;

	public static readonly QuestGoalTypeTag RepeatAction;
}
