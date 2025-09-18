using System;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellEggController : MonoBehaviour
	{
		[Serializable]
		public struct CharacterWeight
		{
			[field: SerializeField]
			public float Weight { get; private set; }

			[field: SerializeField]
			public ScriptableTroop ScriptableCharacter { get; private set; }
		}

		[SerializeField]
		private CharacterWeight[] characterProbabilities;

		[SerializeField]
		private GameObject crackObject;

		[SerializeField]
		private GameObject shadowObject;

		[SerializeField]
		private Rigidbody2D[] explodeBodies;

		[SerializeField]
		private float explodeForce;

		[SerializeField]
		private float torqueForce;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void Open()
		{
		}
	}
}
