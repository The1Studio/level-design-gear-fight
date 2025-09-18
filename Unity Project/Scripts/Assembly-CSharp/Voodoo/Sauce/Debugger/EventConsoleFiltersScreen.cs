using System.Collections.Generic;
using UnityEngine;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Debugger
{
	public class EventConsoleFiltersScreen : Screen
	{
		private const string DEFAULT_WRAPPER_NAME_FILTER = "VoodooAnalytics";

		[SerializeField]
		[Header("EventFilters")]
		private Transform filtersContainer;

		private readonly Queue<DebugToggleButton> _eventFilterItemsPool;

		private readonly List<string> _excludedEventFilters;

		private DebugToggleButton _masterItem;

		internal EventConsoleListScreen EventConsoleListScreen { private get; set; }

		private void OnEnable()
		{
		}

		public override void OnScreenHide()
		{
		}

		private IEnumerable<KeyValuePair<string, bool>> GetFiltersWithStates()
		{
			return null;
		}

		private void ClearFiltersBody()
		{
		}

		private void FillFiltersBody()
		{
		}

		private void AddMasterFilter()
		{
		}

		private void UpdateMasterFilter()
		{
		}

		private void ToggleAll(bool newState)
		{
		}

		private void UpdateSavedFilterList(string filter, bool isChecked)
		{
		}

		public bool IsExcluded(DebugAnalyticsLog log)
		{
			return false;
		}

		public IEnumerable<DebugAnalyticsLog> FilterEvents(IEnumerable<DebugAnalyticsLog> analyticsLogs)
		{
			return null;
		}
	}
}
