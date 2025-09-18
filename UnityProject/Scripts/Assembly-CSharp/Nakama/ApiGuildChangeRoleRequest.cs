using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChangeRoleRequest
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "new_role")]
		[Preserve]
		public ApiGuildRole NewRole { get; set; }

		[DataMember(Name = "points")]
		[Preserve]
		public int Points { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
