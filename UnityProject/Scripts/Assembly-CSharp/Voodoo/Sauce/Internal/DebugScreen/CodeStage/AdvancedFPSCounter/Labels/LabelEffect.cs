using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.Labels
{
	internal class LabelEffect
	{
		public bool enabled;

		public Color color;

		public Vector2 distance;

		public int padding;

		internal LabelEffect(bool enabled, Color color, int padding)
		{
		}

		internal LabelEffect(bool enabled, Color color, Vector2 distance)
		{
		}
	}
}
