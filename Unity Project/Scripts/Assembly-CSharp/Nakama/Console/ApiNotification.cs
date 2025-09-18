using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiNotification
	{
		[DataMember(Name = "code")]
		[Preserve]
		public int Code { get; set; }

		[DataMember(Name = "content")]
		[Preserve]
		public string Content { get; set; }

		[Preserve]
		[DataMember(Name = "create_time")]
		public string CreateTime { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "persistent")]
		[Preserve]
		public bool Persistent { get; set; }

		[Preserve]
		[DataMember(Name = "sender_id")]
		public string SenderId { get; set; }

		[Preserve]
		[DataMember(Name = "subject")]
		public string Subject { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
