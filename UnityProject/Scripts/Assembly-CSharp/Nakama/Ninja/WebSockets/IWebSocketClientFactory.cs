using System;
using System.IO;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets
{
	public interface IWebSocketClientFactory
	{
		Task<WebSocket> ConnectAsync(Uri uri, CancellationToken token = default(CancellationToken));

		Task<WebSocket> ConnectAsync(Uri uri, WebSocketClientOptions options, CancellationToken token = default(CancellationToken));

		Task<WebSocket> ConnectAsync(System.IO.Stream responseStream, string secWebSocketKey, WebSocketClientOptions options, CancellationToken token = default(CancellationToken));
	}
}
