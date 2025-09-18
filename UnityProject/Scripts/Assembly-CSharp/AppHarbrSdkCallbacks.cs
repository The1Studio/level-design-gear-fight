using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AppHarbrSdkCallbacks : MonoBehaviour
{
	public static AppHarbrSdkCallbacks Instance { get; private set; }

	public static event Action<string> OnAppHarbrInitializationComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<AHIncidentData> OnAdBlockedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<AHIncidentData> OnAdIncidentEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<AHIncidentData> OnAdAnalyzedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	internal void HandleBackgroundCallback(string propsStr)
	{
	}

	internal void ForwardEvent(string eventPropsStr)
	{
	}
}
