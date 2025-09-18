using UnityEngine;

namespace Voodoo.Sauce.Tools.AccessButton
{
	public static class AccessProcess
	{
		public delegate void AccessButtonEvent();

		public static AccessButtonEvent InstantiateAccessButton;

		public static AccessButtonEvent DisposeAccessButton;

		public static GameObject ButtonInstance;

		private const string ACCESS_BUTTON_KEY = "accessButton";

		private const string TRUSTED_USER_KEY = "trustedUser";

		public static void SetTrustedUser(bool isTrusted)
		{
		}

		public static bool IsTrusted()
		{
			return false;
		}

		public static void SetAccess(bool hasAccess)
		{
		}

		public static bool HasAccess()
		{
			return false;
		}

		public static void CheckInstantiateButton()
		{
		}

		private static void CheckDisposeButton()
		{
		}
	}
}
