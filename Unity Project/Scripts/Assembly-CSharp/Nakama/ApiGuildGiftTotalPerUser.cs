using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftTotalPerUser
	{
		[Preserve]
		[DataMember(Name = "total_per_user")]
		public Dictionary<string, long> TotalPerUser { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
