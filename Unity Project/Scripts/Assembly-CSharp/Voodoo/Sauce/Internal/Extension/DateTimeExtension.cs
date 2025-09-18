using System;

namespace Voodoo.Sauce.Internal.Extension
{
	public static class DateTimeExtension
	{
		private const string ISO_FORMAT = "yyyy-MM-ddTHH:mm:ss.fffZ";

		private const string DEFAULT_CULTURE_INFO = "fr-FR";

		public static string ToIsoFormat(this DateTime dateTime, IFormatProvider cultureInfo = null)
		{
			return null;
		}
	}
}
