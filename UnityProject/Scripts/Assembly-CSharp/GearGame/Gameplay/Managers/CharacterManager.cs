using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GearGame.Gameplay.Managers
{
	public abstract class CharacterManager : MonoBehaviour
	{
		public readonly List<TroopController> AllCharacters;

		[SerializeField]
		protected Vector2 ySpawnRange;

		[SerializeField]
		protected AudioSource successSource;

		public Vector2 YSpawnRange => default(Vector2);

		public event Action<TroopController> OnCharacterKilled
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

		public event Action<TroopController> OnCharacterSpawned
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

		private void OnDrawGizmosSelected()
		{
		}

		public TroopController GetNearest(Vector2 position, bool allowTargetingBehind = false)
		{
			return null;
		}

		public void ClearNow(bool ignoreStructures = false)
		{
		}

		public virtual void AddCharacterToList(TroopController characterSpawn)
		{
		}

		protected void CharacterKilled(TroopController character)
		{
		}

		public virtual void OnFightFinished()
		{
		}

		public float GetYSpawn()
		{
			return 0f;
		}

		public Vector2 GetSpawnRange()
		{
			return default(Vector2);
		}
	}
}
