using System;

namespace Nakama.Ninja.WebSockets.Exceptions
{
	[Serializable]
	public class InvalidHttpResponseCodeException : Exception
	{
		public string ResponseCode { get; private set; }

		public string ResponseHeader { get; private set; }

		public string ResponseDetails { get; private set; }

		public InvalidHttpResponseCodeException()
		{
		}

		public InvalidHttpResponseCodeException(string message)
		{
		}

		public InvalidHttpResponseCodeException(string responseCode, string responseDetails, string responseHeader)
		{
		}

		public InvalidHttpResponseCodeException(string message, Exception inner)
		{
		}
	}
}
