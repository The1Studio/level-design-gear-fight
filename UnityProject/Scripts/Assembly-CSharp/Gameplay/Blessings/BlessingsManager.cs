using Core.Timers;
using GearGame.Control;
using UnityEngine;

namespace Gameplay.Blessings
{
	public class BlessingsManager : MonoBehaviour
	{
		private static BlessingsManager _instance;

		[SerializeField]
		private BlessingDefinition[] _blessingDefinitions;

		[SerializeField]
		private BlessingsSettings _blessingsSettings;

		[SerializeField]
		private CurrencySO _diamondCurrency;

		private BlessingsData _blessingsData;

		private BlessingsDataHandler _dataHandler;

		public static BlessingsManager Instance => null;

		public static bool ForceDeactivateBlessings { get; set; }

		public bool BlessingsEnabled => false;

		public BlessingsSettings Settings => null;

		public BlessingsData Data => null;

		public string IAPProductKey => null;

		private void CreateSingleton()
		{
		}

		public void Awake()
		{
		}

		private void Start()
		{
		}

		private void Initialize(BlessingsDataHandler dataHandler)
		{
		}

		private void RefreshIAPAvailability()
		{
		}

		private void CheckForIAP()
		{
		}

		private void BlessingTimerEnded(Timer timer)
		{
		}

		private void CheckAllTimers()
		{
		}

		private void OnBlessingEnded(BlessingData data)
		{
		}

		public bool IsUnlimitedBlessingsEnabled()
		{
			return false;
		}

		public float GetBlessingIncreasePercentage(BlessingData data)
		{
			return 0f;
		}

		public float GetBlessingIncreaseMultiplier(BlessingType blessingType)
		{
			return 0f;
		}

		public BlessingDefinition GetBlessingDefinition(int index)
		{
			return null;
		}

		public void ActivateBlessing(BlessingData data)
		{
		}

		public void ActivateAllBlessings()
		{
		}

		private bool IsMaxed(BlessingData data)
		{
			return false;
		}

		private void IncreaseBlessingSubLevel(BlessingData data)
		{
		}

		public void OnBlessingsIAPBought()
		{
		}

		public bool ShouldGiveHC()
		{
			return false;
		}

		private void OnDestroy()
		{
		}
	}
}
