using System;
using System.Collections.Generic;

namespace Comscore.Streaming
{
	public class StreamingListenerEventArgs : EventArgs
	{
		public int OldState { get; }

		public int NewState { get; }

		public Dictionary<string, string> Labels { get; }

		public StreamingListenerEventArgs(int oldState, int newState, Dictionary<string, string> labels)
		{
		}
	}
}
