using Core.Event;
using GearGame.Control;
using UnityEngine;
using UnityEngine.Events;

namespace Items
{
	public class Currency : Item
	{
		private ICurrencySaver _saver;

		public CurrencySO CurrencySettings { get; private set; }

		public override ItemSO Settings => null;

		public double Amount { get; private set; }

		public double PreviousAmount { get; private set; }

		public bool HasBeenCollected { get; private set; }

		public bool RanOut { get; private set; }

		public ItemAnimation Animation { get; set; }

		public UnityEvent<double> onAmountChanged { get; private set; }

		public Currency(CurrencySO settings, ICurrencySaver saver)
		{
		}

		public Currency Initialize(CurrencySerializer data)
		{
			return null;
		}

		private void SentNotificationEvent(NotificationEvent notificationEvent, int amount)
		{
		}

		public void Add(double amount)
		{
		}

		public void Add(double amount, int burstAmount, Vector2 position)
		{
		}

		public bool Consume(double amount)
		{
			return false;
		}

		public override void Animate(int burstAmount, Vector2 position)
		{
		}

		public override void Cancel()
		{
		}

		public void ResetRanOut()
		{
		}

		public override double GetBalance()
		{
			return 0.0;
		}
	}
}
