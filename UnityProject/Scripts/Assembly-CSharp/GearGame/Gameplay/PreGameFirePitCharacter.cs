using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class PreGameFirePitCharacter : MonoBehaviour
	{
		[SerializeField]
		private int index;

		private ScriptableTroop associatedCharacter;

		private GameObject spawnedObject;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void UnsubscribeCharacter()
		{
		}

		private void PackChanged(ScriptablePack pack)
		{
		}

		private void Evolved(ScriptableUnlockableUpgradable _)
		{
		}

		private void CharacterUnlocked(ScriptableUnlockableUpgradable _)
		{
		}
	}
}
