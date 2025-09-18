using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class FeatureId
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		public FeatureId()
		{
		}

		public FeatureId(string idParam)
		{
		}
	}
}
