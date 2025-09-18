using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class FlyTrapMeat : MonoBehaviour
	{
		[SerializeField]
		private AudioSourceVariable chompSource;

		[SerializeField]
		private float yOffset;

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

		public void SetTarget(TroopController targetCharacter)
		{
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}
	}
}
