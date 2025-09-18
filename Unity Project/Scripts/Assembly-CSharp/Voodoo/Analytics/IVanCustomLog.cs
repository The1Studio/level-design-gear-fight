using System;

namespace Voodoo.Analytics
{
	public interface IVanCustomLog
	{
		void LogException(string tag, Exception exception);

		void ReportException(Exception exception);
	}
}
