using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public static class UsefulExtensions
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDisableAfterSeconds_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public float timer;

		public GameObject obj;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetActive_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameObject gameObejct;

		public float delay;

		public bool isActive;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWaitSeconds_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public float seconds;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public static void SetActive(this List<GameObject> list, bool isActive)
	{
	}

	public static void SetActive(this List<GameObject> list, bool isActive, float delay)
	{
	}

	public static void SetTagsRecursive(this GameObject parent, string tag)
	{
	}

	public static void SetLayersRecursive(this GameObject parent, int mask)
	{
	}

	[AsyncStateMachine(typeof(_003CDisableAfterSeconds_003Ed__4))]
	public static void DisableAfterSeconds(this GameObject obj, float timer)
	{
	}

	[AsyncStateMachine(typeof(_003CSetActive_003Ed__5))]
	public static void SetActive(this GameObject gameObejct, bool isActive, float delay)
	{
	}

	internal static T GetClass<T>(string key, T defaultReturn)
	{
		return default(T);
	}

	internal static void SaveClass<T>(string key, T classToSave)
	{
	}

	public static string ToTimerString(this TimeSpan span, bool ignoreSeconds = false)
	{
		return null;
	}

	public static int Round(this int value)
	{
		return 0;
	}

	public static int Round(this int value, int factor)
	{
		return 0;
	}

	public static bool Choose(this float chance)
	{
		return false;
	}

	public static float Range(this float range, float baseRange)
	{
		return 0f;
	}

	public static float Range(this float range)
	{
		return 0f;
	}

	[AsyncStateMachine(typeof(_003CWaitSeconds_003Ed__14))]
	public static Task WaitSeconds(float seconds)
	{
		return null;
	}

	public static List<T> Copy<T>(this List<T> originalList)
	{
		return null;
	}

	public static List<T> RemoveEmpty<T>(this List<T> list)
	{
		return null;
	}

	public static T GetRandom<T>(this List<T> list)
	{
		return default(T);
	}

	public static T GetClamped<T>(this List<T> list, int index)
	{
		return default(T);
	}

	public static List<T> Shuffle<T>(this List<T> list)
	{
		return null;
	}

	public static List<T> GetRandomRange<T>(this List<T> list, int count)
	{
		return null;
	}
}
