using System.Collections.Generic;

namespace Comscore
{
	internal interface IAnalytics<Conf, CliConf, PubConf, ParConf, EvInfo> where Conf : IConfiguration<CliConf, PubConf, ParConf> where CliConf : IClientConfiguration where PubConf : IPublisherConfiguration where ParConf : IPartnerConfiguration where EvInfo : IEventInfo
	{
		Conf Configuration { get; }

		string Version { get; }

		LogLevel LogLevel { get; set; }

		void Start();

		void NotifyViewEvent();

		void NotifyViewEvent(EvInfo eventInfo);

		void NotifyViewEvent(Dictionary<string, string> labels);

		void NotifyHiddenEvent();

		void NotifyHiddenEvent(EvInfo eventInfo);

		void NotifyHiddenEvent(Dictionary<string, string> labels);

		void NotifyEnterForeground();

		void NotifyExitForeground();

		void NotifyUxActive();

		void NotifyUxInactive();

		void FlushOfflineCache();

		void ClearOfflineCache();

		void ClearInternalData();
	}
}
