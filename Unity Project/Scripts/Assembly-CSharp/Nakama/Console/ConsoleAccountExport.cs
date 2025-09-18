using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAccountExport
	{
		[DataMember(Name = "account")]
		[Preserve]
		public NakamaapiAccount Account { get; set; }

		[DataMember(Name = "friends")]
		[Preserve]
		public List<ApiFriend> Friends { get; set; }

		[DataMember(Name = "guild")]
		[Preserve]
		public ApiUserGuild Guild { get; set; }

		[DataMember(Name = "leaderboard_records")]
		[Preserve]
		public List<ApiLeaderboardRecord> LeaderboardRecords { get; set; }

		[DataMember(Name = "messages")]
		[Preserve]
		public List<ApiChannelMessage> Messages { get; set; }

		[DataMember(Name = "notifications")]
		[Preserve]
		public List<ApiNotification> Notifications { get; set; }

		[DataMember(Name = "objects")]
		[Preserve]
		public List<ApiStorageObject> Objects { get; set; }

		[Preserve]
		[DataMember(Name = "wallet_ledgers")]
		public List<ConsoleWalletLedger> WalletLedgers { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
