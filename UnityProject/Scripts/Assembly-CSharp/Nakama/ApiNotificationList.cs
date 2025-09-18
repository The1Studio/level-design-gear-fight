using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiNotificationList
	{
		[DataMember(Name = "cacheable_cursor")]
		[Preserve]
		public string CacheableCursor { get; set; }

		[Preserve]
		[DataMember(Name = "notifications")]
		public List<ApiNotification> Notifications { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
