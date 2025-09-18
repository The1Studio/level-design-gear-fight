using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Voodoo.Live.Offers
{
	public abstract class Feature : IFeature, IConditionnal
	{
		private bool _isProcessingStatus;

		private Queue<string> _statusQueue;

		protected string _status;

		protected string _errorMessage;

		public string id { get; set; }

		public string name { get; set; }

		public string[] triggers { get; set; }

		public int multiplier { get; set; }

		public string campaign { get; set; }

		public FeatureVisual visual { get; set; }

		public string type { get; set; }

		public List<ICondition> conditions { get; set; }

		public string Status => null;

		public string errorMessage => null;

		public string LastTrigger { get; private set; }

		public virtual bool IsDataValid => false;

		public bool ShouldDisplayBadges => false;

		public virtual bool IsPurchaseStarting => false;

		public virtual bool IsPurchaseCompleting => false;

		public event Action<string, IFeature> statusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public abstract void SetupItems(Item[] items);

		public void SetStatus(string status)
		{
		}

		private void ProcessNextStatus()
		{
		}

		public bool HasTrigger(string trigger)
		{
			return false;
		}

		public virtual bool TryTrigger(string trigger, bool forceTrigger = false)
		{
			return false;
		}

		public void AddCondition(ICondition condition)
		{
		}

		public T GetCondition<T>() where T : ICondition
		{
			return default(T);
		}

		public bool CanUse()
		{
			return false;
		}

		public bool CanUseBadge()
		{
			return false;
		}

		public abstract Reward GetReward();

		public abstract Transaction ToTransaction();

		public void SubscribePurchasable(IPurchasable purchase)
		{
		}

		public void UnsubscribePurchasable(IPurchasable purchase)
		{
		}

		private void OnPurchaseStart()
		{
		}

		private void OnPurchaseFailed()
		{
		}

		private void OnPurchasePaid()
		{
		}

		private void OnPurchaseRewarded()
		{
		}
	}
}
