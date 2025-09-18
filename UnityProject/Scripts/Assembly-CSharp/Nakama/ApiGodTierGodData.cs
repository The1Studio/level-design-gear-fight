using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierGodData
	{
		[Preserve]
		[DataMember(Name = "exists")]
		public bool Exists { get; set; }

		[DataMember(Name = "gods")]
		[Preserve]
		public List<ApiPlayerData> Gods { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
