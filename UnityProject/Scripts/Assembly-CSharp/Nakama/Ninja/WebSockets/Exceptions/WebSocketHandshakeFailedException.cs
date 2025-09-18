using System;

namespace Nakama.Ninja.WebSockets.Exceptions
{
	[Serializable]
	public class WebSocketHandshakeFailedException : Exception
	{
		public WebSocketHandshakeFailedException()
		{
		}

		public WebSocketHandshakeFailedException(string message)
		{
		}

		public WebSocketHandshakeFailedException(string message, Exception inner)
		{
		}
	}
}
