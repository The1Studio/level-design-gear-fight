using System.Runtime.Serialization;

namespace Nakama
{
	public class StatusUpdateMessage
	{
		[DataMember(Name = "status")]
		[Preserve]
		public string Status { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
