using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.Utils
{
	[DisallowMultipleComponent]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		private bool recording;

		private float renderTime;

		private void OnPreCull()
		{
		}

		private void OnPostRender()
		{
		}
	}
}
