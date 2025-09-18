using System;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class AudioAdConfig
	{
		public string adNetwork;

		public int gameStartTriggerFrequency;

		public int coolDownBetweenAudioAds;

		public bool killWhenFsOrRvStarts;

		public bool killWhenGameFinishes;

		public int closePopupCappingPerSession;

		public int closePopupFrequencyPerImpression;

		public int firstAudioAdGracePeriod;

		public int nextAudioAdGracePeriod;
	}
}
