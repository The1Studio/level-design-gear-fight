using GearGame.Gameplay;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Buff")]
	public class ScriptableBoostDetails : ScriptableObject
	{
		[SerializeField]
		private BoostController buffPrefab;

		[field: SerializeField]
		public string ID { get; private set; }

		public BoostController InstantiateBuff()
		{
			return null;
		}
	}
}
