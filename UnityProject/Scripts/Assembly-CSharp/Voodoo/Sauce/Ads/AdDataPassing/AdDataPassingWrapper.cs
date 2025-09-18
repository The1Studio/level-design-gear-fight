using System.Collections.Generic;
using UnityEngine;
using Voodoo.Sauce.Ads.Internal;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Ads.AdDataPassing
{
	public class AdDataPassingWrapper : MonoBehaviour
	{
		private static AdDataPassingWrapper Instance;

		private const string TAG = "AdDataPassingWrapper";

		private Keywords _config;

		private static GenderType _gender;

		private bool _initialized;

		private bool _genderSet;

		private const string KPrefsRandomGender = "VOODOO_RND_GENDER";

		private List<IAdDataPassingNetwork> adDataNetworks;

		private int RandomGender
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnVoodooSauceInitialize(VoodooSauceInitCallbackResult result)
		{
		}

		private void Initialize()
		{
		}

		private void RegisterCallbacks()
		{
		}

		private void OnBannerLoadAttempt(string adUnit)
		{
		}

		private void OnInterstitialLoadAttempt(string adUnit)
		{
		}

		private void OnRewardedVideoLoadAttempt(string adUnit)
		{
		}

		private void SetCustomGender(int selection)
		{
		}

		public static void SetCustomGender(GenderType gender)
		{
		}

		private void SetGender(GenderType gender)
		{
		}

		private void TrackKeywordsPassing()
		{
		}
	}
}
