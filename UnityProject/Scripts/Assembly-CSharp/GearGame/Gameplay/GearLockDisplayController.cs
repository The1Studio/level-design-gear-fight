using UnityEngine;
using UnityEngine.Rendering;

namespace GearGame.Gameplay
{
	public class GearLockDisplayController : MonoBehaviour
	{
		[SerializeField]
		private SortingGroup[] associatedGroups;

		[SerializeField]
		private Rigidbody2D[] allBodies;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Transform scalerTransform;

		private GearController attachedGear;

		private void LateUpdate()
		{
		}

		public void Initialize(GearController gear)
		{
		}

		private void SelectionStatusChanged(GearController gear, bool status)
		{
		}

		private void TempStatusChanged(GearController attachedGear)
		{
		}
	}
}
