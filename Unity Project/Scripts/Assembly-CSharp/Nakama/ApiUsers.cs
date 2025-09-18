using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUsers
	{
		[Preserve]
		[DataMember(Name = "users")]
		public List<ApiUser> Users { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
