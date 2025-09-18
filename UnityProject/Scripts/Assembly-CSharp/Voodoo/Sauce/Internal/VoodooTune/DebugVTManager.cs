using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	internal static class DebugVTManager
	{
		internal delegate void OnDebugConfigurationChange();

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadDebugConfigurations_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action<string> onError;

			public Action onSuccess;

			private string _003Cerror_003E5__2;

			private VoodooTuneClient _003Cclient_003E5__3;

			private TaskAwaiter<VersionMetadata> _003C_003Eu__1;

			private TaskAwaiter<IReadOnlyList<ABTest>> _003C_003Eu__2;

			private TaskAwaiter<IReadOnlyList<Segment>> _003C_003Eu__3;

			private TaskAwaiter<IReadOnlyList<Sandbox>> _003C_003Eu__4;

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

		private const string TAG = "DebugVTManager";

		private static readonly List<ABTestState> DebuggerAbTestStates;

		private static VersionMetadata _version;

		private static IReadOnlyList<ABTest> _abTests;

		private static IReadOnlyList<Segment> _segments;

		private static IReadOnlyList<Sandbox> _sandboxes;

		internal static DebugVTConfiguration CurrentDebugConfiguration { get; private set; }

		[CanBeNull]
		internal static DebugVTConfiguration DraftDebugConfiguration { get; private set; }

		internal static bool IsDraftDebugConfiguration => false;

		internal static event OnDebugConfigurationChange OnDebugConfigurationChangeEvent
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

		internal static void Initialize()
		{
		}

		internal static bool HasDebugBehaviorApplied()
		{
			return false;
		}

		internal static void RemoveDebugDraftConfiguration()
		{
		}

		private static void OnDebugConfigurationUpdate()
		{
		}

		internal static void SelectDebugSandbox(Sandbox sandbox)
		{
		}

		public static bool AddCohort(Cohort cohort, ABTest abTest)
		{
			return false;
		}

		public static bool RemoveCohort(Cohort cohort, ABTest abTest)
		{
			return false;
		}

		public static void ClearCohorts()
		{
		}

		public static void ClearSandboxes()
		{
		}

		public static bool AddDebugSegment(Segment segment)
		{
			return false;
		}

		public static bool RemoveDebugSegment(Segment segment)
		{
			return false;
		}

		public static void ClearDebugSegments()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadDebugConfigurations_003Ed__32))]
		internal static void LoadDebugConfigurations(Action onSuccess, Action<string> onError)
		{
		}

		internal static IEnumerable<Sandbox> GetDebugSandboxes()
		{
			return null;
		}

		internal static IEnumerable<ABTest> GetDebugAbTests()
		{
			return null;
		}

		internal static IEnumerable<Segment> GetDebugSegments()
		{
			return null;
		}

		internal static void NewDebugDraftConfiguration()
		{
		}

		internal static void ResetDebugDraftConfiguration()
		{
		}
	}
}
