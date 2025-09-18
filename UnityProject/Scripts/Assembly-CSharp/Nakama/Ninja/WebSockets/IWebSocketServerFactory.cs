using System.IO;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets
{
	public interface IWebSocketServerFactory
	{
		Task<WebSocketHttpContext> ReadHttpHeaderFromStreamAsync(System.IO.Stream stream, CancellationToken token = default(CancellationToken));

		Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, CancellationToken token = default(CancellationToken));

		Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, WebSocketServerOptions options, CancellationToken token = default(CancellationToken));
	}
}
