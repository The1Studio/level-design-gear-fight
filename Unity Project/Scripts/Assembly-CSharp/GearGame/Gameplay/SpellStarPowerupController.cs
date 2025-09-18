using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellStarPowerupController : MonoBehaviour
	{
		[SerializeField]
		private AudioSourceVariable collectionSource;

		private TroopController targetCharacter;

		private float lerp;

		private Vector3 startingPosition;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}
	}
}
