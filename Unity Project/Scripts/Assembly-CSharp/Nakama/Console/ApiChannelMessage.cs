using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiChannelMessage
	{
		[Preserve]
		[DataMember(Name = "channel_id")]
		public string ChannelId { get; set; }

		[DataMember(Name = "code")]
		[Preserve]
		public int Code { get; set; }

		[DataMember(Name = "content")]
		[Preserve]
		public string Content { get; set; }

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[DataMember(Name = "group_id")]
		[Preserve]
		public string GroupId { get; set; }

		[DataMember(Name = "message_id")]
		[Preserve]
		public string MessageId { get; set; }

		[DataMember(Name = "persistent")]
		[Preserve]
		public bool Persistent { get; set; }

		[Preserve]
		[DataMember(Name = "room_name")]
		public string RoomName { get; set; }

		[DataMember(Name = "sender_id")]
		[Preserve]
		public string SenderId { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		[DataMember(Name = "user_id_one")]
		[Preserve]
		public string UserIdOne { get; set; }

		[DataMember(Name = "user_id_two")]
		[Preserve]
		public string UserIdTwo { get; set; }

		[DataMember(Name = "username")]
		[Preserve]
		public string Username { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
