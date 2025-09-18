using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestGroupSO", menuName = "Quest System/Quest Group")]
public class QuestGroupSO : ScriptableObject
{
	private string ID;

	public QuestGroupType QuestGroupType;

	public List<QuestSO> Quests;

	internal void ResetData()
	{
	}

	internal int GetGroupMaxProgression()
	{
		return 0;
	}

	internal int GetGroupCurrentProgression()
	{
		return 0;
	}

	internal float GetGroupProgression()
	{
		return 0f;
	}

	internal List<QuestSO> AddQuestProgress(QuestGoalTypeTag goalType, int amount, int subType)
	{
		return null;
	}

	internal bool TryClaimQuest(QuestSO data)
	{
		return false;
	}
}
