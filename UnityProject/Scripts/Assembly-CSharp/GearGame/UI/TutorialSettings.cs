using System.Collections.Generic;
using GearGame.Tutorials;
using UnityEngine;

namespace GearGame.UI
{
	[CreateAssetMenu(fileName = "TutorialSettings", menuName = "UI/TutorialSettings", order = 2)]
	public class TutorialSettings : ScriptableObject
	{
		[field: SerializeField]
		public List<UICanvasButtonBasedTutorialController> AllButtonTutorials { get; private set; }

		public T GetTutorial<T>() where T : UICanvasButtonBasedTutorialController
		{
			return null;
		}
	}
}
