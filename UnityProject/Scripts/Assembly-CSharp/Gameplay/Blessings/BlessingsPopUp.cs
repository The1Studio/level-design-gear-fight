using Core.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Blessings
{
	public class BlessingsPopUp : Popup
	{
		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private BlessingsDisplay[] _blessingsDisplays;

		[SerializeField]
		private GameObject _HCDisplay;

		[SerializeField]
		private BlessingIAPController _blessingIAPController;

		protected void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToBlessingsEvents()
		{
		}

		private void UnsubscribeFromBlessingsEvents()
		{
		}

		private void OnBlessingEnded(BlessingData obj)
		{
		}

		private void OnEnable()
		{
		}

		private void RefreshBlessingsDisplay()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
