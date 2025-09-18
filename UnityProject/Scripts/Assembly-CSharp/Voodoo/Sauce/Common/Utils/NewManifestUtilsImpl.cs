using System.Collections.Generic;
using System.Xml;
using Voodoo.Sauce.Internal.Utils;

namespace Voodoo.Sauce.Common.Utils
{
	public class NewManifestUtilsImpl : ManifestUtilsImpl
	{
		private class TransverseDataHolder
		{
			public readonly XmlNode Node;

			public readonly int Depth;

			public readonly string Path;

			public TransverseDataHolder(XmlNode node, int depth, string path)
			{
			}
		}

		private const string TAG = "NewManifestUtils";

		private const string INTENT_FILTER_XML_ELEMENT = "intent-filter";

		private const string APPLICATION_XML_ELEMENT = "application";

		private const string COMMENT_XML_ELEMENT_NAME = "#comment";

		private const string USES_PERMISSION_XML_ELEMENT_NAME = "uses-permission";

		private const string ANDROID_XML_PREFIX_NAMESPACE = "android";

		private const string ANDROID_NAME_ATTRIBUTE_NAME = "android:name";

		private const string COMMENT_BEGIN_INSERT_PREFIX = "Beg insert: ";

		private const string COMMENT_END_INSERT_PREFIX = "End insert: ";

		private const string SEPARATOR_PARENT_CHILD = "->";

		private const char SEPARATOR_ELEMENT_NAME_AND_ANDROID_NAME = '@';

		private const string ACTIVITY_ELEMENT_NAME = "activity";

		private const string UNITY_DEFAULT_ACTIVITY_ANDROID_NAME = "com.unity3d.player.UnityPlayerActivity";

		private readonly string _destinationManifestPath;

		private readonly bool _shouldAddDebugComment;

		private readonly bool _enableProcessAttributes;

		public NewManifestUtilsImpl(string destinationManifestPath, bool shouldAddDebugComment, bool enableProcessAttributes)
			: base(null)
		{
		}

		public override bool Add(string manifestSourcePath)
		{
			return false;
		}

		private void AddPermission(XmlDocument document, XmlNode sourceNode, string sourceFile)
		{
		}

		private void ProcessApplicationNode(XmlDocument document, XmlNode destApplicationNode, XmlNode sourceApplicationNode, string sourceFile)
		{
		}

		private void ProcessAttributesOfApplication(XmlNode sourceApplicationNode, XmlNode destApplicationNode, XmlDocument document, string manifestSourcePath)
		{
		}

		private void InsertToNode(XmlDocument document, XmlNode parent, XmlNode node, string sourceFile)
		{
		}

		private string GetFullPath(string parentPath, XmlNode node)
		{
			return null;
		}

		private bool FindApplicationChildNodeWithPath(XmlNode applicationNode, string fullPath, out XmlNode insertToNode)
		{
			insertToNode = null;
			return false;
		}

		private void ApplyAttributes(XmlNode sourceNode, XmlNode destNode, XmlDocument destDoc, string manifestSourcePath)
		{
		}

		private SortedDictionary<string, XmlAttribute> GetAttributesOfXmlNodeInDictionary(XmlNode node)
		{
			return null;
		}

		private string GetAttributesOfXmlNode(XmlNode node)
		{
			return null;
		}

		private string GetXmlNodeChildValue(XmlNode node)
		{
			return null;
		}

		private void AddChildNode(XmlDocument document, XmlNode parent, XmlNode node, string sourceFile)
		{
		}

		private XmlNode FindChildNodeWithElementAndAndroidName(XmlNode parent, string childElementName, string childAndroidName)
		{
			return null;
		}

		protected override string GetAndroidElementName(XmlNode node, string namespaceOfPrefix)
		{
			return null;
		}

		private string GetAndroidElementName(XmlNode node)
		{
			return null;
		}
	}
}
