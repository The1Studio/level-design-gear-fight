using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiNotification
	{
		[DataMember(Name = "code")]
		[Preserve]
		public int Code { get; set; }

		[DataMember(Name = "content")]
		[Preserve]
		public string Content { get; set; }

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "persistent")]
		public bool Persistent { get; set; }

		[DataMember(Name = "sender_id")]
		[Preserve]
		public string SenderId { get; set; }

		[DataMember(Name = "subject")]
		[Preserve]
		public string Subject { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
