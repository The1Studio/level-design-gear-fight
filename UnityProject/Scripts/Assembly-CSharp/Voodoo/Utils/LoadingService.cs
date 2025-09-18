using System;
using System.Collections.Generic;

namespace Voodoo.Utils
{
	public static class LoadingService
	{
		private static Dictionary<object, Loading> _loadings;

		static LoadingService()
		{
		}

		public static Loading Register(object key)
		{
			return null;
		}

		public static IDisposable Subscribe(object key, Action<int> stateChanged, Action<float> progressChanged = null, Action<int> completed = null)
		{
			return null;
		}

		public static void Dispose()
		{
		}
	}
}
