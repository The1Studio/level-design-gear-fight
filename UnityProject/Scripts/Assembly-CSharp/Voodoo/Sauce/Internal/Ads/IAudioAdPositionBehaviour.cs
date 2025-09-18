using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	public interface IAudioAdPositionBehaviour
	{
		Canvas Canvas { get; }

		RectTransform RectTransform { get; }

		bool IsActiveAndEnabled { get; }

		Vector2 GetPercentPosition();
	}
}
