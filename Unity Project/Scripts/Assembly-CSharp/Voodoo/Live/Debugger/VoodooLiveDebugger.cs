using Voodoo.Sauce.Debugger;

namespace Voodoo.Live.Debugger
{
	public class VoodooLiveDebugger : CustomDebugger
	{
		private DebugButtonWithInputField _button;

		public override string GetTitle()
		{
			return null;
		}

		public override int GetOrderIndex()
		{
			return 0;
		}

		public override void SetupScreen(Screen screen)
		{
		}

		private void VoodooLiveInitialized(Screen screen)
		{
		}

		private void ShowVoodooLiveDebugger()
		{
		}
	}
}
