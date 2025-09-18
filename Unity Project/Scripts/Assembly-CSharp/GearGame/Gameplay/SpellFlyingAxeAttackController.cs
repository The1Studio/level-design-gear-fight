using DG.Tweening;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellFlyingAxeAttackController : MonoBehaviour
	{
		[SerializeField]
		private AnimationCurve firstMotionCurve;

		[SerializeField]
		private float firstMotionTime;

		[SerializeField]
		private AnimationCurve secondMotionCurve;

		[SerializeField]
		private float secondMotionHeight;

		[SerializeField]
		private float secondMotionTime;

		[SerializeField]
		private GameObject groundImpactPrefab;

		private Tween motionTween;

		private void Start()
		{
		}

		private TroopController FindRandomEnemy(TroopController tryExclude)
		{
			return null;
		}

		private void SpawnGroundImapact(Vector3 finalPosition)
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}
	}
}
