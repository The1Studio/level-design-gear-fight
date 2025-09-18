using System;

namespace Nakama.Ninja.WebSockets
{
	public class WebSocketServerOptions
	{
		public TimeSpan KeepAliveInterval { get; set; }

		public bool IncludeExceptionInCloseResponse { get; set; }

		public string SubProtocol { get; set; }
	}
}
