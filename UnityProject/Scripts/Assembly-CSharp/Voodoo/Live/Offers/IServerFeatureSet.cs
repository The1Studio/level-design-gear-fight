using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public interface IServerFeatureSet : IServerFeature
	{
		List<IServerFeature> Features { get; set; }
	}
	public interface IServerFeatureSet<T> : IServerFeature where T : IServerFeature
	{
		List<T> Features { get; set; }
	}
}
