using UnityEngine;
using UnityEngine.Rendering;

namespace GearGame.Gameplay
{
	[ExecuteAlways]
	public class TroopSortingController : MonoBehaviour
	{
		public enum SortingType
		{
			ZPosition = 0,
			Group = 1,
			Particle = 2,
			Script = 3
		}

		[SerializeField]
		private SortingType sortingType;

		[SerializeField]
		private Transform transformOverride;

		[SerializeField]
		private SortingGroup sortingGroup;

		[SerializeField]
		private ParticleSystem particleSystem;

		[SerializeField]
		private bool updateAlways;

		private ParticleSystemRenderer particleSystemRenderer;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void UpdateSorting(float yPositionFromScript = 0f)
		{
		}
	}
}
