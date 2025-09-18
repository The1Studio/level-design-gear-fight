using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class ConversionEventInfo
	{
		public string AdjustEventToken;

		public ConversionEventName Name;

		[HideInInspector]
		public string OriginalData;

		public virtual bool IsValid()
		{
			return false;
		}
	}
}
