using Voodoo.Live.Offers;

namespace Voodoo.Live.Analytics
{
	public class NPOListener : FeatureListener
	{
		private NPO _npo;

		protected override string LastTrigger => null;

		protected override string ShownSubFeature => null;

		protected override IFeature ClickedFeature => null;

		public NPOListener(NPO npo)
			: base(null)
		{
		}
	}
}
