using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChannelMessage
	{
		[DataMember(Name = "channel_id")]
		[Preserve]
		public string ChannelId { get; set; }

		[DataMember(Name = "code")]
		[Preserve]
		public int Code { get; set; }

		[DataMember(Name = "content")]
		[Preserve]
		public string Content { get; set; }

		[Preserve]
		[DataMember(Name = "create_time")]
		public string CreateTime { get; set; }

		[Preserve]
		[DataMember(Name = "group_id")]
		public string GroupId { get; set; }

		[Preserve]
		[DataMember(Name = "message_id")]
		public string MessageId { get; set; }

		[Preserve]
		[DataMember(Name = "persistent")]
		public bool Persistent { get; set; }

		[Preserve]
		[DataMember(Name = "room_name")]
		public string RoomName { get; set; }

		[DataMember(Name = "sender_id")]
		[Preserve]
		public string SenderId { get; set; }

		[Preserve]
		[DataMember(Name = "update_time")]
		public string UpdateTime { get; set; }

		[Preserve]
		[DataMember(Name = "user_id_one")]
		public string UserIdOne { get; set; }

		[Preserve]
		[DataMember(Name = "user_id_two")]
		public string UserIdTwo { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
