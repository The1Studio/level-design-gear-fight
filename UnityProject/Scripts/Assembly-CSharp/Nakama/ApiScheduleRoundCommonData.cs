using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduleRoundCommonData
	{
		[DataMember(Name = "duration_seconds")]
		[Preserve]
		public int DurationSeconds { get; set; }

		[DataMember(Name = "start_in_seconds")]
		[Preserve]
		public int StartInSeconds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
