namespace Voodoo.Live.Offers
{
	public interface ICondition
	{
		string ErrorMessage { get; }

		bool CanUse();

		void LinkToFeature(string id);

		void Reset();

		void OnFeatureStatusChanged(string status, IFeature feature);
	}
}
