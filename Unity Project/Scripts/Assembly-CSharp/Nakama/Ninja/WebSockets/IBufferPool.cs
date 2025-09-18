using System.IO;

namespace Nakama.Ninja.WebSockets
{
	public interface IBufferPool
	{
		MemoryStream GetBuffer();
	}
}
