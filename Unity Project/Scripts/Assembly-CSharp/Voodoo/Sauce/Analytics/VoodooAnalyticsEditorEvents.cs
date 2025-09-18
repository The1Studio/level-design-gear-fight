using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Sauce.Analytics
{
	public static class VoodooAnalyticsEditorEvents
	{
		internal static event Action gameRunEvent
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

		internal static event Action gamePausedEvent
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

		internal static void TriggerGameRun()
		{
		}

		internal static void TriggerGamePaused()
		{
		}
	}
}
