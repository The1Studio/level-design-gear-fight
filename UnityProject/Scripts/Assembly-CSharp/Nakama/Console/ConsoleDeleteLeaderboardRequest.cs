using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleDeleteLeaderboardRequest
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
