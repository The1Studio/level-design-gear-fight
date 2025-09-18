using System;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets
{
	internal interface IPingPongManager
	{
		event EventHandler<PongEventArgs> Pong;

		Task SendPing(ArraySegment<byte> payload, CancellationToken cancellation);
	}
}
