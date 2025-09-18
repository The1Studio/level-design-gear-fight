using System;
using System.Collections.Generic;

namespace Voodoo.Distribution
{
	[Serializable]
	public class LanguageRegistry : IDisposable
	{
		private bool _disposed;

		public Dictionary<string, string> translations;

		public void Dispose()
		{
		}
	}
}
