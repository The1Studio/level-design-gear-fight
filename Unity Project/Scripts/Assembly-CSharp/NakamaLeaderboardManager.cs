using System;
using System.Collections.Generic;
using NakamaHttp;
using UnityEngine;

public class NakamaLeaderboardManager : MonoBehaviour
{
	private List<PlayerData> _topRecords;

	private static NakamaLeaderboardManager _instance;

	public string DisplayName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Score
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static NakamaLeaderboardManager Instance => null;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void Refresh()
	{
	}

	public void GatherLeaderboardTop(Action callback = null)
	{
	}

	public void UpdatePlayerProfile(Action callback = null)
	{
	}

	public List<PlayerData> GetLeaderboardListWithPlayerInIt()
	{
		return null;
	}

	public void SendLeaderboardScore()
	{
	}

	private void GatherPlayerProfile()
	{
	}

	private void KeepServerUpToDate(PlayerData data)
	{
	}

	private PlayerData CreatePlayerData()
	{
		return null;
	}
}
