using Coffee.UIExtensions;
using Items;
using UnityEngine;
using UnityEngine.Events;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Items/Currency")]
	public class CurrencySO : ItemSO
	{
		private Currency _instance;

		[field: SerializeField]
		public UIParticle Particle { get; private set; }

		[field: SerializeField]
		public int QuestTrackingValue { get; private set; }

		[field: SerializeField]
		public int SpriteIndex { get; private set; }

		public double Amount => 0.0;

		public double PreviousAmount => 0.0;

		public bool HasBeenCollected => false;

		public bool RanOut => false;

		public ItemAnimation Animation => null;

		public UnityEvent<double> onAmountChanged => null;

		[field: Header("Legacy")]
		[field: Space(20f)]
		[field: SerializeField]
		public string ID { get; private set; }

		internal void Initialize(Currency currency)
		{
		}

		public void Add(double amount, TransactionLocation transactionLocation = TransactionLocation.None)
		{
		}

		public void Add(double amount, int burstAmount, Vector2 position, TransactionLocation transactionLocation = TransactionLocation.None)
		{
		}

		public bool Consume(double amount, TransactionLocation transactionLocation = TransactionLocation.None)
		{
			return false;
		}

		public void Animate(int burstAmount, Vector2 position)
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
