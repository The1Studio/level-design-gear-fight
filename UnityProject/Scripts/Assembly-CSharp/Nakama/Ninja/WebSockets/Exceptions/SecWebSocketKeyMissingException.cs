using System;

namespace Nakama.Ninja.WebSockets.Exceptions
{
	[Serializable]
	public class SecWebSocketKeyMissingException : Exception
	{
		public SecWebSocketKeyMissingException()
		{
		}

		public SecWebSocketKeyMissingException(string message)
		{
		}

		public SecWebSocketKeyMissingException(string message, Exception inner)
		{
		}
	}
}
