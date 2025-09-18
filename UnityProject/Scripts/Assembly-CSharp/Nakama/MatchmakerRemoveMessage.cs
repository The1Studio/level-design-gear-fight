using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchmakerRemoveMessage
	{
		[Preserve]
		[DataMember(Name = "ticket")]
		public string Ticket { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
