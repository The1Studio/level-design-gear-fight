using System;

namespace Nakama.Ninja.WebSockets.Exceptions
{
	[Serializable]
	public class ServerListenerSocketException : Exception
	{
		public ServerListenerSocketException()
		{
		}

		public ServerListenerSocketException(string message)
		{
		}

		public ServerListenerSocketException(string message, Exception inner)
		{
		}
	}
}
