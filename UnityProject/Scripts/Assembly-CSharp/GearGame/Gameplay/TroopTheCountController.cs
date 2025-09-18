using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopTheCountController : TroopController
	{
		private class ParticleDelay
		{
			[field: SerializeField]
			public ParticleSystem System { get; private set; }

			[field: SerializeField]
			public AudioSourceVariable Source { get; private set; }

			[field: SerializeField]
			public float Delay { get; private set; }

			[field: SerializeField]
			public bool DoSpawn { get; private set; }
		}

		[CompilerGenerated]
		private sealed class _003CDelaySpawn_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ParticleDelay delay;

			public TroopTheCountController _003C_003E4__this;

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
			public _003CDelaySpawn_003Ed__11(int _003C_003E1__state)
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

		private TheCountData _data;

		[SerializeField]
		private Transform rootSystem;

		[SerializeField]
		private ParticleDelay[] allDelays;

		[SerializeField]
		private ScriptableTroop spawnObject;

		private float specialAttackCooldown;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CDelaySpawn_003Ed__11))]
		private IEnumerator DelaySpawn(ParticleDelay delay)
		{
			return null;
		}
	}
}
