using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Internal.Ads
{
	public class BannerBackground : MonoBehaviour
	{
		public Image background;

		public GameObject purchasePopup;

		public Button leftCloseButton;

		public Button rightCloseButton;

		public Button purchaseButton;

		public Button cancelButton;

		public TextMeshProUGUI bodyText;

		public TextMeshProUGUI purchaseButtonText;

		public TextMeshProUGUI cancelButtonText;

		public CanvasScaler canvasScaler;

		private const int IOS_BANNER_HEIGHT = 150;

		private const int ANDROID_BANNER_HEIGHT = 168;

		private int _bannerHeight;

		private static BannerBackground _instance;

		private static Vector2 _nativeScreenResolution;

		private static bool _enableAutomaticBannerHeightAdjustment;

		private static RectTransform _closeButtonRectTransform;

		private RectTransform _backgroundRect;

		public static event Action OnShown
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnHidden
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		internal static void Hide()
		{
		}

		internal static void Show(Color color)
		{
		}

		private static void Initialize()
		{
		}

		internal static void UpdateHeight(float height, float screenDensity)
		{
		}

		private void SetupCloseButton(VoodooSettings voodooSettings)
		{
		}

		private static bool ShouldShowCloseButton(VoodooSettings voodooSettings)
		{
			return false;
		}

		private void OnPurchaseButtonClicked(VoodooSettings voodooSettings)
		{
		}

		private void OnPurchaseComplete()
		{
		}

		private void SetCloseButton(VoodooSettings.Position position, Sprite sprite)
		{
		}

		private void OnCloseButtonClick()
		{
		}

		private void OnCancelButtonClick()
		{
		}

		private void SetupEditorCanvasScaler()
		{
		}

		private void SetColor(Color color)
		{
		}

		private void ApplyHeight(int height)
		{
		}

		private static void AdaptCloseButtonSizeToRatio(Vector2 ratio)
		{
		}
	}
}
