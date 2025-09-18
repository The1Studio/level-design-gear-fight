using System.Collections.Generic;
using System.Xml.Serialization;

namespace Voodoo.Sauce.Internal.SDKs.Models
{
	[XmlRoot(ElementName = "androidPackages")]
	public class AndroidPackages
	{
		[XmlElement(ElementName = "androidPackage")]
		public List<AndroidPackage> AndroidPackage { get; set; }
	}
}
