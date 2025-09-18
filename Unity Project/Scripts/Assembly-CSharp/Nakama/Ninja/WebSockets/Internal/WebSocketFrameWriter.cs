using System;
using System.IO;

namespace Nakama.Ninja.WebSockets.Internal
{
	internal static class WebSocketFrameWriter
	{
		private static readonly Random _random;

		static WebSocketFrameWriter()
		{
		}

		public static void Write(WebSocketOpCode opCode, ArraySegment<byte> fromPayload, MemoryStream toStream, bool isLastFrame, bool isClient)
		{
		}
	}
}
