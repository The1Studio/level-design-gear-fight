using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleResetFeatureDefaultDataRequest
	{
		[Preserve]
		[DataMember(Name = "feature_id")]
		public string FeatureId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
