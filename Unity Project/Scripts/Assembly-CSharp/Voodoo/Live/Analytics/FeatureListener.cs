using Voodoo.Live.Offers;

namespace Voodoo.Live.Analytics
{
	public abstract class FeatureListener
	{
		protected abstract string LastTrigger { get; }

		protected abstract string ShownSubFeature { get; }

		protected abstract IFeature ClickedFeature { get; }

		public FeatureListener(IFeature feature)
		{
		}

		protected virtual void OnFeatureStatusChanged(string status, IFeature feature)
		{
		}

		protected void AddContextParams(IFeature feature)
		{
		}

		protected void RemoveContextParams()
		{
		}
	}
}
