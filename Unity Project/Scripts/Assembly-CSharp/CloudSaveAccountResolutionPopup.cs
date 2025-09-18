using System;
using System.Collections.Generic;
using Core.UI;
using UnityEngine;
using Voodoo.Nakama.Server;

public class CloudSaveAccountResolutionPopup : Popup
{
	[SerializeField]
	private CloudSaveAccountDisplay _currentAccountDisplay;

	[SerializeField]
	private CloudSaveAccountDisplay _newAccountDisplay;

	private Action<AccountMergeOption> _onCloseCallback;

	public void Show(List<CloudSaveAccountDisplay.ItemData> currentAccountData, List<CloudSaveAccountDisplay.ItemData> newAccountData, Action<AccountMergeOption> onCloseCallback)
	{
	}

	private void OnKeepCurrentClicked()
	{
	}

	private void OnKeepNewClicked()
	{
	}

	private void OnKeepAccountButtonClicked(bool keepCurrent)
	{
	}
}
