using System.Collections.Generic;

namespace Core.Event
{
	public struct NotificationEventData : INotificationEventData
	{
		public NotificationEvent Notification;

		private Dictionary<string, object> data;

		private string[] keys;

		private bool valid;

		public void SetValue<T>(string key, T value)
		{
		}

		public string[] GetAttributes()
		{
			return null;
		}

		public int AttributesAmount()
		{
			return 0;
		}

		public T GetValue<T>(string attribute)
		{
			return default(T);
		}

		public bool IsValid()
		{
			return false;
		}

		public void FlushData()
		{
		}
	}
}
