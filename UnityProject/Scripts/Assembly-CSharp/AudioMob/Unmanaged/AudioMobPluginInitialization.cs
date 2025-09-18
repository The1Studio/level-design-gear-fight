using System;
using AudioMob.Internal;
using UnityEngine;

namespace AudioMob.Unmanaged
{
	public class AudioMobPluginInitialization
	{
		public static IMediationAdapterSdk MediationAdapterSdk { private get; set; }

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void InitializePluginAutomatically()
		{
		}

		public static void InitializePlugin(Action<bool> callback = null)
		{
		}

		private static void InvokeInitCallback(Action<bool> callback, bool initSuccess)
		{
		}
	}
}
