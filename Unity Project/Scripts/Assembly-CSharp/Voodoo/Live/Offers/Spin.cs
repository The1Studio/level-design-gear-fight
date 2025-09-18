using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voodoo.Live.Offers
{
	public class Spin : Feature, IFeature, IConditionnal
	{
		public List<int> probabilities;

		public List<Reward> rewards;

		public SpinType spinType;

		public int rerollLimit;

		private int _rewardIndex;

		private int _rerollCount;

		private bool _spinUsed;

		private IPurchasable _spinPrice;

		private IPurchasable _rerollPrice;

		[JsonIgnore]
		public Reward RewardObtained => null;

		private string _rerollCountKey => null;

		private string _spinUsedKey => null;

		private string _rewardIndexKey => null;

		public int RerollCount
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int RewardIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool SpinUsed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IPurchasable SpinPrice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IPurchasable RerollPrice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool IsDataValid => false;

		public override bool IsPurchaseStarting => false;

		public override bool IsPurchaseCompleting => false;

		public override void SetupItems(Item[] items)
		{
		}

		public bool Reroll()
		{
			return false;
		}

		public void SpinWheel()
		{
		}

		private void OnSpinPriceStateChange()
		{
		}

		private void CompleteSpin()
		{
		}

		private int GetRandomReward()
		{
			return 0;
		}

		public void SubscribeReroll(IPurchasable purchase)
		{
		}

		public void UnsubscribeReroll(IPurchasable purchase)
		{
		}

		private void OnRerollPurchaseStart()
		{
		}

		private void OnRerollPurchaseFailed()
		{
		}

		private void OnRerollPurchasePaid()
		{
		}

		private void OnRerollPurchaseSuccess()
		{
		}

		public override Reward GetReward()
		{
			return null;
		}

		public override Transaction ToTransaction()
		{
			return null;
		}

		public void ResetRerollCount()
		{
		}
	}
}
