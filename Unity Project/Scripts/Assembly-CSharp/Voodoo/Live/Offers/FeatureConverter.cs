namespace Voodoo.Live.Offers
{
	public class FeatureConverter : JsonCreationConverter<IServerFeature>
	{
		public override IServerFeature GetTargetInstance(string type)
		{
			return null;
		}
	}
}
