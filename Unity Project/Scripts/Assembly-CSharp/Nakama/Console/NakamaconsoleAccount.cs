using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class NakamaconsoleAccount
	{
		[DataMember(Name = "account")]
		[Preserve]
		public NakamaapiAccount Account { get; set; }

		[DataMember(Name = "disable_time")]
		[Preserve]
		public string DisableTime { get; set; }

		[DataMember(Name = "voodoo_ids")]
		[Preserve]
		public List<string> VoodooIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
