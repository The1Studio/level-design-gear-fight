using System.Xml.Serialization;
using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.SDKs.Models
{
	[XmlRoot(ElementName = "androidPackage")]
	public class AndroidPackage
	{
		[XmlAttribute(AttributeName = "spec")]
		public string Spec { get; set; }

		[XmlAttribute(AttributeName = "mopub-key")]
		public string Mopubkey { get; set; }

		[XmlElement(ElementName = "repositories")]
		public Repositories Repositories { get; set; }

		[CanBeNull]
		public string Version => null;
	}
}
