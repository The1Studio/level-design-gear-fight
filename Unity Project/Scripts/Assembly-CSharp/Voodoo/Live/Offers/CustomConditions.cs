namespace Voodoo.Live.Offers
{
	public class CustomConditions : ICondition
	{
		public string[] tags;

		public string ErrorMessage => null;

		public bool CanUse()
		{
			return false;
		}

		public void OnFeatureStatusChanged(string status, IFeature feature)
		{
		}

		public void Reset()
		{
		}

		public void LinkToFeature(string id)
		{
		}
	}
}
