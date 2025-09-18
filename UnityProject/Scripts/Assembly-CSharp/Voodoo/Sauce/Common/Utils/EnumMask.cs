using System;
using UnityEngine;

namespace Voodoo.Sauce.Common.Utils
{
	public class EnumMask : PropertyAttribute
	{
		private readonly string[] _valueNames;

		private readonly int[] _valueValues;

		public EnumMask(Type type)
		{
		}

		public string[] GetEnumValueNames()
		{
			return null;
		}

		public int[] GetEnumValues()
		{
			return null;
		}
	}
}
