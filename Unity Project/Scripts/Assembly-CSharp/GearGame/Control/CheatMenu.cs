using System;
using Features.Cheat.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Control
{
	public class CheatMenu : MonoBehaviour
	{
		[Serializable]
		private struct Tab
		{
			public Button Button;

			public GameObject Window;
		}

		[Header("Setting SO")]
		[SerializeField]
		private CheatSettings _cheatSettings;

		[Header("Tabs")]
		[SerializeField]
		private Tab[] _tabs;

		[Space(20f)]
		[SerializeField]
		private GameObject _root;

		[SerializeField]
		private Button _openCheatMenuButton;

		[SerializeField]
		private Button _exitButton;

		[SerializeField]
		private Button _backdrop;

		[Header("TimeScale")]
		[SerializeField]
		private Slider _timeScaleSlider;

		[Header("Currencies")]
		[SerializeField]
		private TMP_Dropdown _currenciesDropdown;

		[SerializeField]
		private TMP_InputField _currenciesInputField;

		[SerializeField]
		private Button _addCurrencyButton;

		[SerializeField]
		private Button _setCurrencyButton;

		[Header("Timers")]
		[SerializeField]
		private Button _resetTimersButton;

		[SerializeField]
		private Button _add10MinsButton;

		[SerializeField]
		private Button _add1HButton;

		[SerializeField]
		private Button _add5HButton;

		[SerializeField]
		[Header("Mini Gears")]
		private Button _unlockAllMiniGearsButton;

		[SerializeField]
		[Header("Ingame")]
		private Button _skipWaveButton;

		[SerializeField]
		private Button _winButton;

		[SerializeField]
		private Button _loseButton;

		[Header("Others")]
		[SerializeField]
		private GameObject editorMenuLevelSelection;

		[SerializeField]
		private TextMeshProUGUI speedTextDisplay;

		[SerializeField]
		private Button _plus50GoldButton;

		[SerializeField]
		private Button _setLvlButton;

		[SerializeField]
		private Toggle blessingsToggle;

		[SerializeField]
		[Header("Settings")]
		private Transform _settingsRoot;

		[SerializeField]
		private Toggle _settingsTogglePrefab;

		private bool _settingsInitialized;

		private void Awake()
		{
		}

		private void ShowWindow()
		{
		}

		private void HideWindow()
		{
		}

		private void Init()
		{
		}

		private void InitSettings()
		{
		}

		private void InitCheats()
		{
		}

		private void MapTabs()
		{
		}

		private void SelectTab(Tab tab)
		{
		}

		private void InitOthersSection()
		{
		}

		private void InitIngameSection()
		{
		}

		private void InitMiniGearsSection()
		{
		}

		private static void UnlockAllGears()
		{
		}

		private void InitTimersSection()
		{
		}

		private void ResetTimers()
		{
		}

		public void Add10Minutes()
		{
		}

		public void Add1Hour()
		{
		}

		public void Add5Hours()
		{
		}

		private void InitCurrenciesSection()
		{
		}

		private void SetCurrency()
		{
		}

		private void AddCurrency()
		{
		}

		private void OnDestroy()
		{
		}

		private void UnregisterEvents()
		{
		}

		private void BlessingsToggleChanged(bool state)
		{
		}

		public void Win()
		{
		}

		public void Lose()
		{
		}

		public void SkipWave()
		{
		}

		public void ActivateLevelSelection()
		{
		}

		private void DeactivateLevelSelection()
		{
		}

		public void OnTimescaleChanged(float val)
		{
		}

		private void OnEnable()
		{
		}

		public void IncrementGold()
		{
		}
	}
}
