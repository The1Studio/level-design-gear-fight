using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class VoodooAccount
	{
		[DataMember(Name = "account")]
		[Preserve]
		public Account Account;

		[DataMember(Name = "voodoo_ids")]
		[Preserve]
		public List<VoodooId> VoodooIds;

		public VoodooAccount()
		{
		}

		public VoodooAccount(Account accountParam, List<VoodooId> voodooIdsParam)
		{
		}
	}
}
