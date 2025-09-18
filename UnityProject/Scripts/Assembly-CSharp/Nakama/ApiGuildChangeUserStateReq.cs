using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChangeUserStateReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

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
