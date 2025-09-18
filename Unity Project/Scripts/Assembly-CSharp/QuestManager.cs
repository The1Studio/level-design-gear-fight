using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Core.Event;
using GearGame.Control;
using GearGame.Gameplay.UI.Pregame;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckTimers_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public QuestManager _003C_003E4__this;

		public CancellationTokenSource cancellation;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLaunchNotificationsAsync_003Ed__94 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<QuestSO> totalQuestsUpdated;

		public QuestManager _003C_003E4__this;

		public CancellationTokenSource cancellation;

		public int amount;

		private List<QuestSO>.Enumerator _003C_003E7__wrap1;

		private QuestSO _003Cquest_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const string QUESTS_LIST_SEPARATOR = "(##:qst:##)";

	private const string QUESTS_LAST_TIME_OPENED_KEY = "Quests_lastTime_launched";

	private static QuestManager instance;

	[SerializeField]
	private bool notificationsEnabled;

	[SerializeField]
	private QuestNotificationViewController notificationPrefab;

	[SerializeField]
	private GameObject notificationsContainer;

	[SerializeField]
	private float notificationsVerticalPadding;

	[Range(0f, 100f)]
	[SerializeField]
	private float notifyEveryCompletionPercentage;

	[SerializeField]
	private float notificationsCooldownSecs;

	[SerializeField]
	private float notificationAppearDelay;

	[SerializeField]
	private int questAmountToShow;

	[SerializeField]
	private LockedTabButtonController unlockButtonPrefab;

	[SerializeField]
	private bool uniqueGoalType;

	[ReadOnly]
	[Tooltip("Here you will see your active quests ")]
	public QuestGroupSO ActiveDailyQuests;

	[ReadOnly]
	public QuestGroupSO ActiveWeelyQuests;

	[SerializeField]
	[Tooltip("Add your different quest group types here.")]
	private List<QuestGroup> QuestPoolGroups;

	private List<QuestScreen> QuestScreens;

	private bool initialized;

	private bool questsEnabled;

	private CancellationTokenSource cancellationTokenSource;

	private Dictionary<INotificationEvent, Action<NotificationEventData>> notificationsMap;

	private List<QuestNotificationViewController> notificationViewList;

	private int notificationViewAmount;

	private DateTime lastNotificationTimestamp;

	private static bool _firstLaunch;

	private SavedDateTime currentStartDate;

	private CancellationTokenSource questNotificationToken;

	public static QuestManager Instance => null;

	private int UnlockAfterLevel => 0;

	public bool QuestsEnabled => false;

	private void CreateSingleton()
	{
	}

	private void TestAchievementNotification()
	{
	}

	private void RefreshAllQuests()
	{
	}

	private static void AdvanceOneDayMenu()
	{
	}

	private static void AdvanceOneHourMenu()
	{
	}

	private static void SetLessThanOneMinuteMenu()
	{
	}

	private void ResetQuestsSystem()
	{
	}

	private void NotifyQuestAchievement(QuestSO quest)
	{
	}

	private void ReorderExistingNotificationViews()
	{
	}

	public void EnableQuests()
	{
	}

	public void DisableQuests()
	{
	}

	public void RefreshQuestsGroup(QuestGroupType groupType)
	{
	}

	public void DisableNotifications()
	{
	}

	public void EnableNotifications()
	{
	}

	public bool HasPendingQuestsToClaim()
	{
		return false;
	}

	public List<QuestSO> GetPendingQuestsToClaim()
	{
		return null;
	}

	private QuestGroup GetPoolGroup(QuestGroupType group)
	{
		return null;
	}

	private bool TryGetPoolQuestSoByID(string id, out QuestSO questSo)
	{
		questSo = null;
		return false;
	}

	private void ResumeActiveQuestGroup()
	{
	}

	public QuestGroupSO GetActiveQuestGroup(QuestGroupType group)
	{
		return null;
	}

	private void SaveActiveQuestsList(QuestGroupSO activeQuests)
	{
	}

	private bool TryResumeActiveQuestsList(QuestGroupType questGroupType, out List<QuestSO> list)
	{
		list = null;
		return false;
	}

	private QuestGroupSO RefreshActiveQuests(QuestGroupType group, ref HashSet<int> uniqueSet)
	{
		return null;
	}

	public QuestGroupSO GetPoolQuestGroup(QuestGroupType group)
	{
		return null;
	}

	public QuestSO GetQuestById(string questId)
	{
		return null;
	}

	public bool TryGetQuestGroupTypeById(string questId, out QuestGroupType questGroupType)
	{
		questGroupType = default(QuestGroupType);
		return false;
	}

	public int GetQuestGroupMaxProgress(QuestGroupType groupType)
	{
		return 0;
	}

	public int GetQuestGroupProgress(QuestGroupType groupType)
	{
		return 0;
	}

	public void AddProgress(QuestGroupType groupType, int amount)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Start()
	{
	}

	private bool IsUIMissionButtonUnlocked()
	{
		return false;
	}

	private void TryToActivateQuestsSystem()
	{
	}

	public bool AreQuestsLocked()
	{
		return false;
	}

	public void ResetAllPoolsQuests()
	{
	}

	public void ResetAllPoolsGroupIndex()
	{
	}

	public void ResetPoolQuests(QuestGroupType groupType)
	{
	}

	private void DefineNotificationMap()
	{
	}

	private void UnlockQuests()
	{
	}

	private void Initialize()
	{
	}

	private void RegisterNotifications()
	{
	}

	private void MainNotificationCallback(INotificationEvent notificationEvent, NotificationEventData notificationEventData)
	{
	}

	private void CallbackGearPlaced(NotificationEventData data)
	{
	}

	private void CallbackGearMerged(NotificationEventData data)
	{
	}

	private void CallbackGearUnlocked(NotificationEventData data)
	{
	}

	private void CallbackShopRerolled(NotificationEventData data)
	{
	}

	private void CallbackTroopUpgraded(NotificationEventData data)
	{
	}

	private void CallbackEntitySpawned(NotificationEventData data)
	{
	}

	private void CallbackEntityKilled(NotificationEventData data)
	{
	}

	private void CallbackGameEvent(NotificationEventData data)
	{
	}

	private void CallbackCollectableSpent(NotificationEventData data)
	{
	}

	private void CallbackCollectableEarned(NotificationEventData data)
	{
	}

	private int GetQuestActionType(NotificationEventData data)
	{
		return 0;
	}

	private int GetQuestEntityType(NotificationEventData data)
	{
		return 0;
	}

	private int FromTroopTypeToQuestGoalEntityType(ScriptableTroop.TroopCategory troopCategory)
	{
		return 0;
	}

	private void OnDestroy()
	{
	}

	private void UnregisterNotifications(Dictionary<INotificationEvent, Action<NotificationEventData>> map)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckTimers_003Ed__91))]
	private void CheckTimers(CancellationTokenSource cancellation)
	{
	}

	internal int GetQuestProgression(QuestSO data)
	{
		return 0;
	}

	internal void AddQuestGoalProgress(QuestGoalTypeTag goalType, int amount, int subType)
	{
	}

	[AsyncStateMachine(typeof(_003CLaunchNotificationsAsync_003Ed__94))]
	private Task LaunchNotificationsAsync(List<QuestSO> totalQuestsUpdated, int amount, CancellationTokenSource cancellation)
	{
		return null;
	}

	internal void ClaimQuestRewards(Transform callee, QuestSO data)
	{
	}

	public void RegisterQuestScreen(QuestScreen screen)
	{
	}

	public void UnRegisterQuestScreen(QuestScreen screen)
	{
	}

	internal void CloseQuestScreen(QuestGroupType questType)
	{
	}

	internal void OpenQuestScreen(QuestGroupType questType)
	{
	}

	internal string GetRemainingTime(QuestGroupType questType)
	{
		return null;
	}

	internal static string QuestsToString(List<QuestSO> quests)
	{
		return null;
	}

	internal static string[] StringToQuestsID(string questsEncoded)
	{
		return null;
	}

	public void AdvanceOneDay()
	{
	}

	public void AdvanceOneHour()
	{
	}

	public void SetToOneMinute(int secs = 60)
	{
	}
}
