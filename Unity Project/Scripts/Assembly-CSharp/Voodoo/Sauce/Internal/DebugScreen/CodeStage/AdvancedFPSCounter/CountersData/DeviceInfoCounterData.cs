using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public class DeviceInfoCounterData : StaticCounterData
	{
		[Tooltip("Shows operating system & platform info.")]
		[SerializeField]
		private bool platform;

		[Tooltip("CPU model and cores (including virtual cores from Intel's Hyper Threading) count.")]
		[SerializeField]
		private bool cpuModel;

		[SerializeField]
		[Tooltip("Check to show CPU model on new line.")]
		private bool cpuModelNewLine;

		[SerializeField]
		[Tooltip("Shows GPU model name.")]
		private bool gpuModel;

		[Tooltip("Check to show GPU model on new line.")]
		[SerializeField]
		private bool gpuModelNewLine;

		[Tooltip("Shows graphics API version and type (if possible).")]
		[SerializeField]
		private bool gpuApi;

		[Tooltip("Check to show graphics API version on new line.")]
		[SerializeField]
		private bool gpuApiNewLine;

		[Tooltip("Shows graphics supported shader model (if possible), approximate pixel fill-rate (if possible) and total Video RAM size (if possible).")]
		[SerializeField]
		private bool gpuSpec;

		[Tooltip("Check to show graphics specs on new line.")]
		[SerializeField]
		private bool gpuSpecNewLine;

		[SerializeField]
		[Tooltip("Shows total RAM size.")]
		private bool ramSize;

		[Tooltip("Check to show RAM size on new line.")]
		[SerializeField]
		private bool ramSizeNewLine;

		[Tooltip("Shows screen resolution, size and DPI (if possible).")]
		[SerializeField]
		private bool screenData;

		[Tooltip("Check to show screen data on new line.")]
		[SerializeField]
		private bool screenDataNewLine;

		[Tooltip("Shows device model. Actual for mobile devices.")]
		[SerializeField]
		private bool deviceModel;

		[SerializeField]
		[Tooltip("Check to show device model on new line.")]
		private bool deviceModelNewLine;

		public bool Platform
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CpuModel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CpuModelNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GpuModel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GpuModelNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GpuApi
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GpuApiNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GpuSpec
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GpuSpecNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RamSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RamSizeNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ScreenData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ScreenDataNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DeviceModel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DeviceModelNewLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string LastValue { get; private set; }

		internal DeviceInfoCounterData()
		{
		}

		internal override void UpdateValue(bool force)
		{
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
