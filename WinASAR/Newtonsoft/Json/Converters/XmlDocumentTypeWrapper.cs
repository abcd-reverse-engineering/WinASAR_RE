using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A3 RID: 419
	[Nullable(0)]
	[NullableContext(2)]
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06001266 RID: 4710 RVA: 0x00091C78 File Offset: 0x0008FE78
		[NullableContext(1)]
		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
			: base(documentType)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.xmlDocumentType_0 = documentType;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
			{
				return;
			}
			IL_0033:
			switch (num)
			{
			case 1:
				goto IL_001B;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00006C3F File Offset: 0x00004E3F
		[Nullable(1)]
		public string Name
		{
			[NullableContext(1)]
			get
			{
				return this.xmlDocumentType_0.Name;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00006C4C File Offset: 0x00004E4C
		public string System
		{
			get
			{
				return this.xmlDocumentType_0.SystemId;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00006C59 File Offset: 0x00004E59
		public string Public
		{
			get
			{
				return this.xmlDocumentType_0.PublicId;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00006C66 File Offset: 0x00004E66
		public string InternalSubset
		{
			get
			{
				return this.xmlDocumentType_0.InternalSubset;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00006C73 File Offset: 0x00004E73
		public override string LocalName
		{
			get
			{
				return Class15.smethod_17(974392023 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
			}
		}

		// Token: 0x0400081C RID: 2076
		[Nullable(1)]
		private readonly XmlDocumentType xmlDocumentType_0;
	}
}
