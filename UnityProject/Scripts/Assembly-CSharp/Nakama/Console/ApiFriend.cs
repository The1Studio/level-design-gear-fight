using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiFriend
	{
		[DataMember(Name = "state")]
		[Preserve]
		public int State { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		[Preserve]
		[DataMember(Name = "user")]
		public NakamaapiUser User { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
