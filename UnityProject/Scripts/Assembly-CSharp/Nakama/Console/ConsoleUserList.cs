using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleUserList
	{
		[DataMember(Name = "users")]
		[Preserve]
		public List<ConsoleUserListUser> Users { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
