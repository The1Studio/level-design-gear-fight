using System;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class FallingTroopController : FallingEntityController
	{
		[SerializeField]
		private VelocityProfile enemyVelocityProfile;

		[SerializeField]
		private SpriteRenderer displaySprite;

		private ScriptableTroop troop;

		private bool isAlly;

		private int level;

		private float healthMultiplier;

		private float damageMultiplier;

		public event Action<TroopController> OnSpawned
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

		public void Initialize(ScriptableTroop troop, bool isAlly, int level = -1, float healthMultiplier = 1f, float damageMultiplier = 1f)
		{
		}

		protected override void Convert()
		{
		}
	}
}
