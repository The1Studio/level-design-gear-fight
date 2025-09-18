using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class SleepReq
	{
		[Preserve]
		[DataMember(Name = "duration")]
		public int Duration;

		public SleepReq()
		{
		}

		public SleepReq(int durationParam)
		{
		}
	}
}
