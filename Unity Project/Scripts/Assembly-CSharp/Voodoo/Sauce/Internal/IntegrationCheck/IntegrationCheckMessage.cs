using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.IntegrationCheck
{
	public class IntegrationCheckMessage
	{
		public enum Type
		{
			WARNING = 0,
			ERROR = 1
		}

		public readonly Type type;

		public readonly bool isBackToSettingsBtnDisplayed;

		private readonly string _description;

		[CanBeNull]
		private readonly string[] parameters;

		public string Description => null;

		public IntegrationCheckMessage(Type type, string description, string[] parameters = null, bool isBackToSettingsBtnDisplayed = false)
		{
		}
	}
}
