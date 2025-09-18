using System;
using System.Collections.Generic;
using Items;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Gameplay._Data
{
	[CreateAssetMenu(menuName = "StaticData/DataProvider")]
	public class StaticDataProvider : SerializedScriptableObject
	{
		private static class DataCache<T> where T : GearData
		{
			private static T _cachedData;

			private static bool _isCached;

			public static T Get()
			{
				return null;
			}

			public static void Invalidate()
			{
			}
		}

		public Dictionary<Type, GearData> _dataDictionary;

		public static StaticDataProvider Instance { get; private set; }

		public static T GetData<T>() where T : GearData
		{
			return null;
		}

		public static T GetData<T>(ItemNames itemId) where T : GearData
		{
			return null;
		}

		public static object GetData(ItemNames itemId)
		{
			return null;
		}

		public void CreateSingleton()
		{
		}

		public void Initialize()
		{
		}

		public void InvalidateAllCaches(ref Type[] dataTypes)
		{
		}

		private static void InvalidateCache<T>() where T : GearData
		{
		}
	}
}
