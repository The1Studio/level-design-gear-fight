using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleUnlinkVoodooIdRequest
	{
		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "voodoo_id")]
		public string VoodooId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
