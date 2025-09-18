using GearGame.Gameplay.Managers;
using UnityEngine;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.IAP;

namespace GearGame.UI
{
	public class SpeedUpButtonActivationController : MonoBehaviour
	{
		[SerializeField]
		private GameObject activeRoot;

		[SerializeField]
		private GameObject inactiveRoot;

		[SerializeField]
		private Animator anim;

		private readonly int activeHash;

		private bool isOwned;

		private bool isEnabled;

		private int numberToShow;

		protected void Start()
		{
		}

		protected void OnDestroy()
		{
		}

		public void OnPressed()
		{
		}

		protected void InitializationCompleted(bool status)
		{
		}

		private void PurchaseConcluded(ProductReceivedInfo product, bool status)
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		protected void PurchaseCompleted()
		{
		}

		private void OnDoubleSpeedStatusChanged(bool status)
		{
		}

		private void SetOwnedStatus(bool status)
		{
		}

		private void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
		{
		}
	}
}
