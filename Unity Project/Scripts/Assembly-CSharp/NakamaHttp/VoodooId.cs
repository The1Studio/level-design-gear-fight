using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class VoodooId
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		public VoodooId()
		{
		}

		public VoodooId(string idParam)
		{
		}
	}
}
