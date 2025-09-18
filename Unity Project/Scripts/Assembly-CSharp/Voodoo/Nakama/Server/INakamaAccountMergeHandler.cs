using System.Threading.Tasks;
using NakamaHttp;

namespace Voodoo.Nakama.Server
{
	public interface INakamaAccountMergeHandler
	{
		Task<AccountMergeOption> MergeAccounts(NakamaHttpClient currentClient, NakamaHttpClient newClient);
	}
}
