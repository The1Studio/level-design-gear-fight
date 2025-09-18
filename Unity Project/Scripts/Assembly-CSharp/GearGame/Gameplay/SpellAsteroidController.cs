using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellAsteroidController : MonoBehaviour
	{
		[SerializeField]
		private GroundAOEEffect impactEffect;

		[SerializeField]
		private GroundAOEEffect groundBurnEffect;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}
	}
}
