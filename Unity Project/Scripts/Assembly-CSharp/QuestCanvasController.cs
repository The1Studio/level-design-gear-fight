using Core.UI;
using UnityEngine;

public class QuestCanvasController : Core.UI.Screen
{
	[SerializeField]
	private QuestScreen dailyQuestScreen;

	[SerializeField]
	private QuestScreen weeklyQuestScreen;

	protected void Start()
	{
	}

	protected void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void CheckABTestUIelements()
	{
	}

	private void OnQuestClaimed(Vector3 transformOrigin, QuestSO data)
	{
	}
}
