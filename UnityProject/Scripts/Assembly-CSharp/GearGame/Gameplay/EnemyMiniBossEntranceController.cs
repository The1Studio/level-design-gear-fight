using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class EnemyMiniBossEntranceController : MonoBehaviour
	{
		[Serializable]
		public class ActionPhase
		{
			[field: SerializeField]
			public GameObject Rocks { get; private set; }

			[field: SerializeField]
			public MMF_Player FeedbackPlayer { get; private set; }

			[field: SerializeField]
			public ParticleSystem ExplodeSystem { get; private set; }

			[field: SerializeField]
			public float DelayBefore { get; private set; }
		}

		[CompilerGenerated]
		private sealed class _003CRunAnimation_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyMiniBossEntranceController _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CRunAnimation_003Ed__4(int _003C_003E1__state)
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
		private ActionPhase[] allPhases;

		private void Awake()
		{
		}

		public Coroutine Initialize(EnemyMiniBossController enemyMiniBossController)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRunAnimation_003Ed__4))]
		private IEnumerator RunAnimation()
		{
			return null;
		}
	}
}
