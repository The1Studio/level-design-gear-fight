using System.Xml.Serialization;

namespace Voodoo.Sauce.Internal.SDKs.Models
{
	[XmlRoot(ElementName = "dependencies")]
	public class Dependencies
	{
		[XmlElement(ElementName = "androidPackages")]
		public AndroidPackages AndroidPackages { get; set; }

		[XmlElement(ElementName = "iosPods")]
		public IosPods IosPods { get; set; }

		public static Dependencies GetDependencies(string xmlFilePath)
		{
			return null;
		}
	}
}
