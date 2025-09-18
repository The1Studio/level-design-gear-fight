using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchmakerTicket : IMatchmakerTicket
	{
		[DataMember(Name = "ticket")]
		[Preserve]
		public string Ticket { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
