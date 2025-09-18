using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class BoolValue
	{
		[Preserve]
		[DataMember(Name = "value")]
		public bool Value;

		public BoolValue()
		{
		}

		public BoolValue(bool valueParam)
		{
		}
	}
}
