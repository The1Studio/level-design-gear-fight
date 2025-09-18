namespace Voodoo.Sauce.Debugger
{
	public abstract class CustomDebugger
	{
		public virtual bool ReSetupScreenOnShown => false;

		public abstract string GetTitle();

		public abstract int GetOrderIndex();

		public abstract void SetupScreen(Screen screen);
	}
}
