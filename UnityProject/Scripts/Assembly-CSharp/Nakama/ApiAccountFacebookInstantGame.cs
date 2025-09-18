using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAccountFacebookInstantGame
	{
		[Preserve]
		[DataMember(Name = "signed_player_info")]
		public string SignedPlayerInfo { get; set; }

		[DataMember(Name = "vars")]
		[Preserve]
		public Dictionary<string, string> Vars { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
