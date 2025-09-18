using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal
{
	[Serializable]
	public class VoodooVersion : ScriptableObject
	{
		public const string NAME = "VoodooVersion";

		private static VoodooVersion _instance;

		[ReadOnly]
		public uint Major;

		[ReadOnly]
		public uint Minor;

		[ReadOnly]
		public uint Hotfix;

		[ReadOnly]
		public string Label;

		[ReadOnly]
		public int BuildNumber;

		public static VoodooVersion Get()
		{
			return null;
		}

		[Obsolete]
		public static VoodooVersion Load()
		{
			return null;
		}

		public static string GetVersion()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public void BumpMajor(string label = "")
		{
		}

		public void BumpMinor(string label = "")
		{
		}

		public void BumpHotfix(string label = "")
		{
		}

		public void BumpBuildNumber()
		{
		}

		public void ResetBuildNumber()
		{
		}

		public void DisableBuildNumber()
		{
		}

		public void UpdateLabel(string label = "")
		{
		}

		public void UpdateVersion(uint major, uint minor, uint hotfix, int buildNumber, string label = "")
		{
		}

		public void Save()
		{
		}
	}
}
