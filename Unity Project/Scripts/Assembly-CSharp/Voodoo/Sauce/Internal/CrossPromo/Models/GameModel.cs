using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Models
{
	[Serializable]
	public class GameModel
	{
		public string id;

		public string name;

		public AssetModel[] promote_assets;

		public int first_time_videos_in_cache;

		public int buffer_videos;

		public string os_type;

		public string strategy_id;

		public string GetPromotedAssetsNames()
		{
			return null;
		}
	}
}
