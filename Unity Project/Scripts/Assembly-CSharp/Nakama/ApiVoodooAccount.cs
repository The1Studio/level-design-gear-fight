using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiVoodooAccount
	{
		[Preserve]
		[DataMember(Name = "account")]
		public ApiAccount Account { get; set; }

		[Preserve]
		[DataMember(Name = "voodoo_ids")]
		public List<ApiVoodooId> VoodooIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
