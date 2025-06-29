using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A0 RID: 416
	[NullableContext(1)]
	[Nullable(0)]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x06001245 RID: 4677 RVA: 0x00091A44 File Offset: 0x0008FC44
		public XmlDocumentWrapper(XmlDocument document)
			: base(document)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.xmlDocument_0 = document;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
			{
				return;
			}
			IL_0033:
			switch (num)
			{
			case 0:
				goto IL_001B;
			case 1:
				break;
			default:
				goto IL_001B;
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00006B03 File Offset: 0x00004D03
		public IXmlNode CreateComment([Nullable(2)] string data)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateComment(data));
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00006B16 File Offset: 0x00004D16
		public IXmlNode CreateTextNode([Nullable(2)] string text)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateTextNode(text));
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00006B29 File Offset: 0x00004D29
		public IXmlNode imethod_0([Nullable(2)] string data)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateCDataSection(data));
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00006B3C File Offset: 0x00004D3C
		public IXmlNode CreateWhitespace([Nullable(2)] string text)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateWhitespace(text));
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00006B4F File Offset: 0x00004D4F
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateSignificantWhitespace(text));
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00006B62 File Offset: 0x00004D62
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone)
		{
			return new XmlDeclarationWrapper(this.xmlDocument_0.CreateXmlDeclaration(version, encoding, standalone));
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00006B77 File Offset: 0x00004D77
		[NullableContext(2)]
		[return: Nullable(1)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset)
		{
			return new XmlDocumentTypeWrapper(this.xmlDocument_0.CreateDocumentType(name, publicId, systemId, null));
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00006B8D File Offset: 0x00004D8D
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateProcessingInstruction(target, data));
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00006BA1 File Offset: 0x00004DA1
		public IXmlElement CreateElement(string elementName)
		{
			return new XmlElementWrapper(this.xmlDocument_0.CreateElement(elementName));
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return new XmlElementWrapper(this.xmlDocument_0.CreateElement(qualifiedName, namespaceUri));
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00006BC8 File Offset: 0x00004DC8
		public IXmlNode CreateAttribute(string name, [Nullable(2)] string value)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateAttribute(name))
			{
				Value = value
			};
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00006BE2 File Offset: 0x00004DE2
		public IXmlNode CreateAttribute(string qualifiedName, [Nullable(2)] string namespaceUri, [Nullable(2)] string value)
		{
			return new XmlNodeWrapper(this.xmlDocument_0.CreateAttribute(qualifiedName, namespaceUri))
			{
				Value = value
			};
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00091A98 File Offset: 0x0008FC98
		[Nullable(2)]
		public IXmlElement DocumentElement
		{
			[NullableContext(2)]
			get
			{
				while (this.xmlDocument_0.DocumentElement == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return null;
				}
				return new XmlElementWrapper(this.xmlDocument_0.DocumentElement);
			}
		}

		// Token: 0x04000816 RID: 2070
		private readonly XmlDocument xmlDocument_0;
	}
}
