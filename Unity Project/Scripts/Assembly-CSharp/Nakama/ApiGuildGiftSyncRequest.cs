using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftSyncRequest
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
