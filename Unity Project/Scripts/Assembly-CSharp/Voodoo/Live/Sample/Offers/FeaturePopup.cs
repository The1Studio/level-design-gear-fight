using Core.UI;
using Voodoo.Live.Offers;

namespace Voodoo.Live.Sample.Offers
{
	public abstract class FeaturePopup : Popup, IFeaturePopup
	{
		protected IFeature _feature;

		public void Initialize(IFeature feature)
		{
		}

		public abstract void Show();

		public virtual void Hide()
		{
		}

		public virtual void Purchase(IPurchasable purchasable)
		{
		}

		public abstract void OnStatusChanged(string status, IFeature feature);
	}
}
