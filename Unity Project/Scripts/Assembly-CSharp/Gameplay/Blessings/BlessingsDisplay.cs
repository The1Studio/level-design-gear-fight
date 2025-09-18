using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Blessings
{
	public class BlessingsDisplay : MonoBehaviour
	{
		private const string DESCRIPTION_FORMAT = "{0} <color=yellow>+{1}%</color>";

		[SerializeField]
		private TextMeshProUGUI _name;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private GameObject _backgroundActive;

		[SerializeField]
		private GameObject _backgroundDisabled;

		[SerializeField]
		private TextMeshProUGUI _descriptionBonus;

		[SerializeField]
		private TextMeshProUGUI _level;

		[SerializeField]
		private UIProgressBar _fillBar;

		[SerializeField]
		private TextMeshProUGUI _fillBarText;

		[SerializeField]
		private TextMeshProUGUI _timer;

		[SerializeField]
		private Button _rvButton;

		private BlessingData _blessingData;

		private BlessingDefinition _blessingDefinition;

		private bool isTimerRunning;

		private BlessingsManager _blessingsManager => null;

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void Initialize(int index)
		{
		}

		private void SubLevelChanged(int _)
		{
		}

		private void RefreshTimer()
		{
		}

		private void RefreshNonStaticUI()
		{
		}

		private bool IsBlessingMaxed()
		{
			return false;
		}

		private void OnRVButtonClicked()
		{
		}

		private void ADCompleted()
		{
		}

		private bool IsRewardedAvailable()
		{
			return false;
		}

		private void ShowRewarded(Action<bool> callback, string placement)
		{
		}
	}
}
