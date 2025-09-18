using System;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Ads
{
	[RequireComponent(typeof(RectTransform), typeof(AspectRatioFitter), typeof(Image))]
	[ExecuteInEditMode]
	public class NativeAdsBehaviour : MonoBehaviour
	{
		private const string TAG = "NativeAdsBehaviour";

		[SerializeField]
		private string adPlacement;

		[SerializeField]
		private NativeAdLayout layout;

		private RectTransform _rectTransform;

		private Canvas _canvas;

		private NativeAdLayout? _appliedLayout;

		private string _displayedAdPlacement;

		private Guid _id;

		private void Awake()
		{
		}

		private void SetupAspectRatio()
		{
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

		private void ShowAfterVoodooSauceInit(VoodooSauceInitCallbackResult result)
		{
		}

		private void OnDisable()
		{
		}
	}
}
