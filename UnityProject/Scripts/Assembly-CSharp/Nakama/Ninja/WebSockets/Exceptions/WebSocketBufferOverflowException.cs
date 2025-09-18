using System;

namespace Nakama.Ninja.WebSockets.Exceptions
{
	[Serializable]
	public class WebSocketBufferOverflowException : Exception
	{
		public WebSocketBufferOverflowException()
		{
		}

		public WebSocketBufferOverflowException(string message)
		{
		}

		public WebSocketBufferOverflowException(string message, Exception inner)
		{
		}
	}
}
