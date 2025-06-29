using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A2 RID: 418
	[NullableContext(2)]
	[Nullable(0)]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x00091BAC File Offset: 0x0008FDAC
		[NullableContext(1)]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
			: base(declaration)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.xmlDeclaration_0 = declaration;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00006C18 File Offset: 0x00004E18
		public string Version
		{
			get
			{
				return this.xmlDeclaration_0.Version;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00006C25 File Offset: 0x00004E25
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x00091C00 File Offset: 0x0008FE00
		public string Encoding
		{
			get
			{
				return this.xmlDeclaration_0.Encoding;
			}
			set
			{
				for (;;)
				{
					this.xmlDeclaration_0.Encoding = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00006C32 File Offset: 0x00004E32
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x00091C3C File Offset: 0x0008FE3C
		public string Standalone
		{
			get
			{
				return this.xmlDeclaration_0.Standalone;
			}
			set
			{
				for (;;)
				{
					this.xmlDeclaration_0.Standalone = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
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

		// Token: 0x0400081A RID: 2074
		[Nullable(1)]
		private readonly XmlDeclaration xmlDeclaration_0;
	}
}
