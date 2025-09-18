using System;

namespace Voodoo.Live
{
	public class ConfigResponse
	{
		public TimeSpan requestDuration;

		public bool hasTimeout;

		public ulong payloadSize;

		public long responseCode;

		public int currentTimeoutInMilliseconds;

		public string url;

		public string errorMessage;

		public string json;

		public ConfigResponse(int timeoutInMilliseconds)
		{
		}
	}
}
