using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestEvents
{
	public static Action<List<QuestSO>, double> OnQuestUpdate;

	public static Action<List<QuestSO>> OnQuestCompleted;

	public static Action<Vector3, QuestSO> OnQuestClaimed;
}
