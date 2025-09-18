using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ChannelMessage
	{
		[DataMember(Name = "channel_id")]
		[Preserve]
		public string ChannelId;

		[Preserve]
		[DataMember(Name = "message_id")]
		public string MessageId;

		[Preserve]
		[DataMember(Name = "code")]
		public int? Code;

		[Preserve]
		[DataMember(Name = "sender_id")]
		public string SenderId;

		[DataMember(Name = "content")]
		[Preserve]
		public string Content;

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime;

		[Preserve]
		[DataMember(Name = "update_time")]
		public string UpdateTime;

		[DataMember(Name = "persistent")]
		[Preserve]
		public bool? Persistent;

		[DataMember(Name = "room_name")]
		[Preserve]
		public string RoomName;

		[DataMember(Name = "group_id")]
		[Preserve]
		public string GroupId;

		[DataMember(Name = "user_id_one")]
		[Preserve]
		public string UserIdOne;

		[DataMember(Name = "user_id_two")]
		[Preserve]
		public string UserIdTwo;

		public ChannelMessage()
		{
		}

		public ChannelMessage(string channelIdParam, string messageIdParam, int? codeParam, string senderIdParam, string contentParam, string createTimeParam, string updateTimeParam, bool? persistentParam, string roomNameParam, string groupIdParam, string userIdOneParam, string userIdTwoParam)
		{
		}
	}
}
