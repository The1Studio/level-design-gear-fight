using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StringValue
	{
		[Preserve]
		[DataMember(Name = "value")]
		public string Value;

		public StringValue()
		{
		}

		public StringValue(string valueParam)
		{
		}
	}
}
