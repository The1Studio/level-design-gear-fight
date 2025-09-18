using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearSellingController : MonoBehaviour
	{
		private static GearSellingController instance;

		[SerializeField]
		private TextMeshPro displayCostText;

		[SerializeField]
		private Animator anim;

		private bool sellingStatus;

		public static GearSellingController Instance => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void HeldGearChanged(GearController gear)
		{
		}

		public void OnSell()
		{
		}

		public void SetHoveringStatus(bool status)
		{
		}
	}
}
