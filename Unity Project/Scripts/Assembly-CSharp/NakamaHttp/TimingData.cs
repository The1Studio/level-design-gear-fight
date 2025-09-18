using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class TimingData
	{
		[Preserve]
		[DataMember(Name = "start_delta_seconds")]
		public int StartDeltaSeconds;

		[Preserve]
		[DataMember(Name = "end_delta_seconds")]
		public int EndDeltaSeconds;

		public TimingData()
		{
		}

		public TimingData(int startDeltaSecondsParam, int endDeltaSecondsParam)
		{
		}
	}
}
