using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace IapOffers.Views
{
	internal class IapOfferRewardView : MonoBehaviour
	{
		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _amount;

		[SerializeField]
		private GameObject _checkmark;

		public void Display(Sprite icon, double amount, bool isClaimed)
		{
		}
	}
}
