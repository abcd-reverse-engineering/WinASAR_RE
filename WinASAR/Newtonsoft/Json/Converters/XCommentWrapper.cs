using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AE RID: 430
	[Nullable(0)]
	[NullableContext(2)]
	internal class XCommentWrapper : XObjectWrapper
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00006E23 File Offset: 0x00005023
		[Nullable(1)]
		private XComment XComment_0
		{
			[NullableContext(1)]
			get
			{
				return (XComment)base.WrappedNode;
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000924A4 File Offset: 0x000906A4
		[NullableContext(1)]
		public XCommentWrapper(XComment text)
			: base(text)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00006E30 File Offset: 0x00005030
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x000924D8 File Offset: 0x000906D8
		public override string Value
		{
			get
			{
				return this.XComment_0.Value;
			}
			set
			{
				for (;;)
				{
					XComment xcomment_ = this.XComment_0;
					string text = value;
					if (value == null)
					{
						text = string.Empty;
					}
					xcomment_.Value = text;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
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

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00092520 File Offset: 0x00090720
		public override IXmlNode ParentNode
		{
			get
			{
				while (this.XComment_0.Parent != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							goto IL_004A;
						}
					}
					return XContainerWrapper.WrapNode(this.XComment_0.Parent);
				}
				IL_004A:
				return null;
			}
		}
	}
}
