using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama
{
	public class GZipHttpClientHandler : DelegatingHandler
	{
		public GZipHttpClientHandler(HttpMessageHandler innerHandler)
		{
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
		{
			return null;
		}
	}
}
