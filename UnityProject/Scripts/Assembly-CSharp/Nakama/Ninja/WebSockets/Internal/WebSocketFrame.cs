using System.Net.WebSockets;

namespace Nakama.Ninja.WebSockets.Internal
{
	public class WebSocketFrame
	{
		public bool IsFinBitSet { get; private set; }

		public WebSocketOpCode OpCode { get; private set; }

		public int Count { get; private set; }

		public WebSocketCloseStatus? CloseStatus { get; private set; }

		public string CloseStatusDescription { get; private set; }

		public WebSocketFrame(bool isFinBitSet, WebSocketOpCode webSocketOpCode, int count)
		{
		}

		public WebSocketFrame(bool isFinBitSet, WebSocketOpCode webSocketOpCode, int count, WebSocketCloseStatus closeStatus, string closeStatusDescription)
		{
		}
	}
}
