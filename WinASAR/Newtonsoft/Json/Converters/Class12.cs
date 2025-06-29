using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AB RID: 427
	[Nullable(0)]
	[NullableContext(2)]
	internal class Class12 : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x060012AE RID: 4782 RVA: 0x000921CC File Offset: 0x000903CC
		[NullableContext(1)]
		public Class12(XDocumentType documentType)
			: base(documentType)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.xdocumentType_0 = documentType;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
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

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00006D06 File Offset: 0x00004F06
		[Nullable(1)]
		public string Name
		{
			[NullableContext(1)]
			get
			{
				return this.xdocumentType_0.Name;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00006D13 File Offset: 0x00004F13
		public string System
		{
			get
			{
				return this.xdocumentType_0.SystemId;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00006D20 File Offset: 0x00004F20
		public string Public
		{
			get
			{
				return this.xdocumentType_0.PublicId;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00006D2D File Offset: 0x00004F2D
		public string InternalSubset
		{
			get
			{
				return this.xdocumentType_0.InternalSubset;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00006D3A File Offset: 0x00004F3A
		public override string LocalName
		{
			get
			{
				return Class15.smethod_17(2048580129 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
			}
		}

		// Token: 0x04000824 RID: 2084
		[Nullable(1)]
		private readonly XDocumentType xdocumentType_0;
	}
}
