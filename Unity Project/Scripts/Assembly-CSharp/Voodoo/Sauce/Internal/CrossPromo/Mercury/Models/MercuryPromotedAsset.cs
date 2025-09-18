using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Mercury.Models
{
	[Serializable]
	public class MercuryPromotedAsset
	{
		public string id;

		public string file_path;

		public string file_url;

		public string tracking_link;

		public string tracking_impression;

		public string cp_format;

		public string store_ios_url;

		public MercuryGame game;

		public string videoUrl;

		public int videoIndex;
	}
}
