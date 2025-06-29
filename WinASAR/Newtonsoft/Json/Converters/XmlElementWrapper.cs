using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A1 RID: 417
	[NullableContext(1)]
	[Nullable(0)]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00091AEC File Offset: 0x0008FCEC
		public XmlElementWrapper(XmlElement element)
			: base(element)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.xmlElement_0 = element;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00091B40 File Offset: 0x0008FD40
		public void SetAttributeNode(IXmlNode attribute)
		{
			for (;;)
			{
				XmlNodeWrapper xmlNodeWrapper = (XmlNodeWrapper)attribute;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0003;
				}
				IL_002C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.xmlElement_0.SetAttributeNode((XmlAttribute)xmlNodeWrapper.WrappedNode);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					goto IL_002C;
				}
				break;
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00006BFD File Offset: 0x00004DFD
		[return: Nullable(2)]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return this.xmlElement_0.GetPrefixOfNamespace(namespaceUri);
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00006C0B File Offset: 0x00004E0B
		public bool IsEmpty
		{
			get
			{
				return this.xmlElement_0.IsEmpty;
			}
		}

		// Token: 0x04000818 RID: 2072
		private readonly XmlElement xmlElement_0;
	}
}
