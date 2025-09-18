using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Tutorials
{
	public class TutorialButtonGUIDTarget : MonoBehaviour
	{
		[SerializeField]
		[ReadOnly]
		private string guid;

		public string GUID => null;

		[field: SerializeField]
		public Button Button { get; private set; }

		private void OnValidate()
		{
		}
	}
}
