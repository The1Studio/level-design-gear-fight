using TMPro;
using UnityEngine;
using Voodoo.Live.Offers;

namespace Voodoo.Live.Utils
{
	public class Countdown : MonoBehaviour
	{
		private const string DaysLeftFormat = "{0} Days Left";

		private const string DaysLeftShortFormat = "{0} D";

		private const string HoursLeftFormat = "End in {0} Hours";

		private const string HoursLeftShortFormat = "{0} H";

		private const string HoursMinutesSecondsFormat = "Ends in {0:D2}:{1:D2}:{2:D2}";

		private const string HoursMinutesSecondsShortFormat = "{0:D2}:{1:D2}:{2:D2}";

		private const string MinutesSecondsFormat = "Ends in {0:D2}:{1:D2}";

		private const string MinutesSecondsShortFormat = "{0:D2}:{1:D2}";

		[SerializeField]
		[Header("Settings")]
		private bool _useShortTxt;

		[Header("References")]
		[SerializeField]
		private TextMeshProUGUI _countdownText;

		[SerializeField]
		private GameObject _container;

		private TimeConditions _activeTime;

		private string _message;

		public bool IsOver => false;

		public void Init(bool display, TimeConditions activeTime)
		{
		}

		private void Display(bool active)
		{
		}

		private void Update()
		{
		}
	}
}
