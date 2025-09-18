using System;
using System.Collections.Generic;
using UnityEngine;

namespace Comscore
{
	internal class AndroidUtils
	{
		private const string HashMapJavaClass = "java.util.HashMap";

		public static AndroidJavaObject ConvertToJavaHashMap(Dictionary<string, string> dictionary)
		{
			return null;
		}

		public static AndroidJavaObject ConvertToJavaHashMap<VType>(Dictionary<string, VType> dictionary)
		{
			return null;
		}

		public static List<ItemType> ConvertFromJavaList<ItemType, JavaType>(AndroidJavaObject javaList, Func<JavaType, ItemType> processElementFunc)
		{
			return null;
		}

		public static AndroidJavaObject ConvertToJavaList<ItemType, JavaType>(List<ItemType> list, Func<ItemType, JavaType> processElementFunc)
		{
			return null;
		}

		public static ItemTypes[] ConvertFromJavaArray<ItemTypes>(AndroidJavaObject obj)
		{
			return null;
		}
	}
}
