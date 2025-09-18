using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	[RequireComponent(typeof(GearTroopSpawnerReferenceContainer))]
	public abstract class GearTroopSpawnerController : GearSpawnerController
	{
		[CompilerGenerated]
		private sealed class _003CDelaySendHealthData_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopController c;

			public GearTroopSpawnerController _003C_003E4__this;

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
			public _003CDelaySendHealthData_003Ed__16(int _003C_003E1__state)
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
		private ScriptableTroop troop;

		protected GearTroopSpawnerReferenceContainer gearTroopSpawnerReferenceContainer;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public ScriptableTroop Troop => null;

		public override bool CanBeFrozen => false;

		protected override float MaxProduction => 0f;

		public event Action<TroopController> CharacterSpawned
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

		protected override void Awake()
		{
		}

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}

		protected override void ObjectSpawned(GameObject go)
		{
		}

		[IteratorStateMachine(typeof(_003CDelaySendHealthData_003Ed__16))]
		private IEnumerator DelaySendHealthData(TroopController c)
		{
			return null;
		}
	}
}
