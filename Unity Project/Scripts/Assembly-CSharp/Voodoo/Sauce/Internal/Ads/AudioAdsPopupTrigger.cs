using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	public class AudioAdsPopupTrigger : MonoBehaviour
	{
		[SerializeField]
		private AudioAdsPopup _popupPrefab;

		private AudioAdsPopup _popup;

		private static AudioAdsPopupTriggerLogic _logic;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Show()
		{
		}

		private void TryInitializeLogic()
		{
		}

		private void TryTriggerPopup()
		{
		}

		[ContextMenu("OnUserClose")]
		private void OnUserClose()
		{
		}
	}
}
