using System;
using System.Collections.Generic;
using Voodoo.Nakama.Managers;
using Voodoo.Nakama.Server;

namespace Voodoo.Nakama.Data
{
	public interface IDataConfigurator
	{
		void InstallData(NakamaManager nakamaManager);

		void OpenCloudSaveSelectAccountPopUp(List<ServerBaseData> otherData, Action<AccountMergeOption> closeCallback);

		void ReloadGame();

		void OnDataLoaded(bool isReloading);
	}
}
