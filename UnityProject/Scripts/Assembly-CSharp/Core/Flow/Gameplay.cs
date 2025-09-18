using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace Core.Flow
{
	public class Gameplay : Mode
	{
		[CompilerGenerated]
		private sealed class _003CDOWaitUntilGameState_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameStateManager.GameState state;

			public Action callback;

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
			public _003CDOWaitUntilGameState_003Ed__18(int _003C_003E1__state)
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
		private AllyManager _allyManager;

		[SerializeField]
		private EnemyManager _enemyManager;

		[SerializeField]
		private GameWorldManager2D _gameWorldManager;

		[SerializeField]
		private GameWorldStatsManager _gameWorldStatsManager;

		[SerializeField]
		private GameProgressManager _gameProgressManager;

		[SerializeField]
		private GameProgressSaveManager _gameProgressSaveManager;

		protected override void OnEnterInternal()
		{
		}

		private void SetToStore()
		{
		}

		private void StartFight()
		{
		}

		private void TrackStartWave()
		{
		}

		private void RegisterToEvents()
		{
		}

		private void OnEnemyKilled(TroopController enemy)
		{
		}

		private void OnStructureDestroyed(TroopHealthController healthController)
		{
		}

		private void FinishFight()
		{
		}

		private void ProgressForward(float delay)
		{
		}

		private void WinFight()
		{
		}

		private void LoseFight()
		{
		}

		private void WaitUntilGameState(GameStateManager.GameState state, Action callback)
		{
		}

		[IteratorStateMachine(typeof(_003CDOWaitUntilGameState_003Ed__18))]
		private IEnumerator DOWaitUntilGameState(GameStateManager.GameState state, Action callback)
		{
			return null;
		}

		private void UnregisterFromEvents()
		{
		}

		protected override void OnExitInternal()
		{
		}

		public void CheatWinFight()
		{
		}

		public void CheatLoseFight()
		{
		}

		public void WinWave()
		{
		}
	}
}
