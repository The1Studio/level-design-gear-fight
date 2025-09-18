using System;
using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public class ServerSpin : ServerFeature, IServerFeature
	{
		public List<int> probabilities;

		public List<Reward> rewards;

		public SpinType spinType;

		public IPrice spinPrice;

		public IPrice rerollPrice;

		public int rerollLimit;

		public TimeSpan rerollCooldown;

		public override IFeature ToValidFormat()
		{
			return null;
		}
	}
}
