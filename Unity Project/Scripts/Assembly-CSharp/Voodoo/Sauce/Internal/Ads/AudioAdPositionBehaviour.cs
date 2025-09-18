using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	[RequireComponent(typeof(RectTransform))]
	public class AudioAdPositionBehaviour : MonoBehaviour, IAudioAdPositionBehaviour
	{
		private const string TAG = "AudioAdPositionBehaviour";

		private static AudioAdPositionBehaviour _instance;

		private RectTransform _rectTransform;

		private Canvas _canvas;

		private RectTransform _canvasRectTransform;

		public Canvas Canvas => null;

		public RectTransform RectTransform => null;

		public bool IsActiveAndEnabled => false;

		private void Awake()
		{
		}

		public Vector2 GetPercentPosition()
		{
			return default(Vector2);
		}
	}
}
