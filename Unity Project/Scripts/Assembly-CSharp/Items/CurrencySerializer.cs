using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Items
{
	[Serializable]
	public record CurrencySerializer
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public double Amount;

		public bool HasBeenCollected;

		public bool RanOut;

		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			return false;
		}

		[CompilerGenerated]
		public virtual bool Equals(CurrencySerializer? other)
		{
			return false;
		}

		[CompilerGenerated]
		protected CurrencySerializer(CurrencySerializer original)
		{
		}

		public CurrencySerializer()
		{
		}
	}
}
