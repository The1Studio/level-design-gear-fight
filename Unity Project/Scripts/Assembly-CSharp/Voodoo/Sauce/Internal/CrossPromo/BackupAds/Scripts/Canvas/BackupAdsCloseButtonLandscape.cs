using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Canvas
{
	[RequireComponent(typeof(Button))]
	public class BackupAdsCloseButtonLandscape : MonoBehaviour
	{
		private Button _button;

		private RectTransform _rect;

		private ScreenOrientation _currentOrientation;

		[field: SerializeField]
		public float PortraitSize { get; private set; }

		[field: SerializeField]
		public float HorizontalSize { get; private set; }

		private void OnEnable()
		{
		}

		public void Update()
		{
		}

		private void UpdateButtonSize()
		{
		}
	}
}
