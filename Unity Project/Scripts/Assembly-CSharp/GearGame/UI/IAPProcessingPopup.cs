using Core.UI;
using UnityEngine;
using Voodoo.Sauce.IAP;

namespace GearGame.UI
{
	public class IAPProcessingPopup : Popup
	{
		[SerializeField]
		private Animator anim;

		protected void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void PurchaseConcluded(ProductReceivedInfo _, bool __)
		{
		}
	}
}
