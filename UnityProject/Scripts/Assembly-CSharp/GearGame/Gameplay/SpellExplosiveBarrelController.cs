using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellExplosiveBarrelController : MonoBehaviour
	{
		[SerializeField]
		private float movementSpeed;

		[SerializeField]
		private float areaOfEffect;

		[SerializeField]
		private GameObject explosionObject;

		private TroopController _targetEnemy;

		private bool _hasExploded;

		private float _rightBoundTarget;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FindClosestEnemy()
		{
		}

		private void Explode()
		{
		}
	}
}
