using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiDebugNotification
	{
		[Preserve]
		[DataMember(Name = "notification")]
		public ApiNotification Notification { get; set; }

		[DataMember(Name = "target_user_id")]
		[Preserve]
		public string TargetUserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
