using GearGame.Control;
using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestSO", menuName = "Quest System/Quest")]
public class QuestSO : ScriptableObject
{
	public string ID;

	[ReadOnly]
	public int GoalTag;

	[Dropdown("GetGoalTypeList")]
	[OnValueChanged("OnValidate")]
	public string GoalType;

	[Dropdown("GetGoalEntityTypeList")]
	[ShowIf("IsEntityGoal")]
	public string GoalEntityType;

	[ShowIf("IsCollectableGoal")]
	[Dropdown("GetGoalCollectableTypeList")]
	public string GoalCollectableType;

	[ShowIf("IsActionGoal")]
	[Dropdown("GetGoalActionTypeList")]
	public string GoalActionType;

	public int GoalAmount;

	[Dropdown("GetLocalizationKeysList")]
	public string Description;

	public CurrencySO RewardCurrency;

	public int Reward;

	internal static string[] GoalTypeList;

	public bool IsEntityGoal => false;

	public bool IsCollectableGoal => false;

	public bool IsActionGoal => false;

	public bool HasSubType => false;

	static QuestSO()
	{
	}

	public string GetQuestFormattedDescription()
	{
		return null;
	}

	public int GetQuestSubType()
	{
		return 0;
	}

	public string GetQuestUniqueTag()
	{
		return null;
	}

	private static void UpdateGoalTypeList()
	{
	}

	private string[] GetGoalTypeList()
	{
		return null;
	}

	private string[] GetGoalEntityTypeList()
	{
		return null;
	}

	private string[] GetGoalCollectableTypeList()
	{
		return null;
	}

	private string[] GetGoalActionTypeList()
	{
		return null;
	}

	private string[] GetLocalizationKeysList()
	{
		return null;
	}

	internal bool HasBeenClaimed()
	{
		return false;
	}

	internal void ClaimReward()
	{
	}

	internal bool IsCompleted()
	{
		return false;
	}

	internal int GetProgression()
	{
		return 0;
	}

	internal void SetQuestNotified()
	{
	}

	internal bool HasBeenNotified()
	{
		return false;
	}

	internal void ResetProgression()
	{
	}

	internal void AddProgression(int amount)
	{
	}
}
