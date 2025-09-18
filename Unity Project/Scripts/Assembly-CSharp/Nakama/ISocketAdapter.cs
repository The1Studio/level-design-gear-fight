using System;
using System.Threading;

namespace Nakama
{
	public interface ISocketAdapter : IDisposable
	{
		bool IsConnected { get; }

		bool IsConnecting { get; }

		event Action Connected;

		event Action Closed;

		event Action<Exception> ReceivedError;

		event Action<ArraySegment<byte>> Received;

		void Close();

		void Connect(Uri uri, int timeout);

		void Send(ArraySegment<byte> buffer, CancellationToken cancellationToken, bool reliable = true);
	}
}
