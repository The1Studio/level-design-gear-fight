using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Nakama
{
	public interface IHttpAdapter
	{
		ILogger Logger { get; set; }

		CookieContainer CookieContainer { get; }

		Task<string> SendAsync(string method, Uri uri, IDictionary<string, string> headers, byte[] body, int timeoutSec = 3);
	}
}
