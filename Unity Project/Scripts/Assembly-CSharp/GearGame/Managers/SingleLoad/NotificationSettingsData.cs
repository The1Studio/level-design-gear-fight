using System;
using System.Collections.Generic;
using Core.Event;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	[Serializable]
	[CreateAssetMenu(menuName = "Notification Manager/Create NotificationSettingsData", fileName = "NotificationSettingsData", order = 0)]
	internal class NotificationSettingsData : SerializedScriptableObject
	{
		[SerializeField]
		private readonly Dictionary<NotificationEvent, List<Action<NotificationEventData>>> notificationTable;

		private readonly List<Action<NotificationEventData>> emptyList;

		public void AddTo(NotificationEvent notificationEvent, Action<NotificationEventData> callback)
		{
		}

		public void RemoveFrom(NotificationEvent notificationEvent, Action<NotificationEventData> callback)
		{
		}

		public List<Action<NotificationEventData>> GetAllFrom(NotificationEvent notificationEvent)
		{
			return null;
		}
	}
}
