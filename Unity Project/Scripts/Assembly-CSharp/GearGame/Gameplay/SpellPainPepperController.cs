using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellPainPepperController : MonoBehaviour
	{
		[SerializeField]
		private AudioSourceVariable chompSource;

		[SerializeField]
		private SimpleDOTController flamingDOTController;

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
