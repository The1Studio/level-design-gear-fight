using System;
using System.Net;

namespace Voodoo.Analytics
{
	internal class VoodooWebProxy : IWebProxy
	{
		private IWebProxy _wrappedProxy;

		private ICredentials _credentials;

		private string _proxyServer;

		public ICredentials Credentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Init()
		{
		}

		public VoodooWebProxy(string proxyServer)
		{
		}

		public VoodooWebProxy(IWebProxy theWrappedProxy)
		{
		}

		public Uri GetProxy(Uri destination)
		{
			return null;
		}

		public bool IsBypassed(Uri host)
		{
			return false;
		}
	}
}
