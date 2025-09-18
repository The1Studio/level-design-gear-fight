using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.UI;
using DG.Tweening;
using GearGame.UI;
using Items;
using UI.Shop;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Sample.Shop.UI;
using Voodoo.Live.Shop.Data;

namespace GearGame.Purchasing
{
	public class IAPCanvasController : Core.UI.Screen
	{
		[CompilerGenerated]
		private sealed class _003CDelayChangeScrollRectPosition_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IAPCanvasController _003C_003E4__this;

			public ScrollRect.MovementType previous;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelayChangeScrollRectPosition_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static IAPCanvasController instance;

		[SerializeField]
		private ShopButton _largeShopButtonPrefab;

		[SerializeField]
		private GameObject packUnlockPrefab;

		[SerializeField]
		private Transform contentTransform;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private GameObject[] deactivateUntilGearDeckBuilding;

		[SerializeField]
		private GameObject[] deactivateUntilSkipTickets;

		[SerializeField]
		private GameObject[] deactivateUntilBoth;

		[SerializeField]
		private float motionTime;

		[SerializeField]
		private ShopSectionUI shopSectionUIPrefab;

		[SerializeField]
		private ShopSectionUI[] _sections;

		public bool UseVLShop;

		private ScrollRect.MovementType startingType;

		private Tween currentMotion;

		private GameShop _gameShop;

		public static IAPCanvasController Instance => null;

		private void CreateSingleton()
		{
		}

		protected void Awake()
		{
		}

		private void OnEnable()
		{
		}

		protected void Start()
		{
		}

		private void InitVoodooLiveShop()
		{
		}

		public void MoveToPosition(Transform t)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayChangeScrollRectPosition_003Ed__23))]
		private IEnumerator DelayChangeScrollRectPosition(ScrollRect.MovementType previous, Vector3 finalPosition)
		{
			return null;
		}

		public void ActivateMiniGearOpeningCanvas(int number, PackOpeningCanvasController.ChestDisplay chestDisplay, TransactionLocation transactionLocation)
		{
		}

		private ShopSectionUI NameToSection(string sectionName)
		{
			return null;
		}

		public void OnShopButtonClickedButCannotAfford(ShopButton clickedButton)
		{
		}

		private void MoveToSection(string section)
		{
		}

		public void MoveToRVTicketsSection()
		{
		}

		public void MoveToGemsSection()
		{
		}

		public void MoveToSection(ShopShortcut shortcut)
		{
		}
	}
}
