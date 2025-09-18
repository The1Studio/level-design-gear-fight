using System.Runtime.Serialization;

namespace Nakama
{
	public class ChannelMessageAck : IChannelMessageAck
	{
		[Preserve]
		[DataMember(Name = "channel_id")]
		public string ChannelId { get; set; }

		[DataMember(Name = "code")]
		[Preserve]
		public int Code { get; set; }

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[Preserve]
		[DataMember(Name = "message_id")]
		public string MessageId { get; set; }

		[Preserve]
		[DataMember(Name = "persistent")]
		public bool Persistent { get; set; }

		[Preserve]
		[DataMember(Name = "update_time")]
		public string UpdateTime { get; set; }

		[DataMember(Name = "room_name")]
		[Preserve]
		public string RoomName { get; set; }

		[DataMember(Name = "group_id")]
		[Preserve]
		public string GroupId { get; set; }

		[DataMember(Name = "user_id_one")]
		[Preserve]
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
