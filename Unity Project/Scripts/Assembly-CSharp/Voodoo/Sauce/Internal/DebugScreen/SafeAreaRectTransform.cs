using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	[RequireComponent(typeof(RectTransform))]
	public class SafeAreaRectTransform : MonoBehaviour
	{
		[SerializeField]
		private bool ignoreNotch;

		private RectTransform _rectTransform;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void ApplySafeArea()
		{
		}
	}
}
