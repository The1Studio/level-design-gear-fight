using System.Xml.Serialization;

namespace Voodoo.Sauce.Internal.SDKs.Models
{
	[XmlRoot(ElementName = "iosPod")]
	public class IosPod
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "subspecs")]
		public string Subspecs { get; set; }

		[XmlAttribute(AttributeName = "minTargetSdk")]
		public string MinTargetSdk { get; set; }

		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }

		[XmlAttribute(AttributeName = "mopub-key")]
		public string Mopubkey { get; set; }
	}
}
