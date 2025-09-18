using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Common.Utils
{
	public class LandscapePadding : MonoBehaviour
	{
		public LandscapePaddingData preset;

		[Tooltip("If preset is filled, this value will not be used.")]
		public RectOffset landscapePadding;

		private RectOffset _defaultPadding;

		private bool _isLandscape;

		private LayoutGroup _layoutGroup;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private bool IsLandscape()
		{
			return false;
		}

		private void AddPadding()
		{
		}

		private void RemovePadding()
		{
		}
	}
}
