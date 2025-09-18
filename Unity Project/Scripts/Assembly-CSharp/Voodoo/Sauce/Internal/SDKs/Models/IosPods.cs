using System.Collections.Generic;
using System.Xml.Serialization;

namespace Voodoo.Sauce.Internal.SDKs.Models
{
	[XmlRoot(ElementName = "iosPods")]
	public class IosPods
	{
		[XmlElement(ElementName = "iosPod")]
		public List<IosPod> IosPod { get; set; }
	}
}
