using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class Channel : IChannel
	{
		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		public IEnumerable<IUserPresence> Presences => null;

		[DataMember(Name = "presences")]
		[Preserve]
		public List<UserPresence> _presences { get; set; }

		public IUserPresence Self => null;

		[Preserve]
		[DataMember(Name = "self")]
		public UserPresence _self { get; set; }

		[Preserve]
		[DataMember(Name = "room_name")]
		public string RoomName { get; set; }

		[Preserve]
		[DataMember(Name = "group_id")]
		public string GroupId { get; set; }

		[DataMember(Name = "user_id_one")]
		[Preserve]
		public string UserIdOne { get; set; }

		[DataMember(Name = "user_id_two")]
		[Preserve]
		public string UserIdTwo { get; set; }

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool Equals(IChannel other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
