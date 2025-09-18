using System;

namespace Nakama.Ninja.WebSockets.Internal
{
	internal static class WebSocketFrameCommon
	{
		public const int MaskKeyLength = 4;

		public static void ToggleMask(ArraySegment<byte> maskKey, ArraySegment<byte> payload)
		{
		}
	}
}
