using TMPro;
using UnityEngine;

namespace GearGame.UI
{
	public class PackSpecificIndividualGearDisplay : IndividualGearDisplayController
	{
		[SerializeField]
		private string localizationString;

		[SerializeField]
		private TextMeshProUGUI lockedReasonString;

		[SerializeField]
		private TextMeshProUGUI lockedLevel;

		public void SetLockTextRank(int rank)
		{
		}
	}
}
