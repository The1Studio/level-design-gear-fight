using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Misc;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopHealthController : MonoBehaviour
	{
		public delegate double DamageTakenPassthrough(double incomingDamage, float critMultiplier, TroopController attackingMeleeCharacter);

		public delegate double HealingPassthrough(double incomingHeal);

		[SerializeField]
		private TroopAnimationController animationController;

		[SerializeField]
		private bool doSpawnHealthBar;

		[SerializeField]
		[Tooltip("The local position of the health bar after parenting to the game object that this component is attached to")]
		private Vector3 healthBarOffset;

		[SerializeField]
		private GameObject healthBarPrefabOverride;

		[SerializeField]
		private bool healthBarEnabledByDefault;

		[SerializeField]
		private bool reflectDamage;

		[SerializeField]
		private float reflectPercent;

		private readonly List<SimpleDOTController> managedDOTs;

		private float lastDamageDisplayTime;

		private HealthBarController healthBar;

		private TextMeshPro lastText;

		private double damageSum;

		private float dodge;

		public DamageTakenPassthrough DamageTakenPassthroughOverride { get; set; }

		public HealingPassthrough HealPassthroughOverride { get; set; }

		public double Shielding { get; private set; }

		public double Health { get; private set; }

		public double MaxHealth { get; private set; }

		public double LastHealth { get; private set; }

		public bool Alive { get; private set; }

		public IList<SimpleDOTController> ManagedDOTs => null;

		public event Action<TroopHealthController> OnKilled
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

		public event Action<TroopHealthController, double> OnHealthChanged
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

		public event Action<TroopHealthController, double> OnMaxHealthChanged
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

		public event Action<TroopHealthController, double> OnShieldingChanged
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

		private void OnValidate()
		{
		}

		public void SetDamageReflection(float amount)
		{
		}

		public void SetDodge(float dodge)
		{
		}

		public void DamageThis(double negativeDamage, float critMultiplier, TroopController meleeAttackingCharacter)
		{
		}

		public double GetHealthPercentage()
		{
			return 0.0;
		}

		public void IncrementHealth(double increment)
		{
		}

		public void IncrementShield(double increment)
		{
		}

		public void ClearShielding()
		{
		}

		public virtual void KillThis()
		{
		}

		public void IncrementMaxHealth(double increment)
		{
		}

		public void SetHealth(double health)
		{
		}

		public void DelaySetHealth(double health)
		{
		}

		public void AddManagedDOT(SimpleDOTController simpleDOTController)
		{
		}

		public void RemoveManagedDOT(SimpleDOTController simpleDOTController)
		{
		}
	}
}
