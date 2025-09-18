using Voodoo.Sauce.Internal.Ads;

namespace Voodoo.Sauce.Core
{
	public interface IVoodooSettings
	{
		AudioAdConfig GetIosAudioAdConfig { get; }

		AudioAdConfig GetAndroidAudioAdConfig { get; }

		bool UseRemoteConfig { get; }
	}
}
