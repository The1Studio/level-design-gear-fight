using System.Collections.Generic;
using AssetKits.ParticleImage;
using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public class SkillStatDisplayController : MonoBehaviour
	{
		[SerializeField]
		private ScriptableSkill skill;

		[SerializeField]
		private ParticleImage particleBurst;

		[SerializeField]
		private TextMeshProUGUI valueDisplay;

		[SerializeField]
		private Animator anim;

		public static Dictionary<string, Vector3> activationPosition;

		private bool hasInitialized;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ValueChanged(double value)
		{
		}
	}
}
