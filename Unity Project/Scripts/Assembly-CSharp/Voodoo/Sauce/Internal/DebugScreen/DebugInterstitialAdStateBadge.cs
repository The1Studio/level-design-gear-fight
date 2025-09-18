using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugInterstitialAdStateBadge : DebugAdStateBadge
	{
		protected override bool IsEnabled()
		{
			return false;
		}

		protected override Color StateColor()
		{
			return default(Color);
		}

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
