using System.Collections.Generic;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	[Preserve]
	public class VoodooTuneSessionParameters : IVoodooTuneFilledVariables
	{
		private enum SessionParameter
		{
			app_open_count = 0,
			vs_version = 1,
			advertising_id = 2,
			sessions_count = 3,
			games_count = 4,
			best_score = 5,
			level = 6,
			win_rate = 7,
			user_id = 8,
			device_model = 9,
			device_manufacturer = 10,
			developer_device_id = 11,
			days_since_install = 12,
			last_active_since = 13,
			total_playtime_last_day = 14,
			total_playtime_last_7_days = 15,
			total_playtime_last_30_days = 16,
			activity_days = 17
		}

		public Dictionary<string, string> GetParameters()
		{
			return null;
		}

		private Dictionary<SessionParameter, string> BuildSessionParameters()
		{
			return null;
		}
	}
}
