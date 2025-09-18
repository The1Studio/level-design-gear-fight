using System;

namespace Core.Event
{
	[Serializable]
	public class NotificationEvent : INotificationEvent, IEquatable<NotificationEvent>
	{
		[ReadOnly]
		public readonly string Name;

		public NotificationEvent(string name = "")
		{
		}

		public bool Equals(NotificationEvent other)
		{
			return false;
		}
	}
}
