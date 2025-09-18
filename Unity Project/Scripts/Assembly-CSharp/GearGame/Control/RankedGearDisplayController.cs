using GearGame.UI;
using TMPro;
using UnityEngine;

namespace GearGame.Control
{
	public class RankedGearDisplayController : IndividualGearDisplayController
	{
		[SerializeField]
		private TextMeshProUGUI rankDisplayText;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private string localizationString;

		public void SetRank(int rank)
		{
		}

		public void Activate(bool instant)
		{
		}
	}
}
