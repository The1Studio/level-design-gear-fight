using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiVoodooId
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
