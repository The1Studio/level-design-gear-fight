using Data.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace IapOffers.Views
{
	public class IapOfferDailyView : MonoBehaviour
	{
		[SerializeField]
		private Transform _rewardContainer;

		[SerializeField]
		private IapOfferRewardView _rewardViewPrefab;

		[SerializeField]
		private Image _background;

		[SerializeField]
		private Sprite _defaultBanner;

		[SerializeField]
		private Sprite _claimedBanner;

		[SerializeField]
		private Sprite _unavailableBanner;

		public void Initialize(RewardStruct[] rewards, IapOfferRewardState state)
		{
		}
	}
}
