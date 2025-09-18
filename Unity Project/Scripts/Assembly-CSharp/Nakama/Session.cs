using System;
using System.Collections.Generic;

namespace Nakama
{
	public class Session : ISession
	{
		public static readonly DateTime Epoch;

		public string AuthToken { get; private set; }

		public bool Created { get; }

		public long CreateTime { get; }

		public long ExpireTime { get; private set; }

		public bool IsExpired => false;

		public bool IsRefreshExpired => false;

		public long RefreshExpireTime { get; private set; }

		public string RefreshToken { get; private set; }

		public IDictionary<string, string> Vars { get; }

		public string UserId { get; private set; }

		public bool HasExpired(DateTime offset)
		{
			return false;
		}

		public bool HasRefreshExpired(DateTime offset)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		internal Session(string authToken, string refreshToken, bool created)
		{
		}

		internal void Update(string authToken, string refreshToken)
		{
		}

		public static ISession Restore(string authToken, string refreshToken = null)
		{
			return null;
		}

		private static string JwtUnpack(string jwt)
		{
			return null;
		}
	}
}
