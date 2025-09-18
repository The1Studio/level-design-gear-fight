using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	public class GameSaveHelper : MonoBehaviour
	{
		private static GameSaveHelper instance;

		public static GameSaveHelper Instance => null;

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}
	}
}
