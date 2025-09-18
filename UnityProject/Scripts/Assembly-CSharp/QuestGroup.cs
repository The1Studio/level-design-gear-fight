using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QuestGroup
{
	[Tooltip("Type of quest group, defined by duration")]
	public QuestGroupType GroupType;

	[Tooltip("Groups of individual quests, this list will be looped through.")]
	public List<QuestGroupSO> QuestGroups;

	private SavedDateTime CurrentStartDate;

	private SavedInt CurrentIndex;

	private SavedInt CurrentProgress;

	private TimeSpan remainingTimeSpan;

	internal int GetCurrentMaxProgress => 0;

	internal int GetCurrentProgress => 0;

	public void Setup()
	{
	}

	public void ResetAllGroups()
	{
	}

	public void ResetGroupProgressionIndex()
	{
	}

	internal QuestGroupSO GetCurrentGroup()
	{
		return null;
	}

	internal void AdvanceQuestGroup()
	{
	}

	internal void AddProgress(int amount)
	{
	}

	internal bool CheckTimer()
	{
		return false;
	}

	internal void TryClaimQuest(QuestSO data, Transform source)
	{
	}

	internal TimeSpan GetRemainingTime()
	{
		return default(TimeSpan);
	}

	internal void AdvanceOneDay()
	{
	}

	internal void AdvanceOneHour()
	{
	}

	internal void SetToOneMinute(int secs = 60)
	{
	}
}
