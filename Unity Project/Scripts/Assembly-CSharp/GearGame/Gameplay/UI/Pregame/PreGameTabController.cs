using Core.UI;
using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public abstract class PreGameTabController : MonoBehaviour
	{
		[SerializeField]
		protected Core.UI.Screen _linkedScreen;

		[SerializeField]
		private MainMenuScreen.Tab thisTabType;

		[SerializeField]
		private Animator tabAnimator;

		[SerializeField]
		private GameObject tabWarningGameObject;

		[ReadOnly]
		[SerializeField]
		private GameObject tabPrefab;

		protected readonly int activeHash;

		protected readonly int activateHash;

		private bool activeStatus;

		public Core.UI.Screen Screen => null;

		protected abstract bool DoesHaveWarning();

		protected virtual void Start()
		{
		}

		public void CheckWarning()
		{
		}

		public void OnPressed()
		{
		}

		public void SetActivationStatus(bool status, bool instant = false)
		{
		}
	}
}
