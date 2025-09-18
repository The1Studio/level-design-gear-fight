using System;

namespace Voodoo.Live
{
	public interface IClient
	{
		IUrlHandler UrlHandler { get; }

		ConfigResponse ConfigResponse { get; }

		event Action<ConfigResponse> requestCompleted;
	}
}
