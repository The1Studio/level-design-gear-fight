using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public interface IConditionnal
	{
		List<ICondition> conditions { get; set; }

		string errorMessage { get; }

		bool CanUse();

		void AddCondition(ICondition condition);

		T GetCondition<T>() where T : ICondition;
	}
}
