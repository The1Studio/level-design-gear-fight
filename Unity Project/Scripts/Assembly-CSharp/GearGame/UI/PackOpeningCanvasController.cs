using System.Collections.Generic;
using AssetKits.ParticleImage;
using GearGame.Control;
using Items;
using UnityEngine;
using VInspector;

namespace GearGame.UI
{
	public class PackOpeningCanvasController : MonoBehaviour
	{
		public enum ChestDisplay
		{
			Free = 0,
			Chest1 = 1,
			Chest2 = 2
		}

		[SerializeField]
		private GameObject completedStateParent;

		[SerializeField]
		private GameObject packPrefab;

		[SerializeField]
		private Transform spawnTransform;

		[SerializeField]
		private GameObject gearShowPrefab;

		[SerializeField]
		private Transform gearShowSpawnTransform;

		[SerializeField]
		private Transform[] spawnTargets;

		[SerializeField]
		private float yDampingFromGearControllers;

		[SerializeField]
		private float yMinForGear;

		[SerializeField]
		private SerializedDictionary<GearUpgradeUnlockProfile.Tier, ParticleImage> particles;

		[SerializeField]
		private SerializedDictionary<ChestDisplay, GameObject> allChestDisplays;

		private readonly List<SelectableGearController> allGearDisplayControllers;

		private readonly Queue<ScriptableGear> gearQueue;

		private int numTotal;

		private int currentSpawn;

		private TransactionLocation transactionLocation;

		private void Update()
		{
		}

		public void GenerateGears(int number, ChestDisplay chestDisplay, TransactionLocation transactionLocation)
		{
		}

		private void Activate(ScriptableGear[] allGears)
		{
		}

		public void OnExitPressed()
		{
		}

		public void SpawnAllGears()
		{
		}

		private bool TryDequeue()
		{
			return false;
		}

		private void GearTapped(PackOpeningMiniGearController gear)
		{
		}

		private void AnimationCompleted(PackOpeningMiniGearController gear)
		{
		}
	}
}
