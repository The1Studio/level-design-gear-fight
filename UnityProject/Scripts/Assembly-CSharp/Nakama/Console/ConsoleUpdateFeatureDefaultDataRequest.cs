using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleUpdateFeatureDefaultDataRequest
	{
		[DataMember(Name = "feature_id")]
		[Preserve]
		public string FeatureId { get; set; }

		[Preserve]
		[DataMember(Name = "new_data")]
		public string NewData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
