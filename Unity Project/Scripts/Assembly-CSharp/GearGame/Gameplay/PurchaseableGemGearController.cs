using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class PurchaseableGemGearController : MonoBehaviour, ICustomGearInformationReceiver
	{
		[SerializeField]
		private GemTransactionHelper transactionHelper;

		[SerializeField]
		private Transform[] gearGFX;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private ParticleSystem system;

		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private Transform scalerTransform;

		[SerializeField]
		private float tapRange;

		private const int gemCost = 10;

		private GearController attachedGear;

		private float beginTapTime;

		private bool isAttached;

		private bool hasPurchased;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void TryBuy()
		{
		}

		public void Detach()
		{
		}

		public void InformationReceived(string[] information, GearPeg targetPeg, bool _)
		{
		}

		public void FreezeGear(GearController controller)
		{
		}
	}
}
