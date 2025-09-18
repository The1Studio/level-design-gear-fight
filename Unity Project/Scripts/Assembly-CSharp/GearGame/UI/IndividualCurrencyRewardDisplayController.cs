using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class IndividualCurrencyRewardDisplayController : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI currencyAmountDisplayText;

		[SerializeField]
		private Image displayImage;

		public void Initialize(CurrencySO currency, double amount)
		{
		}
	}
}
