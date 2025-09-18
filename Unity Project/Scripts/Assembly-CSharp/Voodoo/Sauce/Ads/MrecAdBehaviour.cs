using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Ads
{
	public class MrecAdBehaviour : MonoBehaviour
	{
		private const string TAG = "MrecBehaviour";

		private static readonly Vector2 MrecAdSize;

		private static readonly Vector2 MediumDeviceSize;

		[SerializeField]
		private string adPlacement;

		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private ContentSizeFitter contentSizeFitter;

		[SerializeField]
		private LayoutElement layoutElement;

		[SerializeField]
		private TextMeshProUGUI textComponent;

		private Canvas _canvas;

		private string _displayedAdPlacement;

		private Vector2 _nativeScreenResolution;

		private void Awake()
		{
		}

		private void InitializeComponents()
		{
		}

		private void InitializeMrecAd()
		{
		}

		private bool ShouldInitializeMrecAd()
		{
			return false;
		}

		private Canvas ParentCanvas()
		{
			return null;
		}

		private void SetupSize()
		{
		}

		internal static Vector2 GetMrecPlaceholderSize()
		{
			return default(Vector2);
		}

		private void UpdateText()
		{
		}

		private void OnRenderObject()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnVoodooSauceInitFinished(VoodooSauceInitCallbackResult result)
		{
		}

		private void PreloadMrecAd()
		{
		}

		public void ActivateMrecAd()
		{
		}

		public void DeactivateMrecAd()
		{
		}

		public void ShowMrecAd()
		{
		}

		private Vector2 GetResolutionScaledToOriginalRatio()
		{
			return default(Vector2);
		}

		private void FetchAndCacheNativeScreenSize()
		{
		}
	}
}
