using System;
using UnityEngine;

[Serializable]
public class IndividualTimer
{
	public enum StringDisplayType
	{
		Short = 0,
		Medium = 1
	}

	[field: SerializeField]
	public string SaveTag { get; protected set; }

	[field: SerializeField]
	public string TimerStartString { get; protected set; }

	[field: SerializeField]
	public string TimerEndString { get; protected set; }

	public DateTime TimerStartTime { get; private set; }

	public DateTime TimerEndTime { get; private set; }

	public IndividualTimer(string playerPrefsTimeTag)
	{
	}

	public bool InitializeAfterLoad()
	{
		return false;
	}
}
