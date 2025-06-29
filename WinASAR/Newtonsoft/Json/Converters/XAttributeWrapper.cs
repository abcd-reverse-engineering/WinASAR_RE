using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B2 RID: 434
	[NullableContext(2)]
	[Nullable(0)]
	internal class XAttributeWrapper : XObjectWrapper
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00006E97 File Offset: 0x00005097
		[Nullable(1)]
		private XAttribute XAttribute_0
		{
			[NullableContext(1)]
			get
			{
				return (XAttribute)base.WrappedNode;
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00092A04 File Offset: 0x00090C04
		[NullableContext(1)]
		public XAttributeWrapper(XAttribute attribute)
			: base(attribute)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00006EA4 File Offset: 0x000050A4
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00092A38 File Offset: 0x00090C38
		public override string Value
		{
			get
			{
				return this.XAttribute_0.Value;
			}
			set
			{
				for (;;)
				{
					this.XAttribute_0.Value = value ?? string.Empty;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
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

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00006EB1 File Offset: 0x000050B1
		public override string LocalName
		{
			get
			{
				return this.XAttribute_0.Name.LocalName;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00006EC3 File Offset: 0x000050C3
		public override string NamespaceUri
		{
			get
			{
				return this.XAttribute_0.Name.NamespaceName;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00092A80 File Offset: 0x00090C80
		public override IXmlNode ParentNode
		{
			get
			{
				while (this.XAttribute_0.Parent == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return null;
				}
				return XContainerWrapper.WrapNode(this.XAttribute_0.Parent);
			}
		}
	}
}
