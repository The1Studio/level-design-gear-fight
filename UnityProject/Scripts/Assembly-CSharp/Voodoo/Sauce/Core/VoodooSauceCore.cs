using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Voodoo.Sauce.CrashReport;
using Voodoo.Sauce.IAP;
using Voodoo.Sauce.Internal.IntegrationCheck;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Core
{
	internal static class VoodooSauceCore
	{
		private const string TAG = "VoodooSauceCore";

		internal static readonly IAPMediator Iap;

		private static readonly PrivacyCore _privacy;

		private static readonly CrashReportCore _crashReport;

		private static readonly List<IModule> _moduleList;

		private static VoodooSauceBehaviour _voodooSauceBehaviour;

		private static TModule InstantiateModule<TModule>() where TModule : class, IModule, new()
		{
			return null;
		}

		private static TModule GetModuleInstance<TModule>(TModule moduleInstance, bool logWarning) where TModule : class, IModule, new()
		{
			return null;
		}

		[CanBeNull]
		private static TParentClass InstantiateChildClass<TParentClass>() where TParentClass : class
		{
			return null;
		}

		static VoodooSauceCore()
		{
		}

		public static void Initialize(VoodooSauceBehaviour voodooSauceBehaviour)
		{
		}

		public static List<IntegrationCheckMessage> IntegrationCheck()
		{
			return null;
		}

		public static Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		public static void StopCoroutine(IEnumerator routine)
		{
		}

		public static void StopCoroutine(Coroutine coroutine)
		{
		}

		internal static PrivacyCore GetPrivacy(bool logWarning = false)
		{
			return null;
		}

		internal static CrashReportCore GetCrashReport(bool logWarning = false)
		{
			return null;
		}
	}
}
