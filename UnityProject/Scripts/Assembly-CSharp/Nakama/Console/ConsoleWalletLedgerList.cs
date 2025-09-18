using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleWalletLedgerList
	{
		[Preserve]
		[DataMember(Name = "items")]
		public List<ConsoleWalletLedger> Items { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
