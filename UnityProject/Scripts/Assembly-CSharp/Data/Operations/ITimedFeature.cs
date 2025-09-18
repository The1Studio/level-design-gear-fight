using System;

namespace Data.Operations
{
	public interface ITimedFeature
	{
		TimeSpan? GetTimeLeft();
	}
}
