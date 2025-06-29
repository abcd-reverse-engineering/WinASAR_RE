using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B0 RID: 432
	[Nullable(0)]
	[NullableContext(1)]
	internal class XContainerWrapper : XObjectWrapper
	{
		// Token: 0x060012E4 RID: 4836 RVA: 0x00006E64 File Offset: 0x00005064
		private XContainer method_0()
		{
			return (XContainer)base.WrappedNode;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000925F4 File Offset: 0x000907F4
		public XContainerWrapper(XContainer container)
			: base(container)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00092628 File Offset: 0x00090828
		public override List<IXmlNode> ChildNodes
		{
			get
			{
				if (this.list_0 == null)
				{
					if (!this.HasChildNodes)
					{
						this.list_0 = XmlNodeConverter.EmptyChildNodes;
					}
					else
					{
						this.list_0 = new List<IXmlNode>();
						foreach (XNode xnode in this.method_0().Nodes())
						{
							this.list_0.Add(XContainerWrapper.WrapNode(xnode));
						}
					}
				}
				return this.list_0;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00006E71 File Offset: 0x00005071
		protected virtual bool HasChildNodes
		{
			get
			{
				return this.method_0().LastNode != null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x000926B4 File Offset: 0x000908B4
		[Nullable(2)]
		public override IXmlNode ParentNode
		{
			[NullableContext(2)]
			get
			{
				while (this.method_0().Parent == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return null;
				}
				return XContainerWrapper.WrapNode(this.method_0().Parent);
			}
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00092708 File Offset: 0x00090908
		internal static IXmlNode WrapNode(XObject node)
		{
			XDocument xdocument;
			XText xtext;
			XComment xcomment;
			XAttribute xattribute;
			XDocumentType xdocumentType;
			XProcessingInstruction xprocessingInstruction;
			XContainer xcontainer;
			XElement xelement;
			for (;;)
			{
				IL_019D:
				xdocument = node as XDocument;
				IL_0193:
				while (xdocument == null)
				{
					int num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
					{
						goto IL_00E3;
					}
					for (;;)
					{
						IL_0134:
						switch (num)
						{
						case 1:
							goto IL_008E;
						case 2:
							goto IL_01CA;
						case 3:
							goto IL_0056;
						case 4:
							goto IL_00D9;
						case 5:
							goto IL_01D2;
						case 6:
							goto IL_01DB;
						case 7:
							goto IL_01A7;
						case 8:
							goto IL_0071;
						case 9:
							goto IL_00E3;
						case 10:
							goto IL_01C2;
						case 11:
							goto IL_01B2;
						case 12:
							goto IL_00D2;
						case 13:
							goto IL_01BA;
						case 14:
							goto IL_0193;
						case 15:
							goto IL_019D;
						case 16:
							goto IL_00B7;
						case 17:
							goto IL_006A;
						case 18:
							goto IL_005E;
						case 19:
							goto IL_0020;
						case 20:
							goto IL_01EA;
						}
						break;
						IL_005E:
						if (xtext == null)
						{
							xcomment = node as XComment;
							goto IL_006A;
						}
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
						{
							continue;
						}
						IL_0056:
						xtext = node as XText;
						goto IL_005E;
						IL_0071:
						xattribute = node as XAttribute;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto IL_008E;
						}
						continue;
						IL_006A:
						if (xcomment == null)
						{
							goto IL_0071;
						}
						goto IL_01D2;
					}
					goto IL_00FD;
					IL_0020:
					if (xdocumentType == null)
					{
						goto IL_01E3;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto Block_3;
					}
					goto IL_0134;
					IL_008E:
					if (xattribute != null)
					{
						goto IL_01CA;
					}
					xdocumentType = node as XDocumentType;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_0020;
					}
					goto IL_0134;
					IL_00B7:
					if (xprocessingInstruction != null)
					{
						goto IL_01C2;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_008E;
					}
					goto IL_0134;
					IL_00D9:
					xprocessingInstruction = node as XProcessingInstruction;
					goto IL_00B7;
					IL_00D2:
					if (xcontainer == null)
					{
						goto IL_00D9;
					}
					goto IL_01BA;
					IL_00E3:
					xelement = node as XElement;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_0134;
					}
					IL_00FD:
					if (xelement != null)
					{
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
						{
							goto Block_10;
						}
						goto IL_0134;
					}
					else
					{
						xcontainer = node as XContainer;
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
						{
							goto IL_00D2;
						}
						goto IL_0134;
					}
				}
				goto IL_01EA;
			}
			Block_3:
			goto IL_01DB;
			Block_10:
			goto IL_01D2;
			IL_01A7:
			return new Class12(xdocumentType);
			IL_01B2:
			return new XTextWrapper(xtext);
			IL_01BA:
			return new XContainerWrapper(xcontainer);
			IL_01C2:
			return new XProcessingInstructionWrapper(xprocessingInstruction);
			IL_01CA:
			return new XAttributeWrapper(xattribute);
			IL_01D2:
			return new XCommentWrapper(xcomment);
			IL_01DB:
			return new XElementWrapper(xelement);
			IL_01E3:
			return new XObjectWrapper(node);
			IL_01EA:
			return new XDocumentWrapper(xdocument);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00092908 File Offset: 0x00090B08
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			for (;;)
			{
				this.method_0().Add(newChild.WrappedNode);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return newChild;
				}
				IL_0003:
				this.list_0 = null;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_001B;
				}
			}
			return newChild;
		}

		// Token: 0x0400082A RID: 2090
		[Nullable(new byte[] { 2, 1 })]
		private List<IXmlNode> list_0;
	}
}
