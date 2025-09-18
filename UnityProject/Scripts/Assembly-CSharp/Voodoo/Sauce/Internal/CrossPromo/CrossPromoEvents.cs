using System;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo
{
	internal class CrossPromoEvents
	{
		internal static event Action<string> OnInitComplete
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

		internal static event Action<AssetModel> OnClick
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

		internal static event Action<AssetModel> OnShown
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

		internal static event Action<Exception> OnError
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

		internal static void TriggerInitComplete(string format)
		{
		}

		internal static void TriggerClickEvent(AssetModel asset)
		{
		}

		internal static void TriggerShownEvent(AssetModel asset)
		{
		}

		internal static void TriggerErrorEvent(Exception message)
		{
		}
	}
}
