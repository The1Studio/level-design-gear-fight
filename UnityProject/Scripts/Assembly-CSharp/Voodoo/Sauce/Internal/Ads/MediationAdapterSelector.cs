using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Ads
{
	internal static class MediationAdapterSelector
	{
		private const string TAG = "MediationAdapterSelector";

		internal static IMediationAdapter CreateMediationInstance()
		{
			return null;
		}

		private static void SelectMediationIfNeeded(List<Type> mediationClasses)
		{
		}

		private static bool ShouldResetMediationChoice()
		{
			return false;
		}

		private static int GetMediationChoice()
		{
			return 0;
		}

		private static void SetMediationChoice(int mediationChoice)
		{
		}

		private static List<Type> GetMediationAdaptersClasses()
		{
			return null;
		}
	}
}
