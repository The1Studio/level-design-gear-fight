using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.Sauce.Privacy
{
	public static class IdfaAuthorizationConfig
	{
		private const string TAG = "IdfaAuthorizationConfig";

		private static IdfaAuthorizationPopupLocalisation _popup;

		public static IdfaAuthorizationPopupLocalisation Popup => null;

		public static T Get<T>(SystemLanguage language, List<T> popupLocalisations = null) where T : IdfaAuthorizationAbstractPopupLocalisation, new()
		{
			return null;
		}

		public static List<SystemLanguage> GetLanguages<T>() where T : IdfaAuthorizationAbstractPopupLocalisation, new()
		{
			return null;
		}
	}
}
