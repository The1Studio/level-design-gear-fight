using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildMember
	{
		[Preserve]
		[DataMember(Name = "player")]
		public ApiPlayerData Player { get; set; }

		[Preserve]
		[DataMember(Name = "role")]
		public ApiGuildRole Role { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
