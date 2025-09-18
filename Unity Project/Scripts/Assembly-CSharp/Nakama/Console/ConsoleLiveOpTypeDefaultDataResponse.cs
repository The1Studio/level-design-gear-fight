using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleLiveOpTypeDefaultDataResponse
	{
		[Preserve]
		[DataMember(Name = "live_op_type_data")]
		public List<ConsoleLiveOpTypeDefaultData> LiveOpTypeData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
