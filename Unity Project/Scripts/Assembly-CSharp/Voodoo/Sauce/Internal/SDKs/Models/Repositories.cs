using System.Xml.Serialization;

namespace Voodoo.Sauce.Internal.SDKs.Models
{
	[XmlRoot(ElementName = "repositories")]
	public class Repositories
	{
		[XmlElement(ElementName = "repository")]
		public string Repository { get; set; }
	}
}
