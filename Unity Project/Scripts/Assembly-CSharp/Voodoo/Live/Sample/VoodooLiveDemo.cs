using Voodoo.Live.Sample.Purchasing;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Sample
{
	public class VoodooLiveDemo : MonoSingleton<VoodooLiveDemo>
	{
		private static PurchaseHandler _purchaseHandler;

		private PurchaseManager _purchaseManager;

		private bool isInitialized;

		public static PurchaseHandler PurchaseHandler => null;

		private void Start()
		{
		}

		private void VoodooLiveInitialized()
		{
		}
	}
}
