using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	public class PinchableScrollRect : ScrollRect
	{
		[SerializeField]
		private float _minZoom;

		[SerializeField]
		private float _maxZoom;

		[SerializeField]
		private float _zoomLerpSpeed;

		private float _currentZoom;

		private bool _isPinching;

		private float _startPinchDist;

		private float _startPinchZoom;

		private Vector2 _startPinchCenterPosition;

		private Vector2 _startPinchScreenPosition;

		private float _mouseWheelSensitivity;

		private bool blockPan;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void SetContentAnchoredPosition(Vector2 position)
		{
		}

		private void OnPinchStart()
		{
		}

		private void OnPinch()
		{
		}

		private float Distance(Vector2 pos1, Vector2 pos2)
		{
			return 0f;
		}
	}
}
