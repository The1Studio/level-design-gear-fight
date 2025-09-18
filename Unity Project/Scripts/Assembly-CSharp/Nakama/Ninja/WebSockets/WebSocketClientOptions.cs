using System;
using System.Collections.Generic;

namespace Nakama.Ninja.WebSockets
{
	public class WebSocketClientOptions
	{
		public TimeSpan KeepAliveInterval { get; set; }

		public bool NoDelay { get; set; }

		public Dictionary<string, string> AdditionalHttpHeaders { get; set; }

		public bool IncludeExceptionInCloseResponse { get; set; }

		public string SecWebSocketExtensions { get; set; }

		public string SecWebSocketProtocol { get; set; }
	}
}
