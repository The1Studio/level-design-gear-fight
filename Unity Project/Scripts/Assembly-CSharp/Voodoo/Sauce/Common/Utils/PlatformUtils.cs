namespace Voodoo.Sauce.Common.Utils
{
	public static class PlatformUtils
	{
		public static readonly bool IS_LINUX;

		public static readonly bool IS_OSX;

		public static bool UNITY_IOS => false;

		public static bool UNITY_ANDROID => false;

		public static bool UNITY_EDITOR => false;
	}
}
