using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class InGameCurrencyDisplayLayoutRebuilderHelper : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private VerticalLayoutGroup layoutGroup;

		private readonly int activeHash;

		private void OnAnimatorMove()
		{
		}
	}
}
