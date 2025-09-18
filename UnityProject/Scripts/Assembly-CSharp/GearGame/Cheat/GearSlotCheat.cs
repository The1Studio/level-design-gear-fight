using GearGame.Control;
using GearGame.Gameplay;
using UnityEngine;

namespace GearGame.Cheat
{
	public class GearSlotCheat : MonoBehaviour, IGearHolder
	{
		private Transform _targetRestingPosition;

		private GameObject _gearHolder;

		private Transform _gearsHolder;

		public GearController Gear { get; private set; }

		public ScriptableGear Settings { get; private set; }

		public GameObject GameObject => null;

		public float DefaultRotation => 0f;

		public float ScaleMultiplier => 0f;

		public bool CanBeUsedInSwaps => false;

		private void UpdateTargetPosition()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void SpawnGear()
		{
		}

		public void Initialize(ScriptableGear gear, Transform gearsHolder)
		{
		}

		public void AddGear(GearController gear)
		{
		}

		public void RemoveGear(GearController gear)
		{
		}
	}
}
