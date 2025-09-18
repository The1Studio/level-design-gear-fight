using System;
using System.Collections.Generic;
using Core.Timers;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	public class TimerSave : ServerBaseData
	{
		public DateTime LastConfirmedTime;

		public Dictionary<string, string> AllTimers;

		public Dictionary<string, Timer.Serialized> NewTimers;
	}
}
