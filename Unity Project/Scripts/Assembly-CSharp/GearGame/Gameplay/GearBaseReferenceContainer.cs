using GearGame.Control;
using UnityEngine;
using UnityEngine.Rendering;

namespace GearGame.Gameplay
{
	public class GearBaseReferenceContainer : MonoBehaviour
	{
		[field: SerializeField]
		public SpriteRenderer GearSpriteRenderer { get; private set; }

		[field: SerializeField]
		public Transform ScalerRoot { get; private set; }

		[field: SerializeField]
		public SortingGroup AssociatedGroup { get; private set; }

		[field: SerializeField]
		public ScriptableGear EvolveGear { get; private set; }

		[field: SerializeField]
		public Animator Anim { get; private set; }

		[field: SerializeField]
		public bool OverrideDisplayValue { get; private set; }

		[field: SerializeField]
		public string OverrideDisplay { get; private set; }

		[field: SerializeField]
		public Vector2Int[] AdditionalPegLocks { get; private set; }

		[field: SerializeField]
		public GearController.MotionBlockDirection AllMotionBlockDirections { get; set; }
	}
}
