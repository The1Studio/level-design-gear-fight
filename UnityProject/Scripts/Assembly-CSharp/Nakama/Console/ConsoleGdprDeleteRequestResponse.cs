using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleGdprDeleteRequestResponse
	{
		[DataMember(Name = "deleted_user_ids")]
		[Preserve]
		public List<string> DeletedUserIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
