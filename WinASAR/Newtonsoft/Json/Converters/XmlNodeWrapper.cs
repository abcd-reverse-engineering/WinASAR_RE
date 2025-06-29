using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A4 RID: 420
	[Nullable(0)]
	[NullableContext(2)]
	internal class XmlNodeWrapper : IXmlNode
	{
		// Token: 0x0600126F RID: 4719 RVA: 0x00091CCC File Offset: 0x0008FECC
		[NullableContext(1)]
		public XmlNodeWrapper(XmlNode node)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
			{
				goto IL_0035;
			}
			do
			{
				IL_001A:
				this.xmlNode_0 = node;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0);
			IL_0035:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				return;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x00006C8A File Offset: 0x00004E8A
		public object WrappedNode
		{
			get
			{
				return this.xmlNode_0;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00006C92 File Offset: 0x00004E92
		public XmlNodeType NodeType
		{
			get
			{
				return this.xmlNode_0.NodeType;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00006C9F File Offset: 0x00004E9F
		public virtual string LocalName
		{
			get
			{
				return this.xmlNode_0.LocalName;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00091D20 File Offset: 0x0008FF20
		[Nullable(1)]
		public List<IXmlNode> ChildNodes
		{
			[NullableContext(1)]
			get
			{
				if (this.list_0 == null)
				{
					if (!this.xmlNode_0.HasChildNodes)
					{
						this.list_0 = XmlNodeConverter.EmptyChildNodes;
					}
					else
					{
						this.list_0 = new List<IXmlNode>(this.xmlNode_0.ChildNodes.Count);
						foreach (object obj in this.xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							this.list_0.Add(XmlNodeWrapper.WrapNode(xmlNode));
						}
					}
				}
				return this.list_0;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00006CAC File Offset: 0x00004EAC
		protected virtual bool HasChildNodes
		{
			get
			{
				return this.xmlNode_0.HasChildNodes;
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00091DD0 File Offset: 0x0008FFD0
		[NullableContext(1)]
		internal static IXmlNode WrapNode(XmlNode node)
		{
			XmlNodeType nodeType;
			for (;;)
			{
				nodeType = node.NodeType;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
				{
					goto IL_0003;
				}
				IL_0019:
				switch (num)
				{
				case 1:
					IL_0003:
					if (nodeType == XmlNodeType.Element)
					{
						goto IL_006B;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto IL_0019;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_006B;
				case 4:
					goto IL_0077;
				case 5:
					goto IL_008C;
				}
				break;
			}
			if (nodeType != XmlNodeType.DocumentType)
			{
				goto IL_0077;
			}
			return new XmlDocumentTypeWrapper((XmlDocumentType)node);
			IL_006B:
			return new XmlElementWrapper((XmlElement)node);
			IL_0077:
			if (nodeType == XmlNodeType.XmlDeclaration)
			{
				return new XmlDeclarationWrapper((XmlDeclaration)node);
			}
			IL_008C:
			return new XmlNodeWrapper(node);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00091E70 File Offset: 0x00090070
		[Nullable(1)]
		public List<IXmlNode> Attributes
		{
			[NullableContext(1)]
			get
			{
				if (this.list_1 == null)
				{
					if (!this.method_0())
					{
						this.list_1 = XmlNodeConverter.EmptyChildNodes;
					}
					else
					{
						this.list_1 = new List<IXmlNode>(this.xmlNode_0.Attributes.Count);
						foreach (object obj in this.xmlNode_0.Attributes)
						{
							XmlAttribute xmlAttribute = (XmlAttribute)obj;
							this.list_1.Add(XmlNodeWrapper.WrapNode(xmlAttribute));
						}
					}
				}
				return this.list_1;
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00091F18 File Offset: 0x00090118
		private bool method_0()
		{
			XmlElement xmlElement;
			for (;;)
			{
				xmlElement = this.xmlNode_0 as XmlElement;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_001C;
				}
				IL_0015:
				while (xmlElement == null)
				{
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_001C;
					}
				}
				break;
				IL_001C:
				switch (num)
				{
				case 0:
					goto IL_0015;
				case 1:
					break;
				case 2:
					goto IL_0059;
				case 3:
					return false;
				case 4:
					goto IL_0061;
				default:
					goto IL_0015;
				}
			}
			IL_0059:
			return xmlElement.HasAttributes;
			IL_0061:
			XmlAttributeCollection attributes = this.xmlNode_0.Attributes;
			if (attributes != null)
			{
				return attributes.Count > 0;
			}
			return false;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00091FA0 File Offset: 0x000901A0
		public IXmlNode ParentNode
		{
			get
			{
				XmlNode xmlNode2;
				for (;;)
				{
					IL_0065:
					XmlAttribute xmlAttribute = this.xmlNode_0 as XmlAttribute;
					for (;;)
					{
						if (xmlAttribute == null)
						{
							goto IL_003D;
						}
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
						{
							goto IL_0003;
						}
						IL_001D:
						XmlNode xmlNode;
						switch (num)
						{
						case 0:
							goto IL_0003;
						case 1:
							goto IL_0075;
						case 2:
							continue;
						case 3:
							goto IL_0065;
						case 4:
							IL_003D:
							xmlNode = this.xmlNode_0.ParentNode;
							break;
						case 5:
							goto IL_0081;
						default:
							goto IL_0003;
						}
						IL_000A:
						xmlNode2 = xmlNode;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
						{
							goto IL_001D;
						}
						goto IL_0074;
						IL_0003:
						xmlNode = xmlAttribute.OwnerElement;
						goto IL_000A;
					}
				}
				IL_0074:
				IL_0075:
				if (xmlNode2 != null)
				{
					return XmlNodeWrapper.WrapNode(xmlNode2);
				}
				IL_0081:
				return null;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00006CB9 File Offset: 0x00004EB9
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x00092030 File Offset: 0x00090230
		public string Value
		{
			get
			{
				return this.xmlNode_0.Value;
			}
			set
			{
				for (;;)
				{
					this.xmlNode_0.Value = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0009206C File Offset: 0x0009026C
		[NullableContext(1)]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			for (;;)
			{
				IL_005E:
				XmlNodeWrapper xmlNodeWrapper = (XmlNodeWrapper)newChild;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					goto IL_0003;
				}
				for (;;)
				{
					IL_0042:
					switch (num)
					{
					case 1:
						this.list_0 = null;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							continue;
						}
						break;
					case 2:
						return newChild;
					case 3:
						goto IL_0003;
					case 4:
						goto IL_005E;
					}
					goto Block_2;
				}
				IL_0003:
				this.xmlNode_0.AppendChild(xmlNodeWrapper.xmlNode_0);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					break;
				}
				goto IL_0042;
			}
			Block_2:
			this.list_1 = null;
			return newChild;
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00006CC6 File Offset: 0x00004EC6
		public string NamespaceUri
		{
			get
			{
				return this.xmlNode_0.NamespaceURI;
			}
		}

		// Token: 0x0400081E RID: 2078
		[Nullable(1)]
		private readonly XmlNode xmlNode_0;

		// Token: 0x0400081F RID: 2079
		[Nullable(new byte[] { 2, 1 })]
		private List<IXmlNode> list_0;

		// Token: 0x04000820 RID: 2080
		[Nullable(new byte[] { 2, 1 })]
		private List<IXmlNode> list_1;
	}
}
