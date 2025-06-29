using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AA RID: 426
	[Nullable(0)]
	[NullableContext(2)]
	internal class Class11 : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00006CD3 File Offset: 0x00004ED3
		[Nullable(1)]
		internal XDeclaration Declaration
		{
			[NullableContext(1)]
			get;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00092100 File Offset: 0x00090300
		[NullableContext(1)]
		public Class11(XDeclaration declaration)
			: base(null)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.Declaration = declaration;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
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

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00006CDB File Offset: 0x00004EDB
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.XmlDeclaration;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00006CDF File Offset: 0x00004EDF
		public string Version
		{
			get
			{
				return this.Declaration.Version;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x00092154 File Offset: 0x00090354
		public string Encoding
		{
			get
			{
				return this.Declaration.Encoding;
			}
			set
			{
				for (;;)
				{
					this.Declaration.Encoding = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
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

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00006CF9 File Offset: 0x00004EF9
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x00092190 File Offset: 0x00090390
		public string Standalone
		{
			get
			{
				return this.Declaration.Standalone;
			}
			set
			{
				for (;;)
				{
					this.Declaration.Standalone = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
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

		// Token: 0x04000822 RID: 2082
		[Nullable(1)]
		[CompilerGenerated]
		private readonly XDeclaration xdeclaration_0;
	}
}
