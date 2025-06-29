using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B4 RID: 436
	[NullableContext(1)]
	[Nullable(0)]
	public class XmlNodeConverter : JsonConverter
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00006F43 File Offset: 0x00005143
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x00092EB0 File Offset: 0x000910B0
		[Nullable(2)]
		public string DeserializeRootElementName
		{
			[CompilerGenerated]
			[NullableContext(2)]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00006F4B File Offset: 0x0000514B
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x00092EE8 File Offset: 0x000910E8
		public bool WriteArrayAttribute
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x00006F53 File Offset: 0x00005153
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x00092F20 File Offset: 0x00091120
		public bool OmitRootObject
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00006F5B File Offset: 0x0000515B
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x00092F58 File Offset: 0x00091158
		public bool EncodeSpecialCharacters
		{
			[CompilerGenerated]
			get
			{
				return this.bool_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
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

		// Token: 0x0600131D RID: 4893 RVA: 0x00092F90 File Offset: 0x00091190
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			while (value != null)
			{
				IXmlNode xmlNode = this.method_0(value);
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_0091;
				}
				IL_00C0:
				switch (num)
				{
				case 0:
					goto IL_0079;
				case 1:
					goto IL_004C;
				case 2:
					goto IL_0071;
				case 3:
					goto IL_0091;
				case 4:
					goto IL_0105;
				case 5:
					continue;
				case 6:
				case 8:
					return;
				case 7:
					goto IL_009D;
				case 9:
				case 12:
					break;
				case 10:
					goto IL_0057;
				case 11:
					return;
				default:
					goto IL_0079;
				}
				IL_0026:
				XmlNamespaceManager xmlNamespaceManager;
				this.method_8(writer, xmlNode, xmlNamespaceManager, !this.OmitRootObject);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_004C;
				}
				goto IL_00C0;
				IL_0057:
				writer.WriteEndObject();
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_009D;
				}
				goto IL_00C0;
				IL_004C:
				if (!this.OmitRootObject)
				{
					goto IL_0057;
				}
				return;
				IL_0079:
				writer.WriteStartObject();
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
				{
					goto IL_0091;
				}
				goto IL_00C0;
				IL_0071:
				if (!this.OmitRootObject)
				{
					goto IL_0079;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_0026;
				}
				goto IL_00C0;
				IL_009D:
				this.method_1(xmlNode, xmlNamespaceManager);
				goto IL_0071;
				IL_0091:
				xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
				goto IL_009D;
			}
			IL_0105:
			writer.WriteNull();
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000930AC File Offset: 0x000912AC
		private IXmlNode method_0(object object_0)
		{
			XObject xobject;
			XmlNode xmlNode;
			for (;;)
			{
				IL_0072:
				xobject = object_0 as XObject;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					goto IL_003A;
				}
				goto IL_0052;
				do
				{
					IL_001E:
					xmlNode = object_0 as XmlNode;
					num = 5;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0);
				for (;;)
				{
					IL_0052:
					switch (num)
					{
					case 1:
						goto IL_0072;
					case 2:
						goto IL_00C9;
					case 3:
						goto IL_008E;
					case 4:
						goto IL_001E;
					case 5:
						if (xmlNode == null)
						{
							goto IL_0099;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
						{
							goto Block_2;
						}
						continue;
					}
					break;
				}
				IL_003A:
				if (xobject != null)
				{
					goto IL_008E;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					goto IL_001E;
				}
				goto IL_0052;
			}
			Block_2:
			goto IL_00C9;
			IL_008E:
			return XContainerWrapper.WrapNode(xobject);
			IL_0099:
			throw new ArgumentException(Class15.smethod_17(41452365 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), Class15.smethod_17(1807881700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
			IL_00C9:
			return XmlNodeWrapper.WrapNode(xmlNode);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0009318C File Offset: 0x0009138C
		private void method_1(IXmlNode ixmlNode_0, XmlNamespaceManager xmlNamespaceManager_0)
		{
			List<IXmlNode> list;
			for (;;)
			{
				IL_00BD:
				list = null;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_0031;
				}
				IXmlNode xmlNode;
				for (;;)
				{
					IL_0072:
					switch (num)
					{
					case 1:
						goto IL_0031;
					case 2:
					case 14:
						goto IL_0006;
					case 3:
						xmlNode = ixmlNode_0;
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
						{
							goto Block_4;
						}
						continue;
					case 4:
						goto IL_00BD;
					case 5:
						goto IL_00EE;
					case 6:
					case 15:
						return;
					case 7:
					case 10:
						goto IL_0011;
					case 8:
						goto IL_00DE;
					case 9:
						goto IL_00D7;
					case 11:
					case 13:
						goto IL_004C;
					case 12:
						goto IL_00E5;
					}
					goto Block_5;
				}
				Block_4:
				goto IL_004C;
				Block_5:
				goto IL_002D;
				IL_0011:
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
					{
						goto IL_002D;
					}
					goto IL_0072;
				}
				IL_004C:
				if ((xmlNode = xmlNode.ParentNode) != null)
				{
					goto IL_0011;
				}
				break;
				IL_0006:
				list.Add(xmlNode);
				goto IL_004C;
				IL_002D:
				if (list != null)
				{
					goto IL_0006;
				}
				IL_0031:
				list = new List<IXmlNode>();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_0006;
				}
				goto IL_0072;
			}
			IL_00D7:
			if (list == null)
			{
				return;
			}
			IL_00DE:
			list.Reverse();
			IL_00E5:
			List<IXmlNode>.Enumerator enumerator = list.GetEnumerator();
			IL_00EE:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_00F5;
					}
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						break;
					}
					IL_0122:
					switch (num2)
					{
					case 1:
					{
						IL_00F5:
						IXmlNode xmlNode2 = enumerator.Current;
						xmlNamespaceManager_0.PushScope();
						List<IXmlNode>.Enumerator enumerator2 = xmlNode2.Attributes.GetEnumerator();
						num2 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
						{
							goto IL_0122;
						}
						continue;
					}
					case 2:
						continue;
					case 3:
						try
						{
							for (;;)
							{
								List<IXmlNode>.Enumerator enumerator2;
								if (enumerator2.MoveNext())
								{
									goto IL_01CC;
								}
								int num3 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
								{
									continue;
								}
								goto IL_01A4;
								IL_0144:
								IXmlNode xmlNode3;
								if (xmlNode3.LocalName != Class15.smethod_17(1270956810 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112))
								{
									goto IL_01EC;
								}
								num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
								{
									continue;
								}
								goto IL_01A4;
								IL_017E:
								if (!(xmlNode3.NamespaceUri == Class15.smethod_17(197532089 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81)))
								{
									continue;
								}
								goto IL_0144;
								IL_01CC:
								xmlNode3 = enumerator2.Current;
								num3 = 4;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
								{
									goto IL_017E;
								}
								IL_01A4:
								switch (num3)
								{
								case 0:
								case 3:
								case 6:
									continue;
								case 1:
									goto IL_0220;
								case 2:
									goto IL_01CC;
								case 4:
									goto IL_017E;
								case 5:
									goto IL_0144;
								case 7:
									break;
								default:
									continue;
								}
								IL_01EC:
								xmlNamespaceManager_0.AddNamespace(xmlNode3.LocalName, xmlNode3.Value);
							}
							IL_0220:;
						}
						finally
						{
							List<IXmlNode>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
							int num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
							{
								switch (num4)
								{
								}
							}
						}
						continue;
					}
					break;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num5 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
				{
					switch (num5)
					{
					}
				}
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00093474 File Offset: 0x00091674
		private string method_2(IXmlNode ixmlNode_0, XmlNamespaceManager xmlNamespaceManager_0)
		{
			string text;
			for (;;)
			{
				if (ixmlNode_0.NamespaceUri != null)
				{
					goto IL_0006;
				}
				goto IL_00BF;
				IL_0078:
				int num;
				switch (num)
				{
				case 0:
					goto IL_009D;
				case 1:
					goto IL_00D1;
				case 2:
					break;
				case 3:
					IL_005E:
					if (!StringUtils.IsNullOrEmpty(text))
					{
						goto IL_00DD;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
					{
						goto IL_0078;
					}
					goto IL_00D0;
				case 4:
					goto IL_00DD;
				case 5:
					IL_0006:
					if (!(ixmlNode_0.LocalName == Class15.smethod_17(2128268606 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9)))
					{
						goto IL_009D;
					}
					break;
				case 6:
					continue;
				default:
					goto IL_009D;
				}
				if (ixmlNode_0.NamespaceUri == Class15.smethod_17(552168924 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f))
				{
					goto IL_00BF;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_009D;
				}
				goto IL_0078;
				IL_00A9:
				string text2;
				text = text2;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_005E;
				}
				goto IL_0078;
				IL_00BF:
				text2 = null;
				goto IL_00A9;
				IL_009D:
				text2 = xmlNamespaceManager_0.LookupPrefix(ixmlNode_0.NamespaceUri);
				goto IL_00A9;
			}
			IL_00D0:
			IL_00D1:
			return XmlConvert.DecodeName(ixmlNode_0.LocalName);
			IL_00DD:
			return text + Class15.smethod_17(538799185 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa) + XmlConvert.DecodeName(ixmlNode_0.LocalName);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00093588 File Offset: 0x00091788
		private string method_3(IXmlNode ixmlNode_0, XmlNamespaceManager xmlNamespaceManager_0)
		{
			for (;;)
			{
				XmlNodeType nodeType = ixmlNode_0.NodeType;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
				{
					goto IL_0006;
				}
				IL_00C8:
				switch (num)
				{
				case 1:
					goto IL_0092;
				case 2:
					goto IL_010C;
				case 3:
					goto IL_0211;
				case 4:
					IL_0006:
					switch (nodeType)
					{
					case XmlNodeType.Element:
						if (!(ixmlNode_0.NamespaceUri == Class15.smethod_17(1176480498 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af)))
						{
							goto IL_012D;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
						{
							goto Block_3;
						}
						goto IL_00C8;
					case XmlNodeType.Attribute:
						goto IL_0092;
					case XmlNodeType.Text:
						goto IL_015D;
					case XmlNodeType.CDATA:
						goto IL_0173;
					case XmlNodeType.ProcessingInstruction:
						goto IL_0189;
					case XmlNodeType.Comment:
						goto IL_01AC;
					case XmlNodeType.DocumentType:
						goto IL_01C2;
					case XmlNodeType.Whitespace:
						goto IL_01E5;
					case XmlNodeType.SignificantWhitespace:
						goto IL_01FB;
					case XmlNodeType.XmlDeclaration:
						goto IL_0246;
					}
					goto Block_1;
				case 5:
					continue;
				case 6:
					goto IL_025C;
				}
				goto Block_5;
				IL_0092:
				if (ixmlNode_0.NamespaceUri == Class15.smethod_17(1678070084 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a))
				{
					goto IL_013C;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					goto IL_00C8;
				}
				break;
			}
			Block_1:
			goto IL_0211;
			Block_3:
			goto IL_010C;
			Block_5:
			goto IL_013C;
			IL_010C:
			return Class15.smethod_17(538799277 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa) + ixmlNode_0.LocalName;
			IL_012D:
			return this.method_2(ixmlNode_0, xmlNamespaceManager_0);
			goto IL_0211;
			IL_013C:
			return Class15.smethod_17(1387521032 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923) + ixmlNode_0.LocalName;
			IL_015D:
			return Class15.smethod_17(1829601161 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
			IL_0173:
			return Class15.smethod_17(2060616026 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
			IL_0189:
			return Class15.smethod_17(1829600853 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae) + this.method_2(ixmlNode_0, xmlNamespaceManager_0);
			IL_01AC:
			return Class15.smethod_17(1788656500 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
			IL_01C2:
			return Class15.smethod_17(1829631801 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae) + this.method_2(ixmlNode_0, xmlNamespaceManager_0);
			IL_01E5:
			return Class15.smethod_17(82262966 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909);
			IL_01FB:
			return Class15.smethod_17(1829601211 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
			IL_0211:
			throw new JsonSerializationException(Class15.smethod_17(768761688 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7) + ixmlNode_0.NodeType.ToString());
			IL_0246:
			return Class15.smethod_17(649952580 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
			IL_025C:
			return Class15.smethod_17(635788759 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2) + this.method_2(ixmlNode_0, xmlNamespaceManager_0);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00093814 File Offset: 0x00091A14
		private bool method_4(IXmlNode ixmlNode_0)
		{
			for (;;)
			{
				List<IXmlNode>.Enumerator enumerator = ixmlNode_0.Attributes.GetEnumerator();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0037;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0036;
			}
			return false;
			IL_0036:
			IL_0037:
			bool flag;
			try
			{
				List<IXmlNode>.Enumerator enumerator;
				while (enumerator.MoveNext())
				{
					IXmlNode xmlNode;
					for (;;)
					{
						xmlNode = enumerator.Current;
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
						{
							switch (num2)
							{
							case 1:
								goto IL_007D;
							case 2:
								goto IL_00DF;
							case 3:
								goto IL_00A0;
							case 4:
								continue;
							case 5:
								goto IL_00CF;
							case 6:
								goto IL_00D1;
							}
							break;
						}
						goto IL_007C;
					}
					continue;
					IL_007D:
					if (xmlNode.LocalName == Class15.smethod_17(1985321724 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba))
					{
						goto IL_00A0;
					}
					continue;
					IL_007C:
					goto IL_007D;
					IL_00A0:
					if (!(xmlNode.NamespaceUri == Class15.smethod_17(2060616120 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177)))
					{
						continue;
					}
					IL_00D1:
					flag = XmlConvert.ToBoolean(xmlNode.Value);
					IL_00DF:
					return flag;
				}
				IL_00CF:
				return false;
			}
			finally
			{
				List<IXmlNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					switch (num3)
					{
					}
				}
			}
			return flag;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00093944 File Offset: 0x00091B44
		private void method_5(JsonWriter jsonWriter_0, IXmlNode ixmlNode_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_3)
		{
			Dictionary<string, object> dictionary;
			string text;
			for (;;)
			{
				IL_0303:
				int count = ixmlNode_0.ChildNodes.Count;
				int num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_01C7;
				}
				int num3;
				List<IXmlNode> list;
				string text2;
				for (;;)
				{
					IL_0238:
					int num2;
					switch (num)
					{
					case 0:
						goto IL_0187;
					case 1:
					case 12:
						goto IL_0047;
					case 2:
					case 5:
						goto IL_013F;
					case 3:
						num2++;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
						{
							continue;
						}
						break;
					case 4:
					case 22:
						break;
					case 6:
						goto IL_01AD;
					case 7:
					case 35:
						return;
					case 8:
						return;
					case 9:
						goto IL_006B;
					case 10:
						goto IL_0108;
					case 11:
					case 14:
						goto IL_0038;
					case 13:
						if (dictionary == null)
						{
							goto IL_0183;
						}
						goto IL_0158;
					case 15:
					case 38:
						goto IL_0029;
					case 16:
						goto IL_000A;
					case 17:
						return;
					case 18:
						goto IL_01CE;
					case 19:
					case 32:
					case 39:
					case 44:
						goto IL_0032;
					case 20:
						goto IL_01AA;
					case 21:
						goto IL_033F;
					case 23:
						goto IL_001E;
					case 24:
						goto IL_0165;
					case 25:
						goto IL_008D;
					case 26:
					case 28:
						goto IL_00DA;
					case 27:
						goto IL_0175;
					case 29:
						dictionary = new Dictionary<string, object>();
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
						{
							goto IL_00AE;
						}
						continue;
					case 30:
						goto IL_032A;
					case 31:
						goto IL_036F;
					case 33:
						goto IL_01C7;
					case 34:
						goto IL_0303;
					case 36:
						goto IL_00BC;
					case 37:
						goto IL_0115;
					case 40:
						goto IL_0353;
					case 41:
						goto IL_0183;
					case 42:
						goto IL_00B3;
					case 43:
						goto IL_0158;
					case 45:
						goto IL_014F;
					case 46:
						goto IL_00AE;
					case 47:
						goto IL_0006;
					default:
						goto IL_0187;
					}
					IL_00BF:
					if (num2 >= num3)
					{
						goto IL_0108;
					}
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						goto IL_00DA;
					}
					continue;
					IL_00BC:
					num2 = 0;
					goto IL_00BF;
					IL_00B3:
					list = new List<IXmlNode>(num3);
					goto IL_00BC;
					IL_00AE:
					if (num3 > 1)
					{
						goto IL_00B3;
					}
					goto IL_0115;
					IL_00DA:
					list.Add(ixmlNode_0.ChildNodes[num2]);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						goto Block_5;
					}
					continue;
					IL_0115:
					dictionary.Add(text, ixmlNode_0.ChildNodes[0]);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_013F;
					}
					continue;
					IL_0187:
					if (text2 == text)
					{
						goto IL_0032;
					}
					num = 29;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_01AA;
					}
					continue;
					IL_0183:
					if (text != null)
					{
						goto IL_0187;
					}
					goto IL_014F;
				}
				IL_0029:
				List<IXmlNode> list2;
				IXmlNode xmlNode;
				list2.Add(xmlNode);
				goto IL_0032;
				IL_0006:
				if (list2 == null)
				{
					goto IL_000A;
				}
				goto IL_0029;
				IL_0175:
				object obj;
				list2 = obj as List<IXmlNode>;
				goto IL_0006;
				IL_0158:
				if (!dictionary.TryGetValue(text2, out obj))
				{
					goto IL_0165;
				}
				goto IL_0175;
				Block_5:
				goto IL_0047;
				IL_0108:
				dictionary.Add(text, list);
				goto IL_013F;
				IL_014F:
				text = text2;
				goto IL_0032;
				IL_0165:
				dictionary.Add(text2, xmlNode);
				goto IL_0032;
				IL_001E:
				dictionary[text2] = list2;
				goto IL_0029;
				IL_000A:
				list2 = new List<IXmlNode> { (IXmlNode)obj };
				goto IL_001E;
				IL_0047:
				xmlNode = ixmlNode_0.ChildNodes[num3];
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto IL_006B;
				}
				goto IL_0238;
				IL_0038:
				if (num3 < ixmlNode_0.ChildNodes.Count)
				{
					goto IL_0047;
				}
				goto IL_008D;
				IL_0032:
				num3++;
				goto IL_0038;
				IL_006B:
				text2 = this.method_3(xmlNode, xmlNamespaceManager_0);
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0047;
				}
				goto IL_0238;
				IL_008D:
				if (dictionary != null)
				{
					goto IL_0366;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					break;
				}
				goto IL_0238;
				IL_01AD:
				num3 = 0;
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
				{
					goto IL_013F;
				}
				goto IL_0238;
				IL_01AA:
				text = null;
				goto IL_01AD;
				IL_01CE:
				if (count == 1)
				{
					goto Block_8;
				}
				dictionary = null;
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
				{
					goto IL_01AA;
				}
				goto IL_0238;
				IL_01C7:
				if (count != 0)
				{
					goto IL_01CE;
				}
				return;
				IL_013F:
				dictionary.Add(text2, xmlNode);
				goto IL_0032;
			}
			goto IL_0353;
			Block_8:
			IL_032A:
			string text3 = this.method_3(ixmlNode_0.ChildNodes[0], xmlNamespaceManager_0);
			IL_033F:
			this.method_6(jsonWriter_0, xmlNamespaceManager_0, bool_3, ixmlNode_0.ChildNodes, text3);
			return;
			IL_0353:
			this.method_6(jsonWriter_0, xmlNamespaceManager_0, bool_3, ixmlNode_0.ChildNodes, text);
			return;
			IL_0366:
			Dictionary<string, object>.Enumerator enumerator = dictionary.GetEnumerator();
			IL_036F:
			try
			{
				while (enumerator.MoveNext())
				{
					for (;;)
					{
						IL_041C:
						KeyValuePair<string, object> keyValuePair = enumerator.Current;
						for (;;)
						{
							IL_03FA:
							List<IXmlNode> list3 = keyValuePair.Value as List<IXmlNode>;
							int num4 = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
							{
								goto Block_19;
							}
							for (;;)
							{
								switch (num4)
								{
								case 2:
									goto IL_0437;
								case 3:
									goto IL_03AE;
								case 4:
									goto IL_041C;
								case 5:
									if (list3 != null)
									{
										goto IL_03AE;
									}
									goto IL_0376;
								case 6:
									goto IL_03FA;
								case 7:
									goto IL_0376;
								}
								goto Block_18;
								IL_0376:
								this.method_7(jsonWriter_0, xmlNamespaceManager_0, bool_3, (IXmlNode)keyValuePair.Value, keyValuePair.Key);
								num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
								{
									goto Block_17;
								}
								continue;
								IL_03AE:
								this.method_6(jsonWriter_0, xmlNamespaceManager_0, bool_3, list3, keyValuePair.Key);
								num4 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
								{
									goto IL_042A;
								}
							}
						}
					}
					Block_17:
					Block_18:
					Block_19:
					IL_042A:;
				}
				IL_0437:;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num5 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					switch (num5)
					{
					}
				}
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00093DC8 File Offset: 0x00091FC8
		private void method_6(JsonWriter jsonWriter_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_3, List<IXmlNode> list_0, string string_1)
		{
			if (list_0.Count == 1 && !this.method_4(list_0[0]))
			{
				this.method_8(jsonWriter_0, list_0[0], xmlNamespaceManager_0, bool_3);
				return;
			}
			if (bool_3)
			{
				jsonWriter_0.WritePropertyName(string_1);
			}
			jsonWriter_0.WriteStartArray();
			for (int i = 0; i < list_0.Count; i++)
			{
				this.method_8(jsonWriter_0, list_0[i], xmlNamespaceManager_0, false);
			}
			jsonWriter_0.WriteEndArray();
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00093E40 File Offset: 0x00092040
		private void method_7(JsonWriter jsonWriter_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_3, IXmlNode ixmlNode_0, string string_1)
		{
			while (!this.method_4(ixmlNode_0))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_0015;
				}
				IL_0031:
				switch (num)
				{
				case 0:
					goto IL_0015;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					return;
				case 4:
					goto IL_0079;
				case 5:
					break;
				case 6:
					goto IL_0084;
				case 7:
					IL_006B:
					jsonWriter_0.WritePropertyName(string_1);
					break;
				default:
					goto IL_0015;
				}
				IL_0073:
				jsonWriter_0.WriteStartArray();
				IL_0079:
				this.method_8(jsonWriter_0, ixmlNode_0, xmlNamespaceManager_0, false);
				IL_0084:
				jsonWriter_0.WriteEndArray();
				return;
				IL_0015:
				this.method_8(jsonWriter_0, ixmlNode_0, xmlNamespaceManager_0, bool_3);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
				{
					goto IL_0031;
				}
				return;
			}
			if (bool_3)
			{
				goto IL_006B;
			}
			goto IL_0073;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00093ED8 File Offset: 0x000920D8
		private void method_8(JsonWriter jsonWriter_0, IXmlNode ixmlNode_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_3)
		{
			for (;;)
			{
				IL_0925:
				XmlNodeType nodeType = ixmlNode_0.NodeType;
				for (;;)
				{
					IL_08D5:
					int num;
					IXmlDocumentType xmlDocumentType;
					IXmlDeclaration xmlDeclaration;
					switch (nodeType)
					{
					case XmlNodeType.Element:
						if (this.method_4(ixmlNode_0))
						{
							goto IL_0516;
						}
						goto IL_052F;
					case XmlNodeType.Attribute:
					case XmlNodeType.Text:
					case XmlNodeType.CDATA:
					case XmlNodeType.ProcessingInstruction:
					case XmlNodeType.Whitespace:
					case XmlNodeType.SignificantWhitespace:
						if (!(ixmlNode_0.NamespaceUri == Class15.smethod_17(1243244714 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95)))
						{
							goto IL_0678;
						}
						num = 58;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
						{
							goto Block_36;
						}
						goto IL_070F;
					case XmlNodeType.Comment:
						if (!bool_3)
						{
							goto Block_37;
						}
						goto IL_06A3;
					case XmlNodeType.Document:
					case XmlNodeType.DocumentFragment:
						goto IL_0971;
					case XmlNodeType.DocumentType:
						xmlDocumentType = (IXmlDocumentType)ixmlNode_0;
						goto IL_06EA;
					case XmlNodeType.XmlDeclaration:
						xmlDeclaration = (IXmlDeclaration)ixmlNode_0;
						num = 77;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
						{
							goto IL_04CE;
						}
						goto IL_070F;
					}
					goto Block_39;
					for (;;)
					{
						IL_070F:
						switch (num)
						{
						case 0:
							goto IL_057F;
						case 1:
							goto IL_0107;
						case 2:
							goto IL_06EA;
						case 3:
						case 42:
							goto IL_022A;
						case 4:
							goto IL_09CF;
						case 5:
							return;
						case 6:
						case 23:
							break;
						case 7:
							goto IL_099C;
						case 8:
							return;
						case 9:
							goto IL_09D7;
						case 10:
							goto IL_05D2;
						case 11:
						case 14:
							goto IL_0471;
						case 12:
							goto IL_063F;
						case 13:
							goto IL_06D8;
						case 15:
							goto IL_0435;
						case 16:
							goto IL_0096;
						case 17:
							return;
						case 18:
							return;
						case 19:
							goto IL_08D5;
						case 20:
							goto IL_0925;
						case 21:
						case 71:
							goto IL_01DC;
						case 22:
							goto IL_0230;
						case 24:
							goto IL_051E;
						case 25:
							goto IL_06C6;
						case 26:
							goto IL_06A3;
						case 27:
							goto IL_0449;
						case 28:
							goto IL_0678;
						case 29:
						case 30:
						case 69:
						case 81:
							goto IL_09E4;
						case 31:
							goto IL_00E1;
						case 32:
							goto IL_0499;
						case 33:
							goto IL_0516;
						case 34:
						case 38:
							goto IL_0156;
						case 35:
							goto IL_01C2;
						case 36:
							jsonWriter_0.WriteValue(xmlDocumentType.InternalSubset);
							num = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
							{
								goto IL_057F;
							}
							continue;
						case 37:
							goto IL_0203;
						case 39:
						case 78:
							goto IL_09A9;
						case 40:
							return;
						case 41:
							goto IL_09B6;
						case 43:
						case 68:
							goto IL_025F;
						case 44:
							goto IL_0938;
						case 45:
							goto IL_097F;
						case 46:
							goto IL_0405;
						case 47:
							return;
						case 48:
							goto IL_09C3;
						case 49:
							goto IL_00D4;
						case 50:
							goto IL_01B4;
						case 51:
							goto IL_002E;
						case 52:
							goto IL_0056;
						case 53:
							goto IL_0064;
						case 54:
							return;
						case 55:
							return;
						case 56:
							return;
						case 57:
							goto IL_0624;
						case 58:
							if (ixmlNode_0.Value == Class15.smethod_17(1571005215 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406))
							{
								return;
							}
							num = 28;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
							{
								goto IL_0435;
							}
							continue;
						case 59:
							goto IL_052F;
						case 60:
						case 76:
							goto IL_027B;
						case 61:
							goto IL_05CB;
						case 62:
							goto IL_0275;
						case 63:
							goto IL_05A6;
						case 64:
							jsonWriter_0.WritePropertyName(Class15.smethod_17(564881864 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610));
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
							{
								goto IL_057F;
							}
							continue;
						case 65:
						{
							List<IXmlNode>.Enumerator enumerator = ixmlNode_0.Attributes.GetEnumerator();
							num = 79;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
							{
								goto IL_0516;
							}
							continue;
						}
						case 66:
							goto IL_0139;
						case 67:
							return;
						case 70:
							goto IL_0464;
						case 72:
							goto IL_00B9;
						case 73:
							goto IL_04CE;
						case 74:
							goto IL_0971;
						case 75:
							goto IL_043B;
						case 77:
							jsonWriter_0.WritePropertyName(this.method_3(ixmlNode_0, xmlNamespaceManager_0));
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
							{
								goto IL_0435;
							}
							continue;
						case 79:
							try
							{
								for (;;)
								{
									List<IXmlNode>.Enumerator enumerator;
									if (enumerator.MoveNext())
									{
										goto IL_0389;
									}
									int num2 = 6;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
									{
										goto IL_02E1;
									}
									goto IL_02F3;
									IL_02A3:
									string text2;
									string text = text2;
									num2 = 5;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
									{
										continue;
									}
									goto IL_02F3;
									IL_033A:
									IXmlNode xmlNode;
									if (xmlNode.LocalName != Class15.smethod_17(1760351391 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039))
									{
										text2 = XmlConvert.DecodeName(xmlNode.LocalName);
										goto IL_02A3;
									}
									num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
									{
										goto IL_02EC;
									}
									goto IL_02F3;
									IL_02BC:
									string value;
									if (value == null)
									{
										break;
									}
									xmlNamespaceManager_0.AddNamespace(text, value);
									num2 = 4;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
									{
										goto IL_033A;
									}
									goto IL_02F3;
									IL_02E1:
									value = xmlNode.Value;
									goto IL_02BC;
									IL_02F3:
									switch (num2)
									{
									case 0:
										goto IL_033A;
									case 1:
										IL_0389:
										xmlNode = enumerator.Current;
										goto IL_0363;
									case 2:
										break;
									case 3:
										goto IL_0363;
									case 4:
									case 8:
										continue;
									case 5:
										goto IL_02E1;
									case 6:
										goto IL_03D8;
									case 7:
										goto IL_03BD;
									case 9:
										goto IL_02BC;
									default:
										goto IL_033A;
									}
									IL_02EC:
									text2 = string.Empty;
									goto IL_02A3;
									IL_0363:
									if (xmlNode.NamespaceUri == Class15.smethod_17(768761366 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7))
									{
										goto IL_033A;
									}
								}
								IL_03BD:
								throw new JsonSerializationException(Class15.smethod_17(82262844 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
								IL_03D8:;
							}
							finally
							{
								List<IXmlNode>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
								{
									switch (num3)
									{
									}
								}
							}
							goto IL_0405;
						case 80:
							goto IL_017E;
						case 82:
							goto IL_0028;
						case 83:
							goto IL_09DE;
						default:
							goto IL_057F;
						}
						IL_018C:
						if (!this.method_21(ixmlNode_0.Attributes))
						{
							goto IL_01B4;
						}
						num = 21;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							break;
						}
						continue;
						IL_017E:
						jsonWriter_0.WritePropertyName(this.method_3(ixmlNode_0, xmlNamespaceManager_0));
						goto IL_018C;
						IL_0405:
						if (!bool_3)
						{
							goto IL_018C;
						}
						goto IL_017E;
						IL_01DC:
						if (ixmlNode_0.ChildNodes.Count == 0)
						{
							goto IL_0203;
						}
						num = 42;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
						{
							goto Block_15;
						}
						continue;
						IL_01C2:
						if (ixmlNode_0.ChildNodes[0].NodeType == XmlNodeType.Text)
						{
							goto Block_13;
						}
						goto IL_01DC;
						IL_01B4:
						if (ixmlNode_0.ChildNodes.Count == 1)
						{
							goto IL_01C2;
						}
						goto IL_01DC;
						IL_0203:
						if (ixmlNode_0.Attributes.Count != 0)
						{
							goto IL_022A;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
						{
							goto Block_17;
						}
						continue;
						IL_0230:
						int num4 = 0;
						num = 48;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
						{
							goto IL_027B;
						}
						continue;
						IL_022A:
						jsonWriter_0.WriteStartObject();
						goto IL_0230;
						IL_027B:
						if (num4 >= ixmlNode_0.Attributes.Count)
						{
							goto IL_09B6;
						}
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
						{
							goto IL_025F;
						}
						continue;
						IL_0275:
						num4++;
						goto IL_027B;
						IL_025F:
						this.method_8(jsonWriter_0, ixmlNode_0.Attributes[num4], xmlNamespaceManager_0, true);
						goto IL_0275;
						IL_0471:
						if (!StringUtils.IsNullOrEmpty(xmlDeclaration.Encoding))
						{
							goto IL_0499;
						}
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
						{
							goto Block_23;
						}
						continue;
						IL_0464:
						jsonWriter_0.WriteValue(xmlDeclaration.Version);
						goto IL_0471;
						IL_0449:
						jsonWriter_0.WritePropertyName(Class15.smethod_17(1571004765 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
						goto IL_0464;
						IL_043B:
						if (!StringUtils.IsNullOrEmpty(xmlDeclaration.Version))
						{
							goto IL_0449;
						}
						goto IL_0471;
						IL_0435:
						jsonWriter_0.WriteStartObject();
						goto IL_043B;
						IL_0499:
						jsonWriter_0.WritePropertyName(Class15.smethod_17(1788796643 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
						{
							goto Block_24;
						}
						continue;
						IL_057F:
						jsonWriter_0.WriteValue(xmlDeclaration.Standalone);
						num = 49;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
						{
							goto Block_27;
						}
					}
					continue;
					IL_063F:
					jsonWriter_0.WriteValue(xmlDocumentType.Name);
					goto IL_0056;
					IL_0624:
					jsonWriter_0.WritePropertyName(Class15.smethod_17(2128267434 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
					goto IL_063F;
					IL_06D8:
					jsonWriter_0.WriteValue(xmlDocumentType.Public);
					goto IL_0096;
					Block_27:
					goto IL_0139;
					IL_06C6:
					jsonWriter_0.WriteValue(xmlDeclaration.Encoding);
					Block_23:
					goto IL_0156;
					IL_002E:
					if (StringUtils.IsNullOrEmpty(xmlDocumentType.Name))
					{
						goto IL_0056;
					}
					num = 57;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
					{
						goto Block_3;
					}
					goto IL_070F;
					IL_0028:
					jsonWriter_0.WriteStartObject();
					goto IL_002E;
					IL_0064:
					jsonWriter_0.WritePropertyName(Class15.smethod_17(552169380 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto IL_0107;
					}
					goto IL_070F;
					IL_0056:
					if (!StringUtils.IsNullOrEmpty(xmlDocumentType.Public))
					{
						goto IL_0064;
					}
					IL_0096:
					if (!StringUtils.IsNullOrEmpty(xmlDocumentType.System))
					{
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
						{
							goto IL_00B9;
						}
						goto IL_070F;
					}
					IL_00E1:
					if (StringUtils.IsNullOrEmpty(xmlDocumentType.InternalSubset))
					{
						goto IL_09D7;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto IL_0107;
					}
					goto IL_070F;
					IL_00D4:
					jsonWriter_0.WriteValue(xmlDocumentType.System);
					goto IL_00E1;
					IL_00B9:
					jsonWriter_0.WritePropertyName(Class15.smethod_17(926388097 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
					goto IL_00D4;
					IL_0107:
					jsonWriter_0.WritePropertyName(Class15.smethod_17(676691706 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
					num = 36;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						goto IL_0156;
					}
					goto IL_070F;
					IL_0139:
					jsonWriter_0.WriteEndObject();
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto IL_0107;
					}
					goto IL_070F;
					IL_0156:
					if (StringUtils.IsNullOrEmpty(xmlDeclaration.Standalone))
					{
						goto IL_0139;
					}
					num = 64;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto Block_10;
					}
					goto IL_070F;
					IL_04CE:
					jsonWriter_0.WriteValue(ixmlNode_0.Value);
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto Block_25;
					}
					goto IL_070F;
					IL_05D2:
					jsonWriter_0.WritePropertyName(this.method_3(ixmlNode_0, xmlNamespaceManager_0));
					goto IL_04CE;
					IL_05CB:
					if (bool_3)
					{
						goto IL_05D2;
					}
					goto IL_04CE;
					IL_0678:
					if (!(ixmlNode_0.NamespaceUri == Class15.smethod_17(1793916088 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a)))
					{
						goto IL_05CB;
					}
					IL_05A6:
					if (!(ixmlNode_0.LocalName == Class15.smethod_17(1743146238 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8)))
					{
						goto IL_05CB;
					}
					return;
					IL_052F:
					xmlNamespaceManager_0.PushScope();
					num = 65;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_00E1;
					}
					goto IL_070F;
					IL_051E:
					if (ixmlNode_0.ChildNodes.Count <= 0)
					{
						goto IL_052F;
					}
					goto IL_09C3;
					IL_0516:
					if (XmlNodeConverter.smethod_0(ixmlNode_0))
					{
						goto IL_051E;
					}
					goto IL_052F;
					IL_06A3:
					jsonWriter_0.WriteComment(ixmlNode_0.Value);
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto Block_32;
					}
					goto IL_070F;
					IL_06EA:
					jsonWriter_0.WritePropertyName(this.method_3(ixmlNode_0, xmlNamespaceManager_0));
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_0028;
					}
					goto IL_070F;
				}
			}
			Block_3:
			goto IL_09C3;
			Block_10:
			goto IL_09CF;
			Block_13:
			goto IL_097F;
			Block_15:
			goto IL_09E4;
			Block_17:
			goto IL_099C;
			Block_24:
			return;
			Block_25:
			return;
			Block_32:
			return;
			Block_36:
			goto IL_09B6;
			Block_37:
			return;
			Block_39:
			IL_0938:
			throw new JsonSerializationException(Class15.smethod_17(432103085 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2) + ixmlNode_0.NodeType.ToString());
			IL_0971:
			this.method_5(jsonWriter_0, ixmlNode_0, xmlNamespaceManager_0, bool_3);
			return;
			IL_097F:
			jsonWriter_0.WriteValue(ixmlNode_0.ChildNodes[0].Value);
			goto IL_09E4;
			IL_099C:
			if (((IXmlElement)ixmlNode_0).IsEmpty)
			{
				goto IL_09CF;
			}
			IL_09A9:
			jsonWriter_0.WriteValue(string.Empty);
			goto IL_09E4;
			IL_09B6:
			this.method_5(jsonWriter_0, ixmlNode_0, xmlNamespaceManager_0, true);
			goto IL_09DE;
			IL_09C3:
			this.method_5(jsonWriter_0, ixmlNode_0, xmlNamespaceManager_0, false);
			return;
			IL_09CF:
			jsonWriter_0.WriteNull();
			goto IL_09E4;
			IL_09D7:
			jsonWriter_0.WriteEndObject();
			return;
			IL_09DE:
			jsonWriter_0.WriteEndObject();
			IL_09E4:
			xmlNamespaceManager_0.PopScope();
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000948EC File Offset: 0x00092AEC
		private static bool smethod_0(IXmlNode ixmlNode_0)
		{
			for (;;)
			{
				List<IXmlNode>.Enumerator enumerator = ixmlNode_0.ChildNodes.GetEnumerator();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0037;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0036;
			}
			return true;
			IL_0036:
			IL_0037:
			bool flag;
			try
			{
				for (;;)
				{
					List<IXmlNode>.Enumerator enumerator;
					if (enumerator.MoveNext())
					{
						goto IL_007D;
					}
					int num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						break;
					}
					IL_0061:
					switch (num2)
					{
					case 1:
						continue;
					case 2:
						goto IL_00BF;
					case 3:
						goto IL_00C1;
					case 4:
						IL_007D:
						if (!(enumerator.Current.LocalName != ixmlNode_0.LocalName))
						{
							continue;
						}
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							goto IL_0061;
						}
						break;
					}
					flag = false;
					num2 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						goto IL_0061;
					}
					goto IL_00BC;
				}
				goto IL_00BF;
				IL_00BC:
				goto IL_00C1;
				IL_00BF:
				return true;
				IL_00C1:;
			}
			finally
			{
				List<IXmlNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					switch (num3)
					{
					}
				}
			}
			return flag;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000949FC File Offset: 0x00092BFC
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			JsonToken tokenType;
			XmlNamespaceManager xmlNamespaceManager;
			IXmlNode xmlNode;
			IXmlDocument xmlDocument;
			for (;;)
			{
				tokenType = reader.TokenType;
				int num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					goto IL_00F7;
				}
				IL_0186:
				switch (num)
				{
				case 1:
					goto IL_0039;
				case 2:
				case 36:
					goto IL_02B3;
				case 3:
				case 20:
					goto IL_0126;
				case 4:
					goto IL_00A6;
				case 5:
					goto IL_00D9;
				case 6:
					goto IL_0260;
				case 7:
					goto IL_0325;
				case 8:
					goto IL_010E;
				case 9:
					goto IL_002E;
				case 10:
					goto IL_02EF;
				case 11:
					goto IL_0082;
				case 12:
					goto IL_024B;
				case 13:
				case 31:
					goto IL_02F7;
				case 14:
				case 28:
					goto IL_00CD;
				case 15:
				case 27:
					goto IL_0032;
				case 16:
					goto IL_0114;
				case 17:
				case 25:
					goto IL_0067;
				case 18:
					goto IL_0150;
				case 19:
					goto IL_02C5;
				case 21:
					goto IL_0281;
				case 22:
					goto IL_02A0;
				case 23:
					goto IL_001B;
				case 24:
					goto IL_0111;
				case 26:
					goto IL_016B;
				case 29:
					goto IL_013B;
				case 30:
					goto IL_025A;
				case 32:
					goto IL_0094;
				case 33:
					goto IL_00B8;
				case 34:
					IL_00F7:
					if (tokenType != JsonToken.StartObject)
					{
						goto Block_4;
					}
					xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
					goto IL_010E;
				case 35:
					continue;
				case 37:
					goto IL_0006;
				}
				goto Block_7;
				IL_0039:
				if (xmlNode == null)
				{
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						break;
					}
					goto IL_0186;
				}
				else
				{
					if (StringUtils.IsNullOrEmpty(this.DeserializeRootElementName))
					{
						goto IL_0067;
					}
					goto IL_02A0;
				}
				IL_0032:
				if (xmlDocument != null)
				{
					goto IL_0039;
				}
				goto IL_02F7;
				IL_002E:
				xmlNode = xmlDocument;
				goto IL_0032;
				IL_001B:
				xmlDocument = new XmlDocumentWrapper(new XmlDocument
				{
					XmlResolver = null
				});
				goto IL_002E;
				IL_0006:
				if (!(objectType != typeof(XmlNode)))
				{
					goto IL_001B;
				}
				goto IL_0325;
				IL_0067:
				reader.ReadAndAssert();
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_0082;
				}
				goto IL_0186;
				IL_00D9:
				xmlNode = xmlDocument;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					break;
				}
				goto IL_0186;
				IL_00CD:
				xmlDocument = new XDocumentWrapper(new XDocument());
				goto IL_00D9;
				IL_00A6:
				if (objectType != typeof(XNode))
				{
					goto IL_00B8;
				}
				goto IL_00CD;
				IL_0094:
				if (objectType != typeof(XElement))
				{
					goto IL_00A6;
				}
				goto IL_00CD;
				IL_0082:
				if (objectType != typeof(XDocument))
				{
					goto IL_0094;
				}
				goto IL_00CD;
				IL_0126:
				if (typeof(XmlNode).IsAssignableFrom(objectType))
				{
					goto IL_013B;
				}
				goto IL_0032;
				IL_0114:
				if (!typeof(XObject).IsAssignableFrom(objectType))
				{
					goto IL_0126;
				}
				goto IL_016B;
				IL_0111:
				xmlNode = null;
				goto IL_0114;
				IL_010E:
				xmlDocument = null;
				goto IL_0111;
				IL_013B:
				if (!(objectType != typeof(XmlDocument)))
				{
					goto IL_001B;
				}
				IL_0150:
				if (objectType != typeof(XmlElement))
				{
					goto IL_0006;
				}
				goto IL_001B;
				IL_00B8:
				if (!(objectType != typeof(XObject)))
				{
					goto IL_00CD;
				}
				goto IL_0281;
				IL_016B:
				if (objectType != typeof(XContainer))
				{
					goto IL_0082;
				}
				goto IL_00CD;
			}
			goto IL_02B3;
			Block_4:
			goto IL_025A;
			Block_7:
			goto IL_0341;
			IL_024B:
			this.method_19(reader, xmlDocument, xmlNamespaceManager, xmlNode);
			goto IL_02B3;
			IL_025A:
			if (tokenType != JsonToken.Null)
			{
				throw JsonSerializationException.Create(reader, Class15.smethod_17(41453441 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d));
			}
			IL_0260:
			return null;
			IL_0281:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1176480054 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
			IL_02A0:
			this.method_10(reader, xmlDocument, xmlNode, this.DeserializeRootElementName, xmlNamespaceManager);
			IL_02B3:
			if (!(objectType == typeof(XElement)))
			{
				if (!(objectType == typeof(XmlElement)))
				{
					goto IL_02EF;
				}
				goto IL_0341;
			}
			IL_02C5:
			XElement xelement = (XElement)xmlDocument.DocumentElement.WrappedNode;
			xelement.Remove();
			return xelement;
			IL_02EF:
			return xmlDocument.WrappedNode;
			IL_02F7:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1829594041 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae) + ((objectType != null) ? objectType.ToString() : null));
			IL_0325:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1788651504 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
			IL_0341:
			return xmlDocument.DocumentElement.WrappedNode;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00094D58 File Offset: 0x00092F58
		private void method_9(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, XmlNamespaceManager xmlNamespaceManager_0, string string_1, IXmlNode ixmlNode_0)
		{
			for (;;)
			{
				IL_02B1:
				if (this.EncodeSpecialCharacters)
				{
					goto IL_00FF;
				}
				goto IL_0290;
				int num;
				for (;;)
				{
					IL_01D4:
					switch (num)
					{
					case 0:
						goto IL_016A;
					case 1:
						goto IL_00DB;
					case 2:
						goto IL_0252;
					case 3:
					case 16:
						goto IL_0056;
					case 4:
						return;
					case 5:
						return;
					case 6:
						this.method_16(jsonReader_0, ixmlDocument_0, ixmlNode_0, string_1);
						num = 17;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
						{
							goto Block_14;
						}
						continue;
					case 7:
						if (!(string_1 == Class15.smethod_17(543264864 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89)))
						{
							goto IL_0135;
						}
						goto IL_02C5;
					case 8:
						return;
					case 9:
						goto IL_00A7;
					case 10:
						goto IL_02E4;
					case 11:
						return;
					case 12:
						goto IL_00FF;
					case 13:
						goto IL_02B1;
					case 14:
						goto IL_0135;
					case 15:
						return;
					case 17:
						return;
					case 18:
						break;
					case 19:
						return;
					case 20:
						goto IL_0290;
					case 21:
						goto IL_0034;
					case 22:
						return;
					default:
						goto IL_016A;
					}
					IL_0084:
					if (string_1[0] != '?')
					{
						goto IL_00A7;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_00DB;
					}
					continue;
					IL_016A:
					if (!StringUtils.IsNullOrEmpty(string_1))
					{
						goto IL_0084;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_00A7;
					}
					continue;
					IL_0135:
					if (!(string_1 == Class15.smethod_17(1802330335 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4)))
					{
						goto IL_016A;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto Block_10;
					}
					continue;
					IL_00A7:
					if (!string.Equals(string_1, Class15.smethod_17(926388399 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296), StringComparison.OrdinalIgnoreCase))
					{
						goto IL_00FF;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						continue;
					}
					IL_00DB:
					this.method_17(jsonReader_0, ixmlDocument_0, ixmlNode_0);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto Block_6;
					}
				}
				Block_14:
				goto IL_0056;
				IL_0252:
				if (!(string_1 == Class15.smethod_17(2057037057 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48)))
				{
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto Block_16;
					}
					goto IL_01D4;
				}
				else
				{
					ixmlNode_0.AppendChild(ixmlDocument_0.imethod_0(XmlNodeConverter.smethod_2(jsonReader_0)));
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
					{
						break;
					}
					goto IL_01D4;
				}
				IL_0034:
				this.method_12(jsonReader_0, ixmlDocument_0, string_1, ixmlNode_0, xmlNamespaceManager_0);
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_0056;
				}
				goto IL_01D4;
				IL_00FF:
				if (jsonReader_0.TokenType == JsonToken.StartArray)
				{
					goto IL_0034;
				}
				this.method_10(jsonReader_0, ixmlDocument_0, ixmlNode_0, string_1, xmlNamespaceManager_0);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_0252;
				}
				goto IL_01D4;
				IL_0056:
				ixmlNode_0.AppendChild(ixmlDocument_0.CreateTextNode(XmlNodeConverter.smethod_2(jsonReader_0)));
				num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					goto Block_2;
				}
				goto IL_01D4;
				IL_0290:
				if (!(string_1 == Class15.smethod_17(1760350823 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039)))
				{
					goto IL_0252;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_0056;
				}
				goto IL_01D4;
			}
			return;
			Block_2:
			goto IL_02E4;
			Block_6:
			return;
			Block_10:
			goto IL_02E4;
			Block_16:
			return;
			IL_02C5:
			ixmlNode_0.AppendChild(ixmlDocument_0.CreateWhitespace(XmlNodeConverter.smethod_2(jsonReader_0)));
			return;
			IL_02E4:
			ixmlNode_0.AppendChild(ixmlDocument_0.CreateSignificantWhitespace(XmlNodeConverter.smethod_2(jsonReader_0)));
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00095060 File Offset: 0x00093260
		private void method_10(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, IXmlNode ixmlNode_0, string string_1, XmlNamespaceManager xmlNamespaceManager_0)
		{
			IL_02BE:
			while (!StringUtils.IsNullOrEmpty(string_1))
			{
				Dictionary<string, string> dictionary = null;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_021E;
				}
				string text;
				for (;;)
				{
					IL_022F:
					switch (num)
					{
					case 1:
						goto IL_01D8;
					case 2:
						goto IL_02CD;
					case 3:
						return;
					case 4:
						goto IL_01A2;
					case 5:
						goto IL_0221;
					case 6:
						goto IL_021E;
					case 7:
					case 8:
					case 31:
						goto IL_0329;
					case 9:
						goto IL_0051;
					case 10:
						goto IL_02E0;
					case 11:
						goto IL_00D1;
					case 12:
						goto IL_0127;
					case 13:
						goto IL_0043;
					case 14:
						goto IL_02EC;
					case 15:
						goto IL_0095;
					case 16:
						goto IL_00B3;
					case 17:
						goto IL_01AC;
					case 18:
						text = xmlNamespaceManager_0.LookupPrefix(Class15.smethod_17(698949028 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
						{
							goto Block_8;
						}
						continue;
					case 19:
						goto IL_033C;
					case 20:
						goto IL_0146;
					case 21:
						return;
					case 22:
						return;
					case 23:
						goto IL_00EF;
					case 24:
						goto IL_01DE;
					case 25:
						goto IL_02FE;
					case 26:
						return;
					case 27:
						goto IL_0306;
					case 28:
						goto IL_02BE;
					case 29:
						goto IL_01CC;
					case 30:
						goto IL_017E;
					case 32:
						goto IL_0023;
					}
					goto Block_10;
				}
				IL_01DE:
				text = MiscellaneousUtils.GetPrefix(string_1);
				goto IL_0043;
				Block_10:
				goto IL_0074;
				Block_8:
				goto IL_01D8;
				IL_02CD:
				this.method_11(jsonReader_0, ixmlDocument_0, ixmlNode_0, string_1, xmlNamespaceManager_0, text, dictionary);
				return;
				IL_02EC:
				string text2;
				string text3;
				XmlNodeConverter.smethod_1(jsonReader_0, ixmlDocument_0, ixmlNode_0, string_1, text2, xmlNamespaceManager_0, text3);
				return;
				IL_0306:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(2008611667 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
				IL_002C:
				Dictionary<string, string> dictionary2;
				dictionary = dictionary2;
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					goto IL_0043;
				}
				goto IL_022F;
				IL_01D8:
				dictionary2 = null;
				goto IL_002C;
				IL_01CC:
				if (!this.method_14(jsonReader_0))
				{
					goto IL_01D8;
				}
				goto IL_0023;
				IL_0221:
				if (this.EncodeSpecialCharacters)
				{
					goto IL_02E0;
				}
				goto IL_01CC;
				IL_021E:
				text = null;
				goto IL_0221;
				IL_0023:
				dictionary2 = this.method_15(jsonReader_0, xmlNamespaceManager_0);
				goto IL_002C;
				IL_0051:
				if (!string_1.StartsWith('$'))
				{
					goto IL_0329;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_0074;
				}
				goto IL_022F;
				IL_0043:
				if (!string_1.StartsWith('@'))
				{
					goto IL_0051;
				}
				goto IL_01A2;
				IL_00EF:
				if (string_1 == Class15.smethod_17(1570988459 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406))
				{
					goto IL_0127;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_0329;
				}
				goto IL_022F;
				IL_00D1:
				if (!(string_1 == Class15.smethod_17(2060600096 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177)))
				{
					goto IL_00EF;
				}
				goto IL_0127;
				IL_00B3:
				if (!(string_1 == Class15.smethod_17(1042121229 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad)))
				{
					goto IL_00D1;
				}
				goto IL_0127;
				IL_0095:
				if (!(string_1 == Class15.smethod_17(1387493198 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923)))
				{
					goto IL_00B3;
				}
				goto IL_0127;
				IL_0074:
				if (!(string_1 == Class15.smethod_17(1760343017 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039)))
				{
					goto IL_0095;
				}
				goto IL_017E;
				IL_0127:
				text2 = string_1.Substring(1);
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
				{
					goto IL_022F;
				}
				IL_0146:
				text3 = xmlNamespaceManager_0.LookupPrefix(Class15.smethod_17(635788603 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2));
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto IL_0329;
				}
				goto IL_022F;
				IL_017E:
				string_1 = string_1.Substring(1);
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_0329;
				}
				goto IL_022F;
				IL_01AC:
				string text4;
				string prefix = MiscellaneousUtils.GetPrefix(text4);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_033C;
				}
				goto IL_022F;
				IL_01A2:
				text4 = string_1.Substring(1);
				goto IL_01AC;
				IL_02E0:
				if (!this.method_14(jsonReader_0))
				{
					goto IL_0329;
				}
				IL_02FE:
				jsonReader_0.ReadAndAssert();
				IL_0329:
				this.method_11(jsonReader_0, ixmlDocument_0, ixmlNode_0, string_1, xmlNamespaceManager_0, text, dictionary);
				return;
				IL_033C:
				XmlNodeConverter.smethod_1(jsonReader_0, ixmlDocument_0, ixmlNode_0, string_1, text4, xmlNamespaceManager_0, prefix);
				return;
			}
			goto IL_0306;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x000953BC File Offset: 0x000935BC
		private void method_11(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, IXmlNode ixmlNode_0, string string_1, XmlNamespaceManager xmlNamespaceManager_0, [Nullable(2)] string elementPrefix, [Nullable(new byte[] { 2, 1, 2 })] Dictionary<string, string> attributeNameValues)
		{
			IXmlElement xmlElement = this.method_18(string_1, ixmlDocument_0, elementPrefix, xmlNamespaceManager_0);
			ixmlNode_0.AppendChild(xmlElement);
			if (attributeNameValues != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in attributeNameValues)
				{
					string text = XmlConvert.EncodeName(keyValuePair.Key);
					string prefix = MiscellaneousUtils.GetPrefix(keyValuePair.Key);
					IXmlNode xmlNode = ((!StringUtils.IsNullOrEmpty(prefix)) ? ixmlDocument_0.CreateAttribute(text, xmlNamespaceManager_0.LookupNamespace(prefix) ?? string.Empty, keyValuePair.Value) : ixmlDocument_0.CreateAttribute(text, keyValuePair.Value));
					xmlElement.SetAttributeNode(xmlNode);
				}
			}
			switch (jsonReader_0.TokenType)
			{
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
			{
				string text2 = XmlNodeConverter.smethod_2(jsonReader_0);
				if (text2 != null)
				{
					xmlElement.AppendChild(ixmlDocument_0.CreateTextNode(text2));
					return;
				}
				return;
			}
			case JsonToken.Null:
				return;
			case JsonToken.EndObject:
				xmlNamespaceManager_0.RemoveNamespace(string.Empty, xmlNamespaceManager_0.DefaultNamespace);
				return;
			}
			xmlNamespaceManager_0.PushScope();
			this.method_19(jsonReader_0, ixmlDocument_0, xmlNamespaceManager_0, xmlElement);
			xmlNamespaceManager_0.PopScope();
			xmlNamespaceManager_0.RemoveNamespace(string.Empty, xmlNamespaceManager_0.DefaultNamespace);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00095520 File Offset: 0x00093720
		private static void smethod_1(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, object object_0, object object_1, string string_1, XmlNamespaceManager xmlNamespaceManager_0, [Nullable(2)] string attributePrefix)
		{
			IXmlNode xmlNode;
			for (;;)
			{
				int num;
				string text;
				if (((IXmlNode)object_0).NodeType == XmlNodeType.Document)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto Block_4;
					}
				}
				else
				{
					text = XmlConvert.EncodeName(string_1);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
					{
						goto IL_0061;
					}
				}
				IL_006B:
				switch (num)
				{
				case 0:
					goto IL_0061;
				case 1:
					goto IL_00B4;
				case 2:
					continue;
				case 3:
					goto IL_002C;
				case 4:
					goto IL_00DC;
				case 5:
					goto IL_0023;
				case 6:
					return;
				default:
					goto IL_0061;
				}
				IL_004B:
				IXmlNode xmlNode2;
				xmlNode = xmlNode2;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					break;
				}
				goto IL_006B;
				IL_0023:
				if (StringUtils.IsNullOrEmpty(attributePrefix))
				{
					goto IL_002C;
				}
				string text2;
				xmlNode2 = ixmlDocument_0.CreateAttribute(text, xmlNamespaceManager_0.LookupNamespace(attributePrefix), text2);
				goto IL_004B;
				IL_0061:
				text2 = XmlNodeConverter.smethod_2(jsonReader_0);
				goto IL_0023;
				IL_002C:
				xmlNode2 = ixmlDocument_0.CreateAttribute(text, text2);
				goto IL_004B;
			}
			goto IL_00DC;
			Block_4:
			IL_00B4:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1743147194 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, object_1));
			IL_00DC:
			((IXmlElement)object_0).SetAttributeNode(xmlNode);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00095618 File Offset: 0x00093818
		[return: Nullable(2)]
		private static string smethod_2(JsonReader jsonReader_0)
		{
			object obj;
			object value;
			DateTimeOffset dateTimeOffset;
			for (;;)
			{
				IL_013F:
				JsonToken tokenType = jsonReader_0.TokenType;
				for (;;)
				{
					int num;
					switch (tokenType)
					{
					case JsonToken.Integer:
						obj = jsonReader_0.Value;
						goto IL_0042;
					case JsonToken.Float:
						goto IL_0149;
					case JsonToken.String:
						IL_0065:
						value = jsonReader_0.Value;
						if (value != null)
						{
							goto IL_01B1;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
						{
							goto Block_6;
						}
						goto IL_0098;
					case JsonToken.Boolean:
						goto IL_0153;
					case JsonToken.Null:
						goto IL_0169;
					case JsonToken.Date:
						obj = jsonReader_0.Value;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
						{
							goto IL_0089;
						}
						goto IL_0098;
					case JsonToken.Bytes:
						goto IL_025D;
					}
					goto Block_9;
					IL_0098:
					switch (num)
					{
					case 1:
						goto IL_01B8;
					case 2:
						goto IL_01C9;
					case 3:
						goto IL_01D2;
					case 4:
						goto IL_0240;
					case 5:
						goto IL_01AF;
					case 6:
						continue;
					case 7:
						goto IL_013F;
					case 8:
						IL_0089:
						if (!(obj is DateTimeOffset))
						{
							goto Block_7;
						}
						goto IL_0022;
					case 9:
						goto IL_016B;
					case 10:
						goto IL_017E;
					case 11:
						goto IL_018C;
					case 12:
						goto IL_01A2;
					case 13:
						goto IL_0065;
					case 14:
						goto IL_01C1;
					case 15:
						IL_0042:
						if (obj is BigInteger)
						{
							goto IL_01C9;
						}
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
						{
							goto Block_4;
						}
						goto IL_0098;
					case 16:
						goto IL_01DF;
					case 17:
						goto IL_01F5;
					case 18:
						goto IL_0226;
					case 19:
						goto IL_022E;
					case 20:
						goto IL_0022;
					}
					goto Block_8;
					IL_0022:
					dateTimeOffset = (DateTimeOffset)obj;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto Block_2;
					}
					goto IL_0098;
				}
			}
			Block_2:
			goto IL_0255;
			Block_4:
			goto IL_01B8;
			Block_6:
			goto IL_01AF;
			Block_7:
			goto IL_022E;
			Block_8:
			goto IL_0255;
			Block_9:
			goto IL_01F5;
			IL_0149:
			obj = jsonReader_0.Value;
			goto IL_016B;
			IL_0153:
			return XmlConvert.ToString(Convert.ToBoolean(jsonReader_0.Value, CultureInfo.InvariantCulture));
			IL_0169:
			return null;
			IL_016B:
			if (!(obj is decimal))
			{
				obj = jsonReader_0.Value;
				goto IL_01A2;
			}
			IL_017E:
			decimal num2 = (decimal)obj;
			goto IL_0226;
			IL_018C:
			return XmlConvert.ToString(Convert.ToInt64(jsonReader_0.Value, CultureInfo.InvariantCulture));
			IL_01A2:
			if (!(obj is float))
			{
				goto IL_01DF;
			}
			goto IL_01B8;
			IL_01AF:
			return null;
			IL_01B1:
			return value.ToString();
			IL_01B8:
			float num3 = (float)obj;
			IL_01C1:
			return XmlConvert.ToString(num3);
			IL_01C9:
			BigInteger bigInteger = (BigInteger)obj;
			IL_01D2:
			return bigInteger.ToString(CultureInfo.InvariantCulture);
			IL_01DF:
			return XmlConvert.ToString(Convert.ToDouble(jsonReader_0.Value, CultureInfo.InvariantCulture));
			IL_01F5:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(2008611177 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, jsonReader_0.TokenType));
			IL_0226:
			return XmlConvert.ToString(num2);
			IL_022E:
			DateTime dateTime = Convert.ToDateTime(jsonReader_0.Value, CultureInfo.InvariantCulture);
			IL_0240:
			return XmlConvert.ToString(dateTime, DateTimeUtils.ToSerializationMode(dateTime.Kind));
			IL_0255:
			return XmlConvert.ToString(dateTimeOffset);
			IL_025D:
			return Convert.ToBase64String((byte[])jsonReader_0.Value);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00095894 File Offset: 0x00093A94
		private void method_12(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, string string_1, IXmlNode ixmlNode_0, XmlNamespaceManager xmlNamespaceManager_0)
		{
			IXmlElement xmlElement;
			for (;;)
			{
				IL_010A:
				string prefix = MiscellaneousUtils.GetPrefix(string_1);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_0066;
				}
				int num2;
				for (;;)
				{
					IL_00BE:
					switch (num)
					{
					case 1:
						xmlElement = this.method_18(string_1, ixmlDocument_0, prefix, xmlNamespaceManager_0);
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							continue;
						}
						goto IL_0109;
					case 2:
						goto IL_010A;
					case 3:
						return;
					case 4:
						goto IL_0020;
					case 5:
					case 9:
						goto IL_0026;
					case 6:
						goto IL_0013;
					case 7:
						goto IL_006E;
					case 8:
						goto IL_004B;
					case 10:
						goto IL_009A;
					case 11:
						goto IL_0129;
					case 12:
						goto IL_0043;
					case 13:
						ixmlNode_0.AppendChild(xmlElement);
						goto IL_009A;
					case 14:
						goto IL_0137;
					case 15:
						goto IL_0006;
					}
					goto Block_5;
					IL_0006:
					if (jsonReader_0.TokenType != JsonToken.EndArray)
					{
						goto IL_0013;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						goto IL_0043;
					}
					continue;
					IL_0026:
					if (jsonReader_0.Read())
					{
						goto IL_0006;
					}
					goto IL_0043;
					IL_0020:
					num2++;
					goto IL_0026;
					IL_0013:
					this.method_9(jsonReader_0, ixmlDocument_0, xmlNamespaceManager_0, string_1, xmlElement);
					goto IL_0020;
					IL_004B:
					this.method_13(xmlElement, ixmlDocument_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_0066;
					}
					continue;
					IL_0043:
					if (this.WriteArrayAttribute)
					{
						goto IL_004B;
					}
					goto IL_0066;
					IL_009A:
					num2 = 0;
					goto IL_0026;
				}
				IL_0109:
				continue;
				Block_5:
				goto IL_0066;
				IL_006E:
				if (!this.WriteArrayAttribute)
				{
					break;
				}
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					break;
				}
				goto IL_00BE;
				IL_0066:
				if (num2 == 1)
				{
					goto IL_006E;
				}
				break;
			}
			return;
			IL_0129:
			List<IXmlNode>.Enumerator enumerator = xmlElement.ChildNodes.GetEnumerator();
			IL_0137:
			try
			{
				IL_01B2:
				while (enumerator.MoveNext())
				{
					for (;;)
					{
						IXmlElement xmlElement2 = enumerator.Current as IXmlElement;
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
						{
							goto IL_0165;
						}
						IL_016C:
						switch (num3)
						{
						case 0:
							goto IL_0165;
						case 1:
							goto IL_01BE;
						case 2:
							goto IL_01B2;
						case 3:
							continue;
						case 4:
							break;
						case 5:
							goto IL_01C0;
						case 6:
							goto IL_013B;
						default:
							goto IL_0165;
						}
						IL_014A:
						this.method_13(xmlElement2, ixmlDocument_0);
						num3 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
						{
							goto IL_0165;
						}
						goto IL_016C;
						IL_013B:
						if (xmlElement2.LocalName == string_1)
						{
							goto IL_014A;
						}
						goto IL_01B2;
						IL_0165:
						if (xmlElement2 != null)
						{
							goto IL_013B;
						}
						goto IL_01B2;
					}
					IL_01BE:
					IL_01C0:
					break;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					switch (num4)
					{
					}
				}
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00095AA0 File Offset: 0x00093CA0
		private void method_13(IXmlElement ixmlElement_0, IXmlDocument ixmlDocument_0)
		{
			for (;;)
			{
				ixmlElement_0.SetAttributeNode(ixmlDocument_0.CreateAttribute(Class15.smethod_17(1471400519 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e), Class15.smethod_17(2021149180 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), Class15.smethod_17(2048530331 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18)));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_0088;
				}
				IL_00A7:
				switch (num)
				{
				case 0:
					goto IL_0088;
				case 1:
					continue;
				case 2:
				case 4:
					return;
				case 3:
					break;
				case 5:
					goto IL_0006;
				default:
					goto IL_0088;
				}
				IL_0026:
				ixmlElement_0.SetAttributeNode(ixmlDocument_0.CreateAttribute(Class15.smethod_17(926388763 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296), Class15.smethod_17(1788656570 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), Class15.smethod_17(2008606319 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb)));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					break;
				}
				goto IL_00A7;
				IL_0006:
				if (ixmlElement_0.GetPrefixOfNamespace(Class15.smethod_17(41452749 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d)) == null)
				{
					goto IL_0026;
				}
				break;
				IL_0088:
				if (ixmlElement_0 is XElementWrapper)
				{
					goto IL_0006;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_00A7;
				}
				break;
			}
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00095BDC File Offset: 0x00093DDC
		private bool method_14(JsonReader jsonReader_0)
		{
			for (;;)
			{
				IL_0071:
				JsonToken tokenType = jsonReader_0.TokenType;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					return true;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return true;
					case 2:
						switch (tokenType)
						{
						case JsonToken.StartConstructor:
						case JsonToken.Integer:
						case JsonToken.Float:
						case JsonToken.String:
						case JsonToken.Boolean:
						case JsonToken.Null:
						case JsonToken.Date:
						case JsonToken.Bytes:
							break;
						case JsonToken.PropertyName:
						case JsonToken.Comment:
						case JsonToken.Raw:
						case JsonToken.Undefined:
						case JsonToken.EndObject:
						case JsonToken.EndArray:
						case JsonToken.EndConstructor:
							return true;
						default:
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
							{
								continue;
							}
							return true;
						}
						break;
					case 3:
						goto IL_0071;
					}
					goto Block_2;
				}
			}
			Block_2:
			return false;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00095C7C File Offset: 0x00093E7C
		[return: Nullable(new byte[] { 2, 1, 2 })]
		private Dictionary<string, string> method_15(JsonReader jsonReader_0, XmlNamespaceManager xmlNamespaceManager_0)
		{
			Dictionary<string, string> dictionary = null;
			bool flag = false;
			while (!flag && jsonReader_0.Read())
			{
				JsonToken tokenType = jsonReader_0.TokenType;
				if (tokenType != JsonToken.PropertyName)
				{
					if (tokenType != JsonToken.Comment && tokenType != JsonToken.EndObject)
					{
						throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1396522388 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7) + jsonReader_0.TokenType.ToString());
					}
					flag = true;
				}
				else
				{
					string text = jsonReader_0.Value.ToString();
					if (!StringUtils.IsNullOrEmpty(text))
					{
						char c = text[0];
						if (c != '$')
						{
							if (c == '@')
							{
								if (dictionary == null)
								{
									dictionary = new Dictionary<string, string>();
								}
								text = text.Substring(1);
								jsonReader_0.ReadAndAssert();
								string text2 = XmlNodeConverter.smethod_2(jsonReader_0);
								dictionary.Add(text, text2);
								string text3;
								if (this.method_20(text, out text3))
								{
									xmlNamespaceManager_0.AddNamespace(text3, text2);
								}
							}
							else
							{
								flag = true;
							}
						}
						else if (!(text == Class15.smethod_17(1387496474 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923)) && !(text == Class15.smethod_17(1424569970 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf)) && !(text == Class15.smethod_17(2071432490 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808)) && !(text == Class15.smethod_17(552185608 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f)) && !(text == Class15.smethod_17(1807883860 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3)))
						{
							flag = true;
						}
						else
						{
							string text4 = xmlNamespaceManager_0.LookupPrefix(Class15.smethod_17(552168848 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
							if (text4 == null)
							{
								if (dictionary == null)
								{
									dictionary = new Dictionary<string, string>();
								}
								int? num = null;
								int? num2;
								for (;;)
								{
									string text5 = Class15.smethod_17(594410190 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b);
									num2 = num;
									if (xmlNamespaceManager_0.LookupNamespace(text5 + num2.ToString()) == null)
									{
										break;
									}
									num = new int?(num.GetValueOrDefault() + 1);
								}
								string text6 = Class15.smethod_17(613141333 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6);
								num2 = num;
								text4 = text6 + num2.ToString();
								dictionary.Add(Class15.smethod_17(1270963004 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112) + text4, Class15.smethod_17(124781812 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
								xmlNamespaceManager_0.AddNamespace(text4, Class15.smethod_17(2048581057 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18));
							}
							if (text == Class15.smethod_17(1387496474 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923))
							{
								flag = true;
							}
							else
							{
								text = text.Substring(1);
								jsonReader_0.ReadAndAssert();
								if (!JsonTokenUtils.IsPrimitiveToken(jsonReader_0.TokenType))
								{
									throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(642178190 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba) + jsonReader_0.TokenType.ToString());
								}
								if (dictionary == null)
								{
									dictionary = new Dictionary<string, string>();
								}
								object value = jsonReader_0.Value;
								string text2 = ((value != null) ? value.ToString() : null);
								dictionary.Add(text4 + Class15.smethod_17(1603853100 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c) + text, text2);
							}
						}
					}
					else
					{
						flag = true;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00095FC4 File Offset: 0x000941C4
		private void method_16(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, IXmlNode ixmlNode_0, string string_1)
		{
			string text2;
			string text3;
			string text5;
			for (;;)
			{
				IL_026C:
				if (string_1 == Class15.smethod_17(649952580 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff))
				{
					goto IL_0238;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto Block_16;
				}
				for (;;)
				{
					IL_01B3:
					string text;
					switch (num)
					{
					case 1:
					case 16:
					case 20:
					case 22:
						goto IL_005E;
					case 2:
						if (jsonReader_0.TokenType != JsonToken.EndObject)
						{
							goto IL_0167;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto Block_13;
						}
						continue;
					case 3:
						goto IL_0319;
					case 4:
						goto IL_0167;
					case 5:
						goto IL_00AC;
					case 6:
						goto IL_0029;
					case 7:
						goto IL_0296;
					case 8:
						goto IL_026C;
					case 9:
						goto IL_0140;
					case 10:
						goto IL_0041;
					case 11:
					case 18:
						goto IL_00D0;
					case 12:
						goto IL_010E;
					case 13:
						if (!(text == Class15.smethod_17(1176479920 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af)))
						{
							goto IL_010E;
						}
						goto IL_00A1;
					case 14:
						return;
					case 15:
					case 17:
						goto IL_02AE;
					case 19:
						goto IL_02E4;
					case 21:
						goto IL_000C;
					case 23:
						goto IL_02EF;
					case 24:
						goto IL_0080;
					case 25:
						text2 = XmlNodeConverter.smethod_2(jsonReader_0);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
						{
							goto Block_5;
						}
						continue;
					case 26:
						goto IL_00A9;
					case 27:
						return;
					case 28:
					case 30:
						goto IL_0006;
					case 29:
						goto IL_00A1;
					}
					goto Block_14;
					IL_000C:
					text3 = XmlNodeConverter.smethod_2(jsonReader_0);
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto IL_0029;
					}
					continue;
					IL_0006:
					jsonReader_0.ReadAndAssert();
					goto IL_000C;
					IL_0140:
					if (text == Class15.smethod_17(543265636 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89))
					{
						goto IL_0006;
					}
					goto IL_02AE;
					IL_010E:
					if (!(text == Class15.smethod_17(676691524 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b)))
					{
						goto IL_0140;
					}
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						goto IL_00D0;
					}
					continue;
					IL_002A:
					string text4;
					text = text4;
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_0041;
					}
					continue;
					IL_0167:
					object value = jsonReader_0.Value;
					if (value != null)
					{
						text4 = value.ToString();
						goto IL_002A;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto Block_11;
					}
					continue;
					IL_0029:
					text4 = null;
					goto IL_002A;
					IL_00D0:
					jsonReader_0.ReadAndAssert();
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto Block_6;
					}
				}
				IL_00A1:
				jsonReader_0.ReadAndAssert();
				goto IL_0041;
				Block_5:
				goto IL_005E;
				IL_00AC:
				text3 = null;
				goto IL_005E;
				IL_00A9:
				text2 = null;
				goto IL_00AC;
				Block_13:
				goto IL_0080;
				Block_14:
				goto IL_0238;
				IL_0041:
				text5 = XmlNodeConverter.smethod_2(jsonReader_0);
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_01B3;
				}
				IL_005E:
				if (jsonReader_0.Read())
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						goto IL_0238;
					}
					goto IL_01B3;
				}
				IL_0080:
				if (text5 != null)
				{
					goto IL_030B;
				}
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					break;
				}
				goto IL_01B3;
				IL_0238:
				text5 = null;
				num = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					goto IL_0041;
				}
				goto IL_01B3;
			}
			Block_6:
			goto IL_02EF;
			Block_11:
			goto IL_0319;
			Block_16:
			IL_0296:
			IXmlNode xmlNode = ixmlDocument_0.CreateProcessingInstruction(string_1.Substring(1), XmlNodeConverter.smethod_2(jsonReader_0));
			goto IL_02E4;
			IL_02AE:
			string text6 = Class15.smethod_17(277645556 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
			object value2 = jsonReader_0.Value;
			throw JsonSerializationException.Create(jsonReader_0, text6 + ((value2 == null) ? null : value2.ToString()));
			IL_02E4:
			ixmlNode_0.AppendChild(xmlNode);
			return;
			IL_02EF:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1243246700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95));
			IL_030B:
			IXmlNode xmlNode2 = ixmlDocument_0.CreateXmlDeclaration(text5, text2, text3);
			IL_0319:
			ixmlNode_0.AppendChild(xmlNode2);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000962F4 File Offset: 0x000944F4
		private void method_17(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, IXmlNode ixmlNode_0)
		{
			for (;;)
			{
				IL_0282:
				string text = null;
				for (;;)
				{
					IL_027D:
					string text2 = null;
					for (;;)
					{
						IL_0260:
						string text3 = null;
						int num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
						{
							goto IL_00D8;
						}
						goto IL_01CD;
						IL_001B:
						while (jsonReader_0.Read())
						{
							num = 17;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
							{
								goto IL_01CD;
							}
						}
						goto IL_0023;
						string text4;
						for (;;)
						{
							IL_01CD:
							switch (num)
							{
							case 0:
							case 23:
								goto IL_0152;
							case 1:
							case 21:
								goto IL_00D8;
							case 2:
								goto IL_01B2;
							case 3:
								break;
							case 4:
							case 6:
							case 9:
							case 15:
							case 33:
								goto IL_001B;
							case 5:
								goto IL_01C5;
							case 7:
							case 30:
								goto IL_009D;
							case 8:
							case 18:
								goto IL_0109;
							case 10:
								goto IL_0023;
							case 11:
								goto IL_00DE;
							case 12:
								goto IL_02BD;
							case 13:
								goto IL_00EB;
							case 14:
								goto IL_004F;
							case 16:
								goto IL_0131;
							case 17:
								if (jsonReader_0.TokenType != JsonToken.EndObject)
								{
									goto IL_01B2;
								}
								num = 10;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
								{
									goto IL_0109;
								}
								continue;
							case 19:
								return;
							case 20:
							case 25:
								goto IL_0287;
							case 22:
								goto IL_0260;
							case 24:
								goto IL_016A;
							case 26:
								goto IL_0177;
							case 27:
								if (!(text4 == Class15.smethod_17(613127947 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6)))
								{
									goto IL_00EB;
								}
								num = 7;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
								{
									goto IL_00D8;
								}
								continue;
							case 28:
								goto IL_027D;
							case 29:
								goto IL_0282;
							case 31:
								goto IL_007C;
							case 32:
								goto IL_0072;
							default:
								goto IL_0152;
							}
							IL_010F:
							text2 = XmlNodeConverter.smethod_2(jsonReader_0);
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
							{
								goto Block_4;
							}
							continue;
							IL_0109:
							jsonReader_0.ReadAndAssert();
							goto IL_010F;
							IL_00EB:
							if (text4 == Class15.smethod_17(635789071 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2))
							{
								goto IL_0109;
							}
							goto IL_0131;
							IL_0152:
							jsonReader_0.ReadAndAssert();
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
							{
								goto IL_016A;
							}
							continue;
							IL_0131:
							if (text4 == Class15.smethod_17(2021149658 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8))
							{
								goto IL_0152;
							}
							goto IL_007C;
							IL_0178:
							string text5;
							text4 = text5;
							num = 27;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
							{
								goto Block_5;
							}
							continue;
							IL_01B2:
							object value = jsonReader_0.Value;
							if (value != null)
							{
								text5 = value.ToString();
								goto IL_0178;
							}
							IL_0177:
							text5 = null;
							goto IL_0178;
						}
						IL_0072:
						string text6 = XmlNodeConverter.smethod_2(jsonReader_0);
						goto IL_001B;
						IL_009D:
						jsonReader_0.ReadAndAssert();
						goto IL_0072;
						IL_007C:
						if (text4 == Class15.smethod_17(1176479802 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af))
						{
							goto IL_009D;
						}
						goto IL_0287;
						Block_5:
						goto IL_00D8;
						Block_4:
						goto IL_001B;
						IL_016A:
						text3 = XmlNodeConverter.smethod_2(jsonReader_0);
						goto IL_001B;
						IL_01C5:
						text6 = null;
						goto IL_001B;
						IL_0023:
						if (text == null)
						{
							goto IL_02BD;
						}
						IXmlNode xmlNode = ixmlDocument_0.CreateXmlDocumentType(text, text2, text3, text6);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
						{
							goto IL_01CD;
						}
						IL_004F:
						ixmlNode_0.AppendChild(xmlNode);
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
						{
							goto Block_2;
						}
						goto IL_01CD;
						IL_00DE:
						text = XmlNodeConverter.smethod_2(jsonReader_0);
						goto IL_001B;
						IL_00D8:
						jsonReader_0.ReadAndAssert();
						goto IL_00DE;
					}
				}
			}
			Block_2:
			return;
			IL_0287:
			string text7 = Class15.smethod_17(1270963452 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112);
			object value2 = jsonReader_0.Value;
			throw JsonSerializationException.Create(jsonReader_0, text7 + ((value2 != null) ? value2.ToString() : null));
			IL_02BD:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1471401121 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000965DC File Offset: 0x000947DC
		private IXmlElement method_18(string string_1, IXmlDocument ixmlDocument_0, [Nullable(2)] string elementPrefix, XmlNamespaceManager xmlNamespaceManager_0)
		{
			string text2;
			string text4;
			for (;;)
			{
				IL_0078:
				if (!this.EncodeSpecialCharacters)
				{
					goto IL_006E;
				}
				string text = XmlConvert.EncodeLocalName(string_1);
				IL_0074:
				text2 = text;
				for (;;)
				{
					string text3;
					if (StringUtils.IsNullOrEmpty(elementPrefix))
					{
						text3 = xmlNamespaceManager_0.DefaultNamespace;
						goto IL_0012;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_0045;
					}
					IL_0025:
					switch (num)
					{
					case 1:
						IL_0045:
						text3 = xmlNamespaceManager_0.LookupNamespace(elementPrefix);
						goto IL_0012;
					case 2:
						goto IL_0098;
					case 3:
						continue;
					case 4:
						goto IL_006E;
					case 5:
						goto IL_0078;
					}
					goto Block_1;
					IL_0012:
					text4 = text3;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						goto IL_0025;
					}
					goto IL_0083;
				}
				IL_006E:
				text = XmlConvert.EncodeName(string_1);
				goto IL_0074;
			}
			Block_1:
			IL_0083:
			if (!StringUtils.IsNullOrEmpty(text4))
			{
				return ixmlDocument_0.CreateElement(text2, text4);
			}
			IL_0098:
			return ixmlDocument_0.CreateElement(text2);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0009668C File Offset: 0x0009488C
		private void method_19(JsonReader jsonReader_0, IXmlDocument ixmlDocument_0, XmlNamespaceManager xmlNamespaceManager_0, IXmlNode ixmlNode_0)
		{
			JsonToken tokenType;
			for (;;)
			{
				IL_0001:
				tokenType = jsonReader_0.TokenType;
				for (;;)
				{
					string text;
					int num;
					switch (tokenType)
					{
					case JsonToken.StartConstructor:
						IL_01DF:
						text = jsonReader_0.Value.ToString();
						goto IL_0164;
					case JsonToken.PropertyName:
						IL_0194:
						if (ixmlNode_0.NodeType != XmlNodeType.Document)
						{
							goto IL_01D0;
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
						{
							goto IL_01B1;
						}
						goto IL_01F1;
					case JsonToken.Comment:
						IL_0024:
						ixmlNode_0.AppendChild(ixmlDocument_0.CreateComment((string)jsonReader_0.Value));
						num = 35;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
						{
							goto IL_039F;
						}
						goto IL_01F1;
					}
					goto Block_0;
					IL_01F1:
					switch (num)
					{
					case 0:
					case 29:
						goto IL_00CC;
					case 1:
						goto IL_0097;
					case 2:
					case 26:
						return;
					case 3:
						goto IL_00FB;
					case 4:
						goto IL_00DC;
					case 5:
					case 8:
					case 27:
					case 31:
					case 36:
						goto IL_039F;
					case 6:
						goto IL_01B1;
					case 7:
						goto IL_00F2;
					case 9:
						goto IL_03AD;
					case 10:
						goto IL_0142;
					case 11:
						continue;
					case 12:
					case 28:
						goto IL_0001;
					case 13:
						goto IL_03B5;
					case 14:
					case 32:
						goto IL_0164;
					case 15:
						goto IL_0392;
					case 16:
						goto IL_00E7;
					case 17:
						goto IL_01DF;
					case 18:
						goto IL_00A4;
					case 19:
						goto IL_0194;
					case 20:
						goto IL_00B1;
					case 21:
						goto IL_0024;
					case 22:
						goto IL_0135;
					case 23:
						return;
					case 24:
						IL_0189:
						jsonReader_0.ReadAndAssert();
						goto IL_0071;
					case 25:
						goto IL_010D;
					case 30:
						goto IL_03EF;
					case 33:
						break;
					case 34:
					case 35:
						goto IL_00D4;
					case 37:
						goto IL_0299;
					case 38:
						goto IL_0071;
					default:
						goto IL_00CC;
					}
					IL_007D:
					int num2 = 0;
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_00CC;
					}
					goto IL_01F1;
					IL_0071:
					if (jsonReader_0.TokenType == JsonToken.StartArray)
					{
						goto IL_007D;
					}
					goto IL_0392;
					IL_01D0:
					string text2 = jsonReader_0.Value.ToString();
					goto IL_0189;
					IL_01B1:
					if (ixmlDocument_0.DocumentElement == null)
					{
						goto IL_01D0;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto Block_11;
					}
					goto IL_01F1;
					IL_00B1:
					num2++;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
					{
						goto IL_00CC;
					}
					goto IL_01F1;
					IL_00A4:
					this.method_9(jsonReader_0, ixmlDocument_0, xmlNamespaceManager_0, text2, ixmlNode_0);
					goto IL_00B1;
					IL_0097:
					if (jsonReader_0.TokenType == JsonToken.EndArray)
					{
						goto IL_00D4;
					}
					goto IL_00A4;
					IL_00CC:
					if (!jsonReader_0.Read())
					{
						goto IL_00D4;
					}
					goto IL_0097;
					IL_010D:
					List<IXmlNode>.Enumerator enumerator = ixmlNode_0.ChildNodes.GetEnumerator();
					num = 36;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						goto IL_0299;
					}
					goto IL_01F1;
					IL_010B:
					string text4;
					string text3 = text4;
					goto IL_010D;
					IL_00F2:
					string text5;
					if (!StringUtils.IsNullOrEmpty(text5))
					{
						goto IL_00FB;
					}
					text4 = xmlNamespaceManager_0.DefaultNamespace;
					goto IL_010B;
					IL_00E7:
					string text6;
					MiscellaneousUtils.GetQualifiedNameParts(text2, out text5, out text6);
					goto IL_00F2;
					IL_00DC:
					if (this.WriteArrayAttribute)
					{
						goto IL_00E7;
					}
					goto IL_039F;
					IL_00D4:
					if (num2 == 1)
					{
						goto IL_00DC;
					}
					goto IL_039F;
					IL_00FB:
					text4 = xmlNamespaceManager_0.LookupNamespace(text5);
					goto IL_010B;
					IL_0135:
					if (jsonReader_0.TokenType != JsonToken.EndConstructor)
					{
						goto IL_0142;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
					{
						goto IL_00DC;
					}
					goto IL_01F1;
					IL_0164:
					if (!jsonReader_0.Read())
					{
						goto IL_039F;
					}
					goto IL_0135;
					IL_0142:
					this.method_9(jsonReader_0, ixmlDocument_0, xmlNamespaceManager_0, text, ixmlNode_0);
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_0164;
					}
					goto IL_01F1;
					IL_039F:
					if (!jsonReader_0.Read())
					{
						return;
					}
					num = 28;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_010D;
					}
					goto IL_01F1;
					IL_0392:
					this.method_9(jsonReader_0, ixmlDocument_0, xmlNamespaceManager_0, text2, ixmlNode_0);
					goto IL_039F;
					IL_0299:
					try
					{
						IL_0359:
						while (enumerator.MoveNext())
						{
							for (;;)
							{
								IL_0345:
								IXmlElement xmlElement = enumerator.Current as IXmlElement;
								for (;;)
								{
									if (xmlElement != null)
									{
										goto IL_0314;
									}
									int num3 = 3;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
									{
										goto Block_19;
									}
									IL_02D0:
									switch (num3)
									{
									case 1:
									case 7:
									case 8:
										goto IL_0359;
									case 2:
										goto IL_0345;
									case 3:
										continue;
									case 4:
										goto IL_02B3;
									case 5:
										goto IL_02A0;
									case 9:
										IL_0314:
										if (xmlElement.LocalName == text6)
										{
											goto IL_02A0;
										}
										num3 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
										{
											goto Block_17;
										}
										goto IL_02D0;
									}
									goto Block_16;
									IL_02B3:
									this.method_13(xmlElement, ixmlDocument_0);
									num3 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
									{
										goto IL_02D0;
									}
									goto IL_0364;
									IL_02A0:
									if (xmlElement.NamespaceUri == text3)
									{
										goto IL_02B3;
									}
									goto IL_0359;
								}
							}
							Block_16:
							break;
							Block_17:
							Block_19:
							continue;
							IL_0364:
							break;
						}
						goto IL_039F;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
						{
							switch (num4)
							{
							}
						}
					}
					goto IL_0392;
				}
			}
			Block_0:
			goto IL_03AD;
			Block_11:
			goto IL_03EF;
			IL_03AD:
			if (tokenType - JsonToken.EndObject <= 1)
			{
				return;
			}
			IL_03B5:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(698943256 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a) + jsonReader_0.TokenType.ToString());
			IL_03EF:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1387527462 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923));
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00096AB4 File Offset: 0x00094CB4
		private bool method_20(string string_1, [NotNullWhen(true)] [Nullable(2)] out string prefix)
		{
			for (;;)
			{
				IL_00A8:
				if (string_1.StartsWith(Class15.smethod_17(2071457254 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808), StringComparison.Ordinal))
				{
					goto IL_0082;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					break;
				}
				for (;;)
				{
					IL_0046:
					switch (num)
					{
					case 1:
						goto IL_00A8;
					case 2:
						goto IL_00CF;
					case 3:
						return true;
					case 4:
						prefix = string.Empty;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							continue;
						}
						return true;
					case 5:
						return false;
					case 6:
						goto IL_0082;
					case 7:
						return true;
					}
					goto Block_3;
				}
				IL_0082:
				if (string_1.Length == 5)
				{
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
					{
						goto IL_0046;
					}
				}
				else
				{
					if (string_1[5] != ':')
					{
						break;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
					{
						break;
					}
					goto IL_0046;
				}
			}
			Block_3:
			goto IL_00E7;
			IL_00CF:
			prefix = string_1.Substring(6, string_1.Length - 6);
			return true;
			IL_00E7:
			prefix = null;
			return false;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00096BAC File Offset: 0x00094DAC
		private bool method_21(List<IXmlNode> list_0)
		{
			using (List<IXmlNode>.Enumerator enumerator = list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IXmlNode xmlNode = enumerator.Current;
					if (!(xmlNode.NamespaceUri == Class15.smethod_17(124781812 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719)) && (!(xmlNode.NamespaceUri == Class15.smethod_17(1953644031 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f)) || !(xmlNode.Value == Class15.smethod_17(2128267948 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9))))
					{
						return true;
					}
				}
				return false;
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00096C64 File Offset: 0x00094E64
		public override bool CanConvert(Type valueType)
		{
			for (;;)
			{
				int num;
				if (valueType.AssignableToTypeName(Class15.smethod_17(974394923 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), false))
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						break;
					}
				}
				else
				{
					if (valueType.AssignableToTypeName(Class15.smethod_17(2021151442 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), false))
					{
						goto IL_008B;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						return false;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return false;
				case 3:
					goto IL_008B;
				}
				break;
			}
			return this.method_22(valueType);
			IL_008B:
			return this.method_23(valueType);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00006F63 File Offset: 0x00005163
		private bool method_22(Type type_0)
		{
			return typeof(XObject).IsAssignableFrom(type_0);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00006F75 File Offset: 0x00005175
		private bool method_23(Type type_0)
		{
			return typeof(XmlNode).IsAssignableFrom(type_0);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00096D04 File Offset: 0x00094F04
		public XmlNodeConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00096D38 File Offset: 0x00094F38
		static XmlNodeConverter()
		{
			for (;;)
			{
				for (;;)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
					{
						goto IL_0003;
					}
					IL_001E:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						continue;
					}
					IL_0003:
					XmlNodeConverter.EmptyChildNodes = new List<IXmlNode>();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						goto IL_001E;
					}
					return;
				}
			}
		}

		// Token: 0x04000831 RID: 2097
		internal static readonly List<IXmlNode> EmptyChildNodes;

		// Token: 0x04000832 RID: 2098
		[CompilerGenerated]
		[Nullable(2)]
		private string string_0;

		// Token: 0x04000833 RID: 2099
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000834 RID: 2100
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000835 RID: 2101
		[CompilerGenerated]
		private bool bool_2;
	}
}
