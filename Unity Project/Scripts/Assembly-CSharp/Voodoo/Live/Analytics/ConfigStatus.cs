using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public abstract class ConfigStatus
	{
		private const string TIME_TO_DOWNLOAD = "time_to_download";

		private const string IS_TIMEOUT = "is_timeout";

		private const string TIMEOUT = "timeout";

		private const string PAYLOAD_SIZE = "payload_size";

		private const string RESPONSE_CODE = "response_code";

		private const string ERROR_MESSAGE = "error_message";

		private readonly double _durationInMilliseconds;

		private readonly bool _isTimeout;

		private readonly int _timeout;

		private readonly ulong _payloadSize;

		private readonly long _responseCode;

		private readonly string _errorMessage;

		protected ConfigStatus(ConfigResponse config)
		{
		}

		protected Dictionary<string, object> GetParameters()
		{
			return null;
		}
	}
}
