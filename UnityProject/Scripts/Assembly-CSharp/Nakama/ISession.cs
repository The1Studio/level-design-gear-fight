using System;
using System.Collections.Generic;

namespace Nakama
{
	public interface ISession
	{
		string AuthToken { get; }

		bool Created { get; }

		long CreateTime { get; }

		long ExpireTime { get; }

		bool IsExpired { get; }

		bool IsRefreshExpired { get; }

		long RefreshExpireTime { get; }

		string RefreshToken { get; }

		IDictionary<string, string> Vars { get; }

		string UserId { get; }

		bool HasExpired(DateTime offset);

		bool HasRefreshExpired(DateTime offset);
	}
}
