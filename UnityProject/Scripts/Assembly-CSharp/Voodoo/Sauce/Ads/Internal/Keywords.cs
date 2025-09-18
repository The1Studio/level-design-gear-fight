using System;

namespace Voodoo.Sauce.Ads.Internal
{
	[Serializable]
	public class Keywords
	{
		public int gender;

		public float randomness;

		public GenderSelectionType GenderSelection => default(GenderSelectionType);
	}
}
