using System;
using System.Collections.Generic;
using Voodoo.Live.Offers;

namespace Voodoo.Live
{
	public interface IFeatureClient : IClient
	{
		event Action<string> eventFired;

		void Trigger(string appEvent);

		List<IFeature> GetActiveFeatures();

		List<IFeature> GetInvalidFeatures();
	}
}
