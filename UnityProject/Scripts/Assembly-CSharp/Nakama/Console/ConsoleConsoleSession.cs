using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleConsoleSession
	{
		[DataMember(Name = "token")]
		[Preserve]
		public string Token { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
