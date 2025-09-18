using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestScreen : MonoBehaviour
{
	public QuestGroupType QuestType;

	public QuestItem QuestItemPrefab;

	public Transform QuestItemsParent;

	public TextMeshProUGUI QuestGroupProgress;

	public TextMeshProUGUI QuestTimerText;

	public UIProgressBar QuestGroupProgressFill;

	public string LocalizationString;

	private List<QuestItem> QuestItems;

	private string finalLocalization;

	private QuestGroupSO quests;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void QuestsUpdated(List<QuestSO> questsUpdated, double amount)
	{
	}

	private void OnDestroy()
	{
	}

	public void Fill()
	{
	}

	private void UpdateQuestGroupProgress()
	{
	}

	private void Update()
	{
	}

	internal void Open()
	{
	}

	internal void Close()
	{
	}
}
