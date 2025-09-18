using System;
using System.Collections.Generic;

namespace Voodoo.Distribution
{
	[Serializable]
	public class LocalizationSet : IDisposable
	{
		private bool _disposed;

		public Dictionary<string, LanguageRegistry> languages;

		public void Dispose()
		{
		}
	}
}
