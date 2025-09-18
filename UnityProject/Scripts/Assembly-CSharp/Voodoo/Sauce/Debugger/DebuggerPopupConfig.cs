using System;

namespace Voodoo.Sauce.Debugger
{
	public class DebuggerPopupConfig
	{
		public string title;

		public string message;

		public bool showCancelButton;

		public string cancelText;

		public Action cancelCallback;

		public bool showConfirmButton;

		public string confirmText;

		public Action confirmCallback;

		public bool showIdfv;

		public string idfv;

		public bool showIdfa;

		public string idfa;
	}
}
