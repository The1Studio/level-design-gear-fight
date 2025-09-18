using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AdnAdData
	{
		public string Id;

		public string Placement;

		public string AdNetwork;

		public double? Cpm;

		public string CreativeId;

		public string ReviewCreativeId;

		public bool IsShown;

		public bool? IsClicked;

		public int? Duration;

		public bool? IsSkipped;

		public string Date;

		public Dictionary<string, object> ToDictionary()
		{
			return null;
		}

		public void Update(AdnAdData data)
		{
		}
	}
}
