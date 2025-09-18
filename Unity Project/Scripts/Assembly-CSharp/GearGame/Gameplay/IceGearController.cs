using UnityEngine;

namespace GearGame.Gameplay
{
	public class IceGearController : MonoBehaviour, ICustomGearInformationReceiver
	{
		[SerializeField]
		private GameObject[] allCrackImages;

		[SerializeField]
		private ParticleSystem breakSystem;

		[SerializeField]
		private ParticleSystem crackSystem;

		[SerializeField]
		private AudioSourceVariable crackSource;

		[SerializeField]
		private AudioSourceVariable rotateSource;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private int rotationsNeeded;

		[SerializeField]
		private Transform scalerTransform;

		private readonly int animationRotate;

		private readonly int animationCrack;

		private int rotationCrackMax;

		private int rotationCrack;

		private int crackOn;

		private GearController attachedGear;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public void InformationReceived(string[] information, GearPeg targetPeg, bool _)
		{
		}

		public void FreezeGear(GearController controller)
		{
		}

		private void Break()
		{
		}

		private void GearRotated(GearController _)
		{
		}
	}
}
