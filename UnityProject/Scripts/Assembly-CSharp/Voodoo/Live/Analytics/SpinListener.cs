using Voodoo.Live.Offers;

namespace Voodoo.Live.Analytics
{
	public class SpinListener : FeatureListener
	{
		private Spin _spin;

		protected override string LastTrigger => null;

		protected override string ShownSubFeature => null;

		protected override IFeature ClickedFeature => null;

		public SpinListener(Spin spin)
			: base(null)
		{
		}

		private string GetProbabilities()
		{
			return null;
		}

		protected override void OnFeatureStatusChanged(string status, IFeature feature)
		{
		}
	}
}
