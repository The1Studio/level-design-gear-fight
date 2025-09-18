using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.UI;
using GearGame.Control;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI.Pregame
{
	public class SkillCanvasControllerLegacy : Core.UI.Screen
	{
		[CompilerGenerated]
		private sealed class _003CDelayChangeScrollRectPosition_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkillCanvasControllerLegacy _003C_003E4__this;

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
			public _003CDelayChangeScrollRectPosition_003Ed__12(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDelayMove_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkillCanvasControllerLegacy _003C_003E4__this;

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
			public _003CDelayMove_003Ed__10(int _003C_003E1__state)
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

		[SerializeField]
		protected SkillButtonController[] allSkillButtons;

		[SerializeField]
		protected CurrencySO gemCurrency;

		[SerializeField]
		protected Transform contentTransform;

		[SerializeField]
		protected ScrollRect scrollRect;

		public event Action<SkillButtonController> SkillButtonUnlocked
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

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayMove_003Ed__10))]
		private IEnumerator DelayMove()
		{
			return null;
		}

		private void JumpToButton(SkillButtonController buttonController)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayChangeScrollRectPosition_003Ed__12))]
		private IEnumerator DelayChangeScrollRectPosition(ScrollRect.MovementType previous, Vector3 finalPosition)
		{
			return null;
		}

		public virtual bool HasAvailableUpgrade(double additionalCoins)
		{
			return false;
		}

		protected virtual void ItemUnlocked(SkillButtonController button)
		{
		}
	}
}
