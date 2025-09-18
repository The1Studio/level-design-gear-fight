using System;
using Core.Event;
using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	public class NotificationManager : MonoBehaviour
	{
		[ReadOnly]
		[SerializeField]
		private NotificationSettingsData notificationSettings;

		public static Action<INotificationEvent, NotificationEventData> GlobalNotification;

		internal const string NotificationTag = "NotificationEvent";

		private static NotificationManager _instance;

		public static NotificationManager Instance => null;

		public static bool HasInstance()
		{
			return false;
		}

		private void Awake()
		{
		}

		public void Notify(NotificationEvent notificationEvent, NotificationEventData data = default(NotificationEventData))
		{
		}

		public void Subscribe(INotificationEvent notificationEvent, Action<NotificationEventData> callback)
		{
		}

		public void SubscribeGlobal(Action<INotificationEvent, NotificationEventData> mainNotificationCallback)
		{
		}

		public void UnSubscribe(INotificationEvent notificationEvent, Action<NotificationEventData> callback)
		{
		}

		private void ProcessEvent(NotificationEvent notificationEvent, NotificationEventData data)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
