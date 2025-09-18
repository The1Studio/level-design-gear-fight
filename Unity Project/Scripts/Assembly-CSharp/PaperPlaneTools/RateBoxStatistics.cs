using System;
using UnityEngine;

namespace PaperPlaneTools
{
	[Serializable]
	public class RateBoxStatistics
	{
		[SerializeField]
		private int sessionsCount;

		[SerializeField]
		private int customEventCount;

		[SerializeField]
		private int appInstallAt;

		[SerializeField]
		private int appLaunchAt;

		[SerializeField]
		private int dialogShownAt;

		[SerializeField]
		private bool dialogIsRejected;

		[SerializeField]
		private bool dialogIsRated;

		[SerializeField]
		private string applicationVersion;

		public int SessionsCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CustomEventCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int AppInstallAt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int AppLaunchAt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DialogShownAt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool DialogIsRejected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DialogIsRated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string ApplicationVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
