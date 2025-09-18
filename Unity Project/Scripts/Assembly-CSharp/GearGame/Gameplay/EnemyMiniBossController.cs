using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class EnemyMiniBossController : EnemyStructureController
	{
		[CompilerGenerated]
		private sealed class _003CDelayStart_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyMiniBossController _003C_003E4__this;

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
			public _003CDelayStart_003Ed__22(int _003C_003E1__state)
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
		private Sprite headSprite;

		[SerializeField]
		private Transform headSpawnTransform;

		[SerializeField]
		private TroopAnimationController animationController;

		[SerializeField]
		private float startingDelay;

		[SerializeField]
		private EnemyMiniBossEntranceController entranceController;

		[SerializeField]
		private GameObject rootDisplayObject;

		[SerializeField]
		private GameObject rootShadowObject;

		[SerializeField]
		private AudioSource bossMusic;

		[SerializeField]
		private AudioSource dieSoundEffect;

		private readonly int hashHit;

		private Action _onAfterKillAnimationCallback;

		public static bool MiniBossThisWave { get; set; }

		public static bool MiniBossDefeatedThisWave { get; set; }

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayStart_003Ed__22))]
		private IEnumerator DelayStart()
		{
			return null;
		}

		protected override void OnKilled(TroopHealthController healthController)
		{
		}

		public override void SetCallbackToOnAfterKillAnimation(Action callback)
		{
		}
	}
}
