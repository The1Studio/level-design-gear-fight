using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;
using Voodoo.Live.Shop.Data;

namespace Data.Shop
{
	public static class ShopUtility
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownloadSpriteAsyncWithCallback_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string url;

			public Action<Sprite> onSpriteReady;

			private UnityWebRequest _003Cuwr_003E5__2;

			private UnityWebRequestAsyncOperation _003CasyncOp_003E5__3;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static Price ToShopPrice(this Voodoo.Live.Shop.Data.Price price)
		{
			return default(Price);
		}

		public static RewardStruct ToShopRewardStruct(this RewardItem rewardItem)
		{
			return default(RewardStruct);
		}

		[AsyncStateMachine(typeof(_003CDownloadSpriteAsyncWithCallback_003Ed__2))]
		public static void DownloadSpriteAsyncWithCallback(string url, Action<Sprite> onSpriteReady)
		{
		}
	}
}
