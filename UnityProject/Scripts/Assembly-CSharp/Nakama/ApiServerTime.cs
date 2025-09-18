using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiServerTime
	{
		[Preserve]
		[DataMember(Name = "epoch_seconds")]
		public int EpochSeconds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
