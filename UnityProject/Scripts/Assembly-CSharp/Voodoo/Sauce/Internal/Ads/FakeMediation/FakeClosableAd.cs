using System;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	internal abstract class FakeClosableAd : FakeAd
	{
		public Action onClose;

		protected void Close()
		{
		}
	}
}
