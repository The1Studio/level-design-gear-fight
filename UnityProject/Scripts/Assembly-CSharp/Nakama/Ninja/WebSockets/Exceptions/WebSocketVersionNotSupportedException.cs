using System;

namespace Nakama.Ninja.WebSockets.Exceptions
{
	[Serializable]
	public class WebSocketVersionNotSupportedException : Exception
	{
		public WebSocketVersionNotSupportedException()
		{
		}

		public WebSocketVersionNotSupportedException(string message)
		{
		}

		public WebSocketVersionNotSupportedException(string message, Exception inner)
		{
		}
	}
}
