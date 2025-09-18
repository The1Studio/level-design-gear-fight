using UnityEngine;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.Ads
{
	[Preserve]
	public class BigoAdsMaxAdsPrivacy : MonoBehaviour
	{
		public string SDKName => null;

		public string PrivacyPolicyUrl => null;

		public PrivacySDKType SDKType => default(PrivacySDKType);
	}
}
