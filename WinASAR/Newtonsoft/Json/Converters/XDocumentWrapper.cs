using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AC RID: 428
	[Nullable(0)]
	[NullableContext(1)]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x060012B7 RID: 4791 RVA: 0x00006D51 File Offset: 0x00004F51
		private XDocument method_1()
		{
			return (XDocument)base.WrappedNode;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00092220 File Offset: 0x00090420
		public XDocumentWrapper(XDocument document)
			: base(document)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00092254 File Offset: 0x00090454
		public override List<IXmlNode> ChildNodes
		{
			get
			{
				List<IXmlNode> childNodes = base.ChildNodes;
				if (this.method_1().Declaration != null && (childNodes.Count == 0 || childNodes[0].NodeType != XmlNodeType.XmlDeclaration))
				{
					childNodes.Insert(0, new Class11(this.method_1().Declaration));
				}
				return childNodes;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000922A8 File Offset: 0x000904A8
		protected override bool HasChildNodes
		{
			get
			{
				while (!base.HasChildNodes)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							return true;
						}
					}
					return this.method_1().Declaration != null;
				}
				return true;
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00006D5E File Offset: 0x00004F5E
		public IXmlNode CreateComment([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XComment(text));
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00006D6B File Offset: 0x00004F6B
		public IXmlNode CreateTextNode([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00006D78 File Offset: 0x00004F78
		public IXmlNode imethod_0([Nullable(2)] string data)
		{
			return new XObjectWrapper(new XCData(data));
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00006D6B File Offset: 0x00004F6B
		public IXmlNode CreateWhitespace([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00006D6B File Offset: 0x00004F6B
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00006D85 File Offset: 0x00004F85
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone)
		{
			return new Class11(new XDeclaration(version, encoding, standalone));
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00006D94 File Offset: 0x00004F94
		[NullableContext(2)]
		[return: Nullable(1)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset)
		{
			return new Class12(new XDocumentType(name, publicId, systemId, internalSubset));
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00006DA5 File Offset: 0x00004FA5
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return new XProcessingInstructionWrapper(new XProcessingInstruction(target, data));
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00006DB3 File Offset: 0x00004FB3
		public IXmlElement CreateElement(string elementName)
		{
			return new XElementWrapper(new XElement(elementName));
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00006DC5 File Offset: 0x00004FC5
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return new XElementWrapper(new XElement(XName.Get(MiscellaneousUtils.GetLocalName(qualifiedName), namespaceUri)));
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00006DDD File Offset: 0x00004FDD
		public IXmlNode CreateAttribute(string name, string value)
		{
			return new XAttributeWrapper(new XAttribute(name, value));
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00006DF0 File Offset: 0x00004FF0
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return new XAttributeWrapper(new XAttribute(XName.Get(MiscellaneousUtils.GetLocalName(qualifiedName), namespaceUri), value));
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x000922FC File Offset: 0x000904FC
		[Nullable(2)]
		public IXmlElement DocumentElement
		{
			[NullableContext(2)]
			get
			{
				while (this.method_1().Root == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return null;
				}
				return new XElementWrapper(this.method_1().Root);
			}
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00092350 File Offset: 0x00090550
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			Class11 @class;
			for (;;)
			{
				@class = newChild as Class11;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					goto IL_0029;
				}
				IL_0030:
				switch (num)
				{
				case 1:
					IL_0029:
					if (@class == null)
					{
						goto Block_2;
					}
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				case 4:
					goto IL_006C;
				}
				break;
				IL_0003:
				this.method_1().Declaration = @class.Declaration;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					break;
				}
				goto IL_0030;
			}
			return @class;
			Block_2:
			IL_006C:
			return base.AppendChild(newChild);
		}
	}
}
