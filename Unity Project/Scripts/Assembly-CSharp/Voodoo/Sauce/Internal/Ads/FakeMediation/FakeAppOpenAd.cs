using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	internal class FakeAppOpenAd : FakeClosableAd
	{
		[SerializeField]
		private Button closeButton;

		protected new void Awake()
		{
		}
	}
}
