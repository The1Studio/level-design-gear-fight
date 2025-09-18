using System;

namespace Core.UI
{
	[Flags]
	public enum PopupUsage
	{
		None = 0,
		IsIndependent = 1,
		IsReusable = 2
	}
}
