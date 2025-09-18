using System;
using System.Runtime.CompilerServices;
using GearGame.Purchasing;
using UnityEngine;

namespace GearGame.SingleLoad
{
	public class IAPInitializationHelper : MonoBehaviour
	{
		private static IAPInitializationHelper instance;

		private IAPPurchaseHandler purchaseHandler;

		public static IAPInitializationHelper Instance => null;

		public event Action RestorePurchasesFinished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void RaiseRestorePurchasesFinished()
		{
		}
	}
}
