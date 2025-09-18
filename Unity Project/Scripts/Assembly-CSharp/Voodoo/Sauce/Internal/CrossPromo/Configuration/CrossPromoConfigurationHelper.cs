using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.Configuration
{
	internal class CrossPromoConfigurationHelper
	{
		internal enum ShouldBeShownReason
		{
			CanBeShown = 0,
			SessionTooEarly = 1,
			SessionCooldown = 2,
			GameTooEarly = 3,
			GameCooldown = 4,
			TooManyImpressions = 5,
			NotEnabled = 6
		}

		private CrossPromoConfiguration _configuration;

		private int _impressionsCount;

		private int _lastSessionCountWhenShown;

		private int _lastGamePlayedWhenShown;

		private int _gamesPlayed;

		private bool _crossPromoEnabled;

		private int _currentSessionCooldown;

		private const string K_PREFS_LAST_SESSION_SHOWN = "CrossPromo_LastSessionShown";

		private int LastSessionCountWhenShown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int SessionCount => 0;

		private int GameCount => 0;

		internal void Initialize(CrossPromoConfiguration configuration, bool crossPromoEnabled)
		{
		}

		internal bool ShouldBeEnabled()
		{
			return false;
		}

		internal ShouldBeShownReason GetShouldBeShownReason()
		{
			return default(ShouldBeShownReason);
		}

		internal ShouldBeShownReason GetShouldBeShownReason(int sessionsCount, int sessionsCooldown, int gamesPlayed, int lastGamesPlayed, int impressionsCount, int lastSessionCountWhenShown = 0, int lastGamePlayedWhenShown = 0)
		{
			return default(ShouldBeShownReason);
		}

		internal bool ShouldBeShown()
		{
			return false;
		}

		internal string GetGamesToShow()
		{
			return null;
		}

		private void OnClick(AssetModel obj)
		{
		}

		private void OnShown(AssetModel obj)
		{
		}

		private void OnGamePlayed(int level, bool victory)
		{
		}

		internal string GetCurrentStateDebugText()
		{
			return null;
		}

		internal string GetCurrentConfigurationDebugText()
		{
			return null;
		}

		internal string GetWaterfallId()
		{
			return null;
		}
	}
}
