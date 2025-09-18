using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellSnakeController : MonoBehaviour
	{
		private static SpellSnakeController instance;

		[SerializeField]
		private SnakeMonsterBodyController[] bodies;

		[SerializeField]
		private Animator anim;

		private readonly int nextHash;

		public static SpellSnakeController Instance => null;

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Trigger()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}
	}
}
