using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class PackWeakCanvasController : MonoBehaviour
	{
		[SerializeField]
		private ScriptableGemCostData gemCostData;

		[SerializeField]
		private TextMeshProUGUI costText;

		[SerializeField]
		private GameObject noAffordButton;

		[SerializeField]
		private GameObject yesAffordButton;

		[SerializeField]
		private CurrencySO gemCurrency;

		[SerializeField]
		private Image displayImage;

		private bool canAfford;

		private ScriptablePack pack;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Initialize(ScriptablePack pack)
		{
		}

		private void ValueChanged(double val)
		{
		}

		public void OnBuyButtonPressed()
		{
		}
	}
}
