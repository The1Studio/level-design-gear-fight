using System.Collections.Generic;
using System.IO;

namespace Nakama.Ninja.WebSockets
{
	public class WebSocketHttpContext
	{
		public bool IsWebSocketRequest { get; private set; }

		public IList<string> WebSocketRequestedProtocols { get; private set; }

		public string HttpHeader { get; private set; }

		public string Path { get; private set; }

		public System.IO.Stream Stream { get; private set; }

		public WebSocketHttpContext(bool isWebSocketRequest, IList<string> webSocketRequestedProtocols, string httpHeader, string path, System.IO.Stream stream)
		{
		}
	}
}
