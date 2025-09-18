using System;

namespace Nakama.Ninja.WebSockets.Exceptions
{
	[Serializable]
	public class EntityTooLargeException : Exception
	{
		public EntityTooLargeException()
		{
		}

		public EntityTooLargeException(string message)
		{
		}

		public EntityTooLargeException(string message, Exception inner)
		{
		}
	}
}
