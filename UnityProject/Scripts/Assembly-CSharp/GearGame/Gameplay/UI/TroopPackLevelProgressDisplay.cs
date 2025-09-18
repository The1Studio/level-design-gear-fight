using System.Collections.Generic;
using AssetKits.ParticleImage;
using Core.Timers;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class TroopPackLevelProgressDisplay : MonoBehaviour
	{
		[SerializeField]
		private ParticleImage particleImage;

		[SerializeField]
		private GameObject rankUpPendingObject;

		[SerializeField]
		private TextMeshProUGUI packNameDisplayText;

		[SerializeField]
		private TextMeshProUGUI rankText;

		[SerializeField]
		private TextMeshProUGUI xpBoostTimerText;

		[SerializeField]
		private Slider fillSlider;

		[SerializeField]
		private Image displayImage;

		[SerializeField]
		private ScriptableGlobalGameplayBoostData xpBoost;

		[SerializeField]
		private GameObject[] xpBoostDisplayObjects;

		private int remainingPaydown;

		private ScriptablePack pack;

		private Timer timer;

		private bool hasInitialized;

		private static readonly List<TroopPackLevelProgressDisplay> allTroopPackDisplays;

		public static Vector3 ScreenCenter => default(Vector3);

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void ActivationStatusChanged(ScriptableGlobalGameplayBoostData data, bool status, Transform transform)
		{
		}

		private void TimeSpanChanged(Timer timer)
		{
		}

		public void OnPressed()
		{
		}

		private void PackChanged(ScriptablePack newPack)
		{
		}

		private void Unsubscribe()
		{
		}

		private void LevelChanged(ScriptablePack _, int level)
		{
		}

		private void PackXPChanged(ScriptablePack _, int xp)
		{
		}

		public static TroopPackLevelProgressDisplay GetAnyActiveTroopPackDisplayElement()
		{
			return null;
		}

		public void BurstXP(int totalXP, Vector3 position)
		{
		}

		private void PayDownOutstanding()
		{
		}

		public void OnExitAnimationCompleted()
		{
		}
	}
}
