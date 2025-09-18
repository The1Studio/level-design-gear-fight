using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellPickAxeController : MonoBehaviour
	{
		[SerializeField]
		private SpellSwordController sliceController;

		[SerializeField]
		private Vector2 offset;

		[SerializeField]
		private Animator anim;

		private float currentLerp;

		private Vector3 startingPosition;

		private GearStoneController targetMineGear;

		private bool isMining;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}

		private void LateUpdate()
		{
		}

		public void OnSlice()
		{
		}

		public void AnimationCompleted()
		{
		}
	}
}
