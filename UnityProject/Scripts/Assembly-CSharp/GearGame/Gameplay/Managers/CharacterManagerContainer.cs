using UnityEngine;

namespace GearGame.Gameplay.Managers
{
	public class CharacterManagerContainer : MonoBehaviour
	{
		private static CharacterManagerContainer instance;

		public static CharacterManagerContainer Instance => null;

		[field: SerializeField]
		public AllyManager AllyManager { get; private set; }

		[field: SerializeField]
		public EnemyManager EnemyManager { get; private set; }

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}
	}
}
