using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B3 RID: 435
	[NullableContext(1)]
	[Nullable(0)]
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x06001306 RID: 4870 RVA: 0x00006ED5 File Offset: 0x000050D5
		private XElement method_1()
		{
			return (XElement)base.WrappedNode;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00092220 File Offset: 0x00090420
		public XElementWrapper(XElement element)
			: base(element)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00092AD4 File Offset: 0x00090CD4
		public void SetAttributeNode(IXmlNode attribute)
		{
			for (;;)
			{
				XObjectWrapper xobjectWrapper = (XObjectWrapper)attribute;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_0003;
				}
				IL_003F:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0003:
					this.method_1().Add(xobjectWrapper.WrappedNode);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_003F;
					}
					break;
				case 3:
					continue;
				}
				this.list_1 = null;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_003F;
				}
				break;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00092B58 File Offset: 0x00090D58
		public override List<IXmlNode> Attributes
		{
			get
			{
				if (this.list_1 == null)
				{
					if (!this.method_1().HasAttributes && !this.method_2(this.NamespaceUri))
					{
						this.list_1 = XmlNodeConverter.EmptyChildNodes;
					}
					else
					{
						this.list_1 = new List<IXmlNode>();
						foreach (XAttribute xattribute in this.method_1().Attributes())
						{
							this.list_1.Add(new XAttributeWrapper(xattribute));
						}
						string namespaceUri = this.NamespaceUri;
						if (this.method_2(namespaceUri))
						{
							this.list_1.Insert(0, new XAttributeWrapper(new XAttribute(Class15.smethod_17(1985322122 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba), namespaceUri)));
						}
					}
				}
				return this.list_1;
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00092C40 File Offset: 0x00090E40
		private bool method_2(string string_0)
		{
			IL_00D7:
			while (!StringUtils.IsNullOrEmpty(string_0))
			{
				IEnumerator<XAttribute> enumerator;
				bool flag;
				for (;;)
				{
					IL_0006:
					IXmlNode parentNode = this.ParentNode;
					if (string_0 != ((parentNode == null) ? null : parentNode.NamespaceUri))
					{
						while (StringUtils.IsNullOrEmpty(this.GetPrefixOfNamespace(string_0)))
						{
							int num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
							{
								goto IL_0084;
							}
							goto IL_0089;
							do
							{
								IL_005E:
								enumerator = this.method_1().Attributes().GetEnumerator();
								num = 1;
							}
							while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0);
							IL_0089:
							switch (num)
							{
							case 0:
								goto IL_005E;
							case 1:
								goto IL_00E8;
							case 2:
								return false;
							case 3:
								IL_0084:
								flag = false;
								break;
							case 4:
								continue;
							case 5:
								return true;
							case 6:
								goto IL_0006;
							case 7:
								goto IL_00D7;
							case 8:
								goto IL_0202;
							case 9:
								break;
							default:
								goto IL_005E;
							}
							if (!this.method_1().HasAttributes)
							{
								goto IL_0202;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
							{
								goto IL_005E;
							}
							goto IL_0089;
						}
						return false;
					}
					return false;
				}
				IL_00E8:
				try
				{
					while (enumerator.MoveNext())
					{
						for (;;)
						{
							IL_01A8:
							XAttribute xattribute = enumerator.Current;
							IL_017A:
							while (xattribute.Name.LocalName == Class15.smethod_17(543266538 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89))
							{
								int num2 = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
								{
									goto IL_012C;
								}
								for (;;)
								{
									IL_0156:
									switch (num2)
									{
									case 1:
										flag = true;
										num2 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
										{
											continue;
										}
										break;
									case 2:
										goto IL_017A;
									case 3:
										goto IL_012C;
									case 4:
										goto IL_01A8;
									case 5:
										goto IL_01C0;
									case 6:
										goto IL_0103;
									}
									goto Block_15;
								}
								IL_0103:
								if (!(xattribute.Value == string_0))
								{
									break;
								}
								num2 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
								{
									break;
								}
								goto IL_0156;
								IL_012C:
								if (StringUtils.IsNullOrEmpty(xattribute.Name.NamespaceName))
								{
									goto IL_0103;
								}
								break;
							}
							break;
						}
						Block_15:;
					}
					IL_01C0:;
				}
				finally
				{
					if (enumerator != null)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
						{
							goto IL_01F0;
						}
						IL_01D8:
						enumerator.Dispose();
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
						{
							goto IL_0201;
						}
						IL_01F0:
						switch (num3)
						{
						case 1:
							goto IL_01D8;
						}
					}
					IL_0201:;
				}
				IL_0202:
				if (flag)
				{
					break;
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00006EE2 File Offset: 0x000050E2
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			IXmlNode xmlNode = base.AppendChild(newChild);
			this.list_1 = null;
			return xmlNode;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x00006EF2 File Offset: 0x000050F2
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x00092E68 File Offset: 0x00091068
		[Nullable(2)]
		public override string Value
		{
			[NullableContext(2)]
			get
			{
				return this.method_1().Value;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.method_1().Value = value ?? string.Empty;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00006EFF File Offset: 0x000050FF
		[Nullable(2)]
		public override string LocalName
		{
			[NullableContext(2)]
			get
			{
				return this.method_1().Name.LocalName;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00006F11 File Offset: 0x00005111
		[Nullable(2)]
		public override string NamespaceUri
		{
			[NullableContext(2)]
			get
			{
				return this.method_1().Name.NamespaceName;
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00006F23 File Offset: 0x00005123
		[return: Nullable(2)]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return this.method_1().GetPrefixOfNamespace(namespaceUri);
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00006F36 File Offset: 0x00005136
		public bool IsEmpty
		{
			get
			{
				return this.method_1().IsEmpty;
			}
		}

		// Token: 0x0400082F RID: 2095
		[Nullable(new byte[] { 2, 1 })]
		private List<IXmlNode> list_1;
	}
}
