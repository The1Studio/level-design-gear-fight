using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class AllGearsButtonController : MonoBehaviour
	{
		[SerializeField]
		private Animator[] animators;

		[SerializeField]
		private ContentSizeFitter sizeFitter;

		private bool isActive;

		public void OnPressed()
		{
		}

		public void RefreshFitter()
		{
		}
	}
}
