using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public interface IFeatureSet : IFeature, IConditionnal
	{
		List<IFeature> Features { get; set; }
	}
	public interface IFeatureSet<T> : IFeature, IConditionnal where T : IFeature
	{
		List<T> Features { get; set; }
	}
}
