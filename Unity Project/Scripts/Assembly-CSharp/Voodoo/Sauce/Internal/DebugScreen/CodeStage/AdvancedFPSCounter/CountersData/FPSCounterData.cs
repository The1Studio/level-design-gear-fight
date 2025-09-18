using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public class FPSCounterData : UpdatableCounterData
	{
		[CompilerGenerated]
		private sealed class _003CUpdateCounter_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FPSCounterData _003C_003E4__this;

			private float _003CpreviousUpdateTime_003E5__2;

			private int _003CpreviousUpdateFrames_003E5__3;

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
			public _003CUpdateCounter_003Ed__150(int _003C_003E1__state)
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

		private const string ColorTextStart = "<color=#{0}>";

		private const string ColorTextEnd = "</color>";

		private const string FPSTextStart = "<color=#{0}>FPS: ";

		private const string MsTextStart = " <color=#{0}>[";

		private const string MsTextEnd = " MS]</color>";

		private const string MinTextStart = "<color=#{0}>MIN: ";

		private const string MaxTextStart = "<color=#{0}>MAX: ";

		private const string AvgTextStart = "<color=#{0}>AVG: ";

		private const string RenderTextStart = "<color=#{0}>REN: ";

		public int warningLevelValue;

		public int criticalLevelValue;

		[Tooltip("Average FPS counter accumulative data will be reset on new scene load if enabled.")]
		public bool resetAverageOnNewScene;

		[Tooltip("Minimum and maximum FPS readouts will be reset on new scene load if enabled")]
		public bool resetMinMaxOnNewScene;

		[Tooltip("Amount of update intervals to skip before recording minimum and maximum FPS.\nUse it to skip initialization performance spikes and drops.")]
		[Range(0f, 10f)]
		public int minMaxIntervalsToSkip;

		internal float newValue;

		private string colorCachedMs;

		private string colorCachedMin;

		private string colorCachedMax;

		private string colorCachedAvg;

		private string colorCachedRender;

		private string colorWarningCached;

		private string colorWarningCachedMs;

		private string colorWarningCachedMin;

		private string colorWarningCachedMax;

		private string colorWarningCachedAvg;

		private string colorCriticalCached;

		private string colorCriticalCachedMs;

		private string colorCriticalCachedMin;

		private string colorCriticalCachedMax;

		private string colorCriticalCachedAvg;

		private int currentAverageSamples;

		private float currentAverageRaw;

		private int minMaxIntervalsSkipped;

		private float renderTimeBank;

		private int previousFrameCount;

		[Tooltip("Shows realtime FPS at the moment of the counter update scene start. Allows to hide FPS readout if necessary.")]
		[SerializeField]
		private bool realtimeFPS;

		[Tooltip("Shows time in milliseconds spent to render 1 frame.")]
		[SerializeField]
		private bool milliseconds;

		[Tooltip("Shows Average FPS calculated from specified Samples amount or since game / scene start, depending on Samples value and 'Reset On Load' toggle.")]
		[SerializeField]
		private bool average;

		[Tooltip("Shows time in milliseconds for the average FPS.")]
		[SerializeField]
		private bool averageMilliseconds;

		[SerializeField]
		[Tooltip("Controls placing Average on the new line.")]
		private bool averageNewLine;

		[Tooltip("Amount of last samples to get average from. Set 0 to get average from all samples since startup or level load.\nOne Sample recorded per one Interval.")]
		[Range(0f, 100f)]
		[SerializeField]
		private int averageSamples;

		[Tooltip("Shows minimum and maximum FPS readouts since game / scene start, depending on 'Reset On Load' toggle.")]
		[SerializeField]
		private bool minMax;

		[Tooltip("Shows time in milliseconds for the Min Max FPS.")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Tooltip("Controls placing Min Max on the new line.")]
		[SerializeField]
		private bool minMaxNewLine;

		[Tooltip("Check to place Min Max on two separate lines. Otherwise they will be placed on a single line.")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Tooltip("Shows time spent on Camera.Render excluding Image Effects. Add AFPSRenderRecorder to the cameras you wish to count.")]
		[SerializeField]
		private bool render;

		[SerializeField]
		[Tooltip("Controls placing Render on the new line.")]
		private bool renderNewLine;

		[SerializeField]
		[Tooltip("Check to automatically add AFPSRenderRecorder to the Main Camera if present.")]
		private bool renderAutoAdd;

		[Tooltip("Color of the FPS counter while FPS is between Critical and Warning levels.")]
		[SerializeField]
		private Color colorWarning;

		[Tooltip("Color of the FPS counter while FPS is below Critical level.")]
		[SerializeField]
		private Color colorCritical;

		[Tooltip("Color of the Render Time output.")]
		[SerializeField]
		protected Color colorRender;

		public bool RealtimeFPS
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Milliseconds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Average
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AverageMilliseconds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AverageNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int AverageSamples
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool MinMax
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MinMaxMilliseconds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MinMaxNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MinMaxTwoLines
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Render
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RenderNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RenderAutoAdd
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color ColorWarning
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color ColorCritical
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color ColorRender
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int LastValue { get; private set; }

		public float LastMillisecondsValue { get; private set; }

		public float LastRenderValue { get; private set; }

		public int LastAverageValue { get; private set; }

		public float LastAverageMillisecondsValue { get; private set; }

		public int LastMinimumValue { get; private set; }

		public int LastMaximumValue { get; private set; }

		public float LastMinMillisecondsValue { get; private set; }

		public float LastMaxMillisecondsValue { get; private set; }

		public FPSLevel CurrentFpsLevel { get; private set; }

		public event Action<FPSLevel> OnFPSLevelChange
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

		internal FPSCounterData()
		{
		}

		public void ResetAverage()
		{
		}

		public void ResetMinMax()
		{
		}

		internal void OnLevelLoadedCallback()
		{
		}

		internal void AddRenderTime(float time)
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

		[IteratorStateMachine(typeof(_003CUpdateCounter_003Ed__150))]
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

		protected void CacheWarningColor()
		{
		}

		protected void CacheCriticalColor()
		{
		}

		private static void TryToAddRenderRecorder()
		{
		}

		private static void TryToRemoveRenderRecorder()
		{
		}
	}
}
