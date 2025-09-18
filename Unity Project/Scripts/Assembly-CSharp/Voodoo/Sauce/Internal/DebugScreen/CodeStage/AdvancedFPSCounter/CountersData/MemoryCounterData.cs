using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public class MemoryCounterData : UpdatableCounterData
	{
		[CompilerGenerated]
		private sealed class _003CUpdateCounter_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MemoryCounterData _003C_003E4__this;

			private float _003CpreviousUpdateTime_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CUpdateCounter_003Ed__52(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public const long MemoryDivider = 1048576L;

		private const string TextStart = "<color=#{0}>";

		private const string LineStartTotal = "MEM TOTAL: ";

		private const string LineStartTotalSystem = "SYS MEM TOTAL: ";

		private const string LineStartAllocated = "MEM ALLOC: ";

		private const string LineStartMono = "MEM MONO: ";

		private const string LineEnd = " MB";

		private const string TextEnd = "</color>";

		[Tooltip("Allows to output memory usage more precisely thus using a bit more system resources.")]
		[SerializeField]
		private bool precise;

		[Tooltip("Allows to see private memory amount reserved for application. This memory can’t be used by other applications.")]
		[SerializeField]
		private bool total;

		[Tooltip("Allows to see amount of memory, currently allocated by application.")]
		[SerializeField]
		private bool allocated;

		[Tooltip("Allows to see amount of memory, allocated by managed Mono objects, such as UnityEngine.Object and everything derived from it for example.")]
		[SerializeField]
		private bool monoUsage;

		[SerializeField]
		[Tooltip("Allows to see amount of allocated memory for the graphics driver (dev builds only).")]
		private bool gfx;

		public bool Precise
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Total
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Allocated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MonoUsage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Gfx
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long LastTotalValue { get; private set; }

		public ulong LastSysTotalValue { get; private set; }

		public long LastAllocatedValue { get; private set; }

		public long LastMonoValue { get; private set; }

		public long LastGfxValue { get; private set; }

		internal MemoryCounterData()
		{
		}

		internal override void UpdateValue(bool force)
		{
		}

		protected override void PerformActivationActions()
		{
		}

		protected override void PerformDeActivationActions()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateCounter_003Ed__52))]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		protected override bool HasData()
		{
			return false;
		}

		protected override void CacheCurrentColor()
		{
		}
	}
}
