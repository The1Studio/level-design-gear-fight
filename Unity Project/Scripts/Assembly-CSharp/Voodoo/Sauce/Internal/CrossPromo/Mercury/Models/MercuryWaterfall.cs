using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Mercury.Models
{
	[Serializable]
	public class MercuryWaterfall
	{
		public string id;

		public string name;

		public MercuryPromotedAsset[] promote_assets;

		public int first_time_videos_in_cache;

		public int buffer_videos;

		public string os_type;

		public string strategy_id;

		public string GetPromotedAssets()
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}
	}
}
