using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiFriend
	{
		[DataMember(Name = "state")]
		[Preserve]
		public int State { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		[DataMember(Name = "user")]
		[Preserve]
		public ApiUser User { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
