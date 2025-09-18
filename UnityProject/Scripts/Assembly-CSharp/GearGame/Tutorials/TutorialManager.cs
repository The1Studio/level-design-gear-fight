using GearGame.UI;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class TutorialManager : MonoBehaviour
	{
		private static TutorialManager instance;

		[SerializeField]
		private TutorialSettings tutorialSettings;

		private bool tutorialChecked;

		public static TutorialManager Instance => null;

		public UICanvasButtonBasedTutorialController ActiveTutorial { get; private set; }

		public TutorialButtonPressHelper ButtonPressHelper { get; private set; }

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void ForceStartTutorial(UICanvasButtonBasedTutorialController tutorial)
		{
		}

		public void CheckForValidTutorialsToRun()
		{
		}

		public bool TryStartTutorial(UICanvasButtonBasedTutorialController tut)
		{
			return false;
		}

		private void TutorialCompleted(UICanvasButtonBasedTutorialController button)
		{
		}

		public void StopTutorial()
		{
		}
	}
}
