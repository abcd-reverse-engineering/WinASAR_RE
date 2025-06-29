using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AD RID: 429
	[Nullable(0)]
	[NullableContext(2)]
	internal class XTextWrapper : XObjectWrapper
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00006E09 File Offset: 0x00005009
		[Nullable(1)]
		private XText XText_0
		{
			[NullableContext(1)]
			get
			{
				return (XText)base.WrappedNode;
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000923D0 File Offset: 0x000905D0
		[NullableContext(1)]
		public XTextWrapper(XText text)
			: base(text)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00006E16 File Offset: 0x00005016
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x00092404 File Offset: 0x00090604
		public override string Value
		{
			get
			{
				return this.XText_0.Value;
			}
			set
			{
				for (;;)
				{
					XText xtext_ = this.XText_0;
					string text = value;
					if (value == null)
					{
						text = string.Empty;
					}
					xtext_.Value = text;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x0009244C File Offset: 0x0009064C
		public override IXmlNode ParentNode
		{
			get
			{
				while (this.XText_0.Parent != null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						break;
					}
					switch (num)
					{
					case 0:
						goto IL_004A;
					case 1:
						return XContainerWrapper.WrapNode(this.XText_0.Parent);
					case 2:
						break;
					default:
						goto IL_004A;
					}
				}
				IL_004A:
				return null;
			}
		}
	}
}
