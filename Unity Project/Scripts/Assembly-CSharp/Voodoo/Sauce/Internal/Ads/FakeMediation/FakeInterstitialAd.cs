using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	internal class FakeInterstitialAd : FakeClosableAd
	{
		[SerializeField]
		[FormerlySerializedAs("_closeButton")]
		private Button closeButton;

		protected new void Awake()
		{
		}
	}
}
