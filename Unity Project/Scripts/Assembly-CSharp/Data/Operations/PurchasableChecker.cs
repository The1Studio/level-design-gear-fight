using System;
using System.Runtime.CompilerServices;

namespace Data.Operations
{
	public abstract class PurchasableChecker : IDisposable
	{
		private bool _isPurchasable;

		public bool IsPurchasable
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		private event Action<bool> _onAvailabilityRefreshed
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

		public void Register(Action<bool> listener)
		{
		}

		public void UnRegister(Action<bool> listener)
		{
		}

		public abstract void Dispose();
	}
}
