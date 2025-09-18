using GearGame.Control;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay
{
	public class SpellRaiseUndeadSpinnerController : MonoBehaviour
	{
		[SerializeField]
		private Transform rotationHelper;

		[SerializeField]
		private Transform actualRotator;

		[SerializeField]
		private Image radialFillImage;

		[SerializeField]
		private ScriptableTroop summonCharacter;

		[SerializeField]
		private GameObject groundBurst;

		[SerializeField]
		private float offset;

		private float percentChance;

		public void Initialize(float percent, TroopController enemy)
		{
		}

		public void OnRotationFinished()
		{
		}
	}
}
