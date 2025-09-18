using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiGuildMember
	{
		[Preserve]
		[DataMember(Name = "player")]
		public ApiPlayerData Player { get; set; }

		[DataMember(Name = "role")]
		[Preserve]
		public ApiGuildRole Role { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
