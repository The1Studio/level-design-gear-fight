using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public class ServerSpinSet : ServerFeature, IServerFeatureSet<ServerSpin>, IServerFeature
	{
		public List<ServerSpin> Features { get; set; }

		public override IFeature ToValidFormat()
		{
			return null;
		}
	}
}
