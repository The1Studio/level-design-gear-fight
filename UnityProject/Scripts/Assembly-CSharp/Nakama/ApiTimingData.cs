using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiTimingData
	{
		[DataMember(Name = "seconds_since_start")]
		[Preserve]
		public int SecondsSinceStart { get; set; }

		[DataMember(Name = "seconds_until_end")]
		[Preserve]
		public int SecondsUntilEnd { get; set; }

		[DataMember(Name = "seconds_until_start")]
		[Preserve]
		public int SecondsUntilStart { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
