using System.Collections.Generic;
using System.Xml;

namespace Voodoo.Sauce.Internal.Utils
{
	public class ManifestUtilsImpl
	{
		private string _destinationManifestPath;

		public ManifestUtilsImpl(string destinationManifestPath)
		{
		}

		public virtual bool Add(string manifestSourcePath)
		{
			return false;
		}

		public bool Replace(Dictionary<string, string> keysValues)
		{
			return false;
		}

		protected XmlDocument Load(string manifestPath)
		{
			return null;
		}

		private void AddPermission(XmlDocument document, XmlNode sourceNode)
		{
		}

		private void AddChildNode(XmlDocument document, XmlNode parent, XmlNode node)
		{
		}

		protected XmlNode FindChildNode(XmlNode parent, XmlNode child)
		{
			return null;
		}

		protected bool FindElementWithAndroidName(XmlNode parent, XmlNode child)
		{
			return false;
		}

		protected virtual string GetAndroidElementName(XmlNode node, string namespaceOfPrefix)
		{
			return null;
		}

		protected void save(string manifestPath, XmlDocument document)
		{
		}
	}
}
