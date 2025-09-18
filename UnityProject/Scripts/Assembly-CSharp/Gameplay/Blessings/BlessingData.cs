using System;
using System.Runtime.CompilerServices;
using Core.Timers;

namespace Gameplay.Blessings
{
	[Serializable]
	public class BlessingData
	{
		public int Level;

		public Timer Timer;

		public string TimerId;

		private int subLevel;

		public int SubLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action<int> SubLevelChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<BlessingData> OnBlessingEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool IsActive()
		{
			return false;
		}
	}
}
