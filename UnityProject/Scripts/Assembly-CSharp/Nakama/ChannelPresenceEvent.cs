using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ChannelPresenceEvent : IChannelPresenceEvent
	{
		[Preserve]
		[DataMember(Name = "channel_id")]
		public string ChannelId { get; set; }

		public IEnumerable<IUserPresence> Joins => null;

		[DataMember(Name = "joins")]
		[Preserve]
		public List<UserPresence> _joins { get; set; }

		public IEnumerable<IUserPresence> Leaves => null;

		[Preserve]
		[DataMember(Name = "leaves")]
		public List<UserPresence> _leaves { get; set; }

		[DataMember(Name = "room_name")]
		[Preserve]
		public string RoomName { get; set; }

		[DataMember(Name = "group_id")]
		[Preserve]
		public string GroupId { get; set; }

		[DataMember(Name = "user_id_one")]
		[Preserve]
		public string UserIdOne { get; set; }

		[DataMember(Name = "user_id_two")]
		[Preserve]
		public string UserIdTwo { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
