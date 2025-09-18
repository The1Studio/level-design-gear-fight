using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ServerTime
	{
		[DataMember(Name = "epoch_seconds")]
		[Preserve]
		public int EpochSeconds;

		public ServerTime()
		{
		}

		public ServerTime(int epochSecondsParam)
		{
		}
	}
}
