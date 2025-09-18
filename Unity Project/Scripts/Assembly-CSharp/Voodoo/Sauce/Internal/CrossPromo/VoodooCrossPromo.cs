using System;
using Voodoo.Sauce.Internal.CrossPromo.Configuration;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo
{
	internal static class VoodooCrossPromo
	{
		public const string TAG = "CrossPromotion";

		public static CrossPromoInfo Info;

		private static CrossPromoAPI _api;

		private static bool _isInit;

		private static CrossPromoConfigurationHelper _configurationHelper;

		private static Action<AssetModel> _onSuccess;

		private static Action<CPShowFailType> _onFailure;

		private static bool _showCalledBeforeInit;

		public static CrossPromoConfigurationHelper Configuration => null;

		public static void Init()
		{
		}

		private static void OnPremiumStatusChanged(bool value)
		{
		}

		private static void RegisterInternalCallbacks()
		{
		}

		public static void Show(Action<AssetModel> onSuccess, Action<CPShowFailType> onFailure)
		{
		}

		public static void Hide()
		{
		}

		private static void InvokeInitCompleteCallback_Internal(string format)
		{
		}

		private static void InvokeOnShownCallback_Internal(AssetModel asset)
		{
		}

		private static void InvokeOnClickCallback_Internal(AssetModel asset)
		{
		}

		private static void InvokeOnErrorReceivedCallback_Internal(Exception e)
		{
		}
	}
}
