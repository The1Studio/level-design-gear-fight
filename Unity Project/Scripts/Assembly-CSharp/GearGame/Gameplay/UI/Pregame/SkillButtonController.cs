using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GearGame.Gameplay.UI.Pregame
{
	public class SkillButtonController : MonoBehaviour
	{
		public enum ProceduralValueType
		{
			None = 0,
			Health = 1,
			Damage = 2
		}

		public enum UnlockType
		{
			Skill = 0,
			Gear = 1,
			Currency = 2,
			TierEvolve = 3
		}

		[CompilerGenerated]
		private sealed class _003CDelayCallback_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkillButtonController _003C_003E4__this;

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
			public _003CDelayCallback_003Ed__69(int _003C_003E1__state)
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

		public UnityEvent OnClickCantAfford;

		public UnityEvent UnlockedCallback;

		public static int[] PricingByTier;

		[SerializeField]
		private Canvas canvas;

		[SerializeField]
		private AudioSource lockedSource;

		[SerializeField]
		private AudioSource purchasedSource;

		[SerializeField]
		private SkillButtonController unlocksAfter;

		[SerializeField]
		private TextMeshProUGUI incrementText;

		[SerializeField]
		private TextMeshProUGUI unlockCostText;

		[SerializeField]
		private CurrencySO currency;

		[SerializeField]
		private SkillButtonController[] unlocksAfterAdditional;

		[SerializeField]
		private GameObject inactiveParent;

		[SerializeField]
		private GameObject yesAffordParent;

		[SerializeField]
		private GameObject noAffordParent;

		[SerializeField]
		private GameObject activeParent;

		[SerializeField]
		private GameObject lockedParent;

		[SerializeField]
		private ProceduralValueType proceduralValueType;

		[SerializeField]
		private UnlockType thisUnlockType;

		[SerializeField]
		private ScriptableSkill skill;

		[SerializeField]
		private ScriptableGear[] allGears;

		[SerializeField]
		private GameObject tierToActivate;

		[SerializeField]
		private int associatedLevel;

		[SerializeField]
		private double cost;

		[SerializeField]
		private double increment;

		[SerializeField]
		private float barFillPosition;

		private int startingCanvasSortingLayer;

		private bool locked;

		private Coroutine callbackDelay;

		[field: SerializeField]
		public string GUID { get; private set; }

		public SkillCanvasController.SkillSection SkillSection { get; set; }

		public bool Unlocked { get; private set; }

		public ScriptableSkill Skill => null;

		public bool Locked => false;

		public double Cost => 0.0;

		public double Increment => 0.0;

		public bool UseCustomLevel => false;

		public bool UseProceduralValueType => false;

		public event Action<SkillButtonController> OnUnlockedDelayCallback
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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetValues()
		{
		}

		public void GetLevelFromHirearchy(int offset, float multiplierPer)
		{
		}

		private void ValueChanged(double value)
		{
		}

		public void CheckUnlocked()
		{
		}

		public void TryGetUnlocksAfter()
		{
		}

		private void AfterUnlocked(SkillButtonController obj)
		{
		}

		public void Refresh()
		{
		}

		public void Unlock()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayCallback_003Ed__69))]
		private IEnumerator DelayCallback()
		{
			return null;
		}

		private void InvokeUnlockCallback()
		{
		}

		public void GenerateGUID()
		{
		}

		public void OnPressed()
		{
		}

		public void ResetLayerID()
		{
		}

		public void SetLayer(int layerID)
		{
		}
	}
}
