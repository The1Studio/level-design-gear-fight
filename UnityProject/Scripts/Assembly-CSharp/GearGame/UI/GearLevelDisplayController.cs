using DG.Tweening;
using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.UI
{
	public class GearLevelDisplayController : MonoBehaviour
	{
		[SerializeField]
		private bool doDisplayIncrementAnimation;

		[SerializeField]
		private TextMeshProUGUI levelDisplayText;

		private ScriptableGear attachedGear;

		private Tween incrementTween;

		private Tween scalerTween;

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize(ScriptableGear gear)
		{
		}

		private void Unlocked(ScriptableGear gear)
		{
		}

		private void Unsubscribe()
		{
		}

		private void GearNumberChanged(ScriptableGear gear, int _)
		{
		}
	}
}
