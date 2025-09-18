using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiNonMemberGuildInfo
	{
		[Preserve]
		[DataMember(Name = "state")]
		public ApiNonMemberState State { get; set; }

		[Preserve]
		[DataMember(Name = "state_change_acked")]
		public bool StateChangeAcked { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
