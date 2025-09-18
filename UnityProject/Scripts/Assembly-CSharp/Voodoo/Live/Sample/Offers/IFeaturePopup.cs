using Voodoo.Live.Offers;

namespace Voodoo.Live.Sample.Offers
{
	public interface IFeaturePopup
	{
		void Initialize(IFeature offer);

		void Show();

		void Hide();
	}
}
