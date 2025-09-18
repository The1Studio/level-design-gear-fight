using System;

namespace Voodoo.Nakama.Server
{
	internal class NakamaDelayedCallback
	{
		public float CallbackTime;

		public Action Callback;

		public bool Periodic;
	}
}
