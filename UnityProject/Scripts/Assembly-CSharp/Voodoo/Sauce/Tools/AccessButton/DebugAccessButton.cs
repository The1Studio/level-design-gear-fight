using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Tools.AccessButton
{
	public class DebugAccessButton : DebugToggleComponent
	{
		protected override bool DefaultButtonState()
		{
			return false;
		}

		public override void SetEnabled(bool isEnabled)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
