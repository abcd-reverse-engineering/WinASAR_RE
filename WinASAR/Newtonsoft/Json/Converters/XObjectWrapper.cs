using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B1 RID: 433
	[NullableContext(2)]
	[Nullable(0)]
	internal class XObjectWrapper : IXmlNode
	{
		// Token: 0x060012EE RID: 4846 RVA: 0x0009296C File Offset: 0x00090B6C
		public XObjectWrapper(XObject xmlObject)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.xobject_0 = xmlObject;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00006E81 File Offset: 0x00005081
		public object WrappedNode
		{
			get
			{
				return this.xobject_0;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000929C0 File Offset: 0x00090BC0
		public virtual XmlNodeType NodeType
		{
			get
			{
				XObject xobject;
				for (;;)
				{
					xobject = this.xobject_0;
					if (xobject != null)
					{
						goto IL_002F;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
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
				return XmlNodeType.None;
				IL_002F:
				return xobject.NodeType;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00003C0E File Offset: 0x00001E0E
		public virtual string LocalName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x00006E89 File Offset: 0x00005089
		[Nullable(1)]
		public virtual List<IXmlNode> ChildNodes
		{
			[NullableContext(1)]
			get
			{
				return XmlNodeConverter.EmptyChildNodes;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00006E89 File Offset: 0x00005089
		[Nullable(1)]
		public virtual List<IXmlNode> Attributes
		{
			[NullableContext(1)]
			get
			{
				return XmlNodeConverter.EmptyChildNodes;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00003C0E File Offset: 0x00001E0E
		public virtual IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00003C0E File Offset: 0x00001E0E
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00006E90 File Offset: 0x00005090
		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00006E90 File Offset: 0x00005090
		[NullableContext(1)]
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00003C0E File Offset: 0x00001E0E
		public virtual string NamespaceUri
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400082C RID: 2092
		private readonly XObject xobject_0;
	}
}
