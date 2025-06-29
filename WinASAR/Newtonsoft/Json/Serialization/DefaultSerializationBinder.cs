using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F3 RID: 243
	[Nullable(0)]
	[NullableContext(1)]
	public class DefaultSerializationBinder : SerializationBinder, GInterface2
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x000576BC File Offset: 0x000558BC
		public DefaultSerializationBinder()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
			{
				goto IL_0042;
			}
			IL_001A:
			this.threadSafeStore_0 = new ThreadSafeStore<StructMultiKey<string, string>, Type>(new Func<StructMultiKey<string, string>, Type>(this.method_0));
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
			{
				return;
			}
			IL_0042:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				break;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0005771C File Offset: 0x0005591C
		private Type method_0([Nullable(new byte[] { 0, 2, 1 })] StructMultiKey<string, string> typeNameKey)
		{
			string value = typeNameKey.Value1;
			string value2 = typeNameKey.Value2;
			if (value == null)
			{
				return Type.GetType(value2);
			}
			Assembly assembly = Assembly.LoadWithPartialName(value);
			if (assembly == null)
			{
				foreach (Assembly assembly2 in AppDomain.CurrentDomain.GetAssemblies())
				{
					if (assembly2.FullName == value || assembly2.GetName().Name == value)
					{
						assembly = assembly2;
						break;
					}
				}
			}
			if (assembly == null)
			{
				throw new JsonSerializationException(Class15.smethod_17(2048543131 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18).FormatWith(CultureInfo.InvariantCulture, value));
			}
			Type type = assembly.GetType(value2);
			if (type == null)
			{
				if (StringUtils.IndexOf(value2, '`') >= 0)
				{
					try
					{
						type = this.method_1(value2, assembly);
					}
					catch (Exception ex)
					{
						throw new JsonSerializationException(Class15.smethod_17(635816225 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2).FormatWith(CultureInfo.InvariantCulture, value2, assembly.FullName), ex);
					}
				}
				if (type == null)
				{
					throw new JsonSerializationException(Class15.smethod_17(1788620780 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).FormatWith(CultureInfo.InvariantCulture, value2, assembly.FullName));
				}
			}
			return type;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00057870 File Offset: 0x00055A70
		[return: Nullable(2)]
		private Type method_1(string string_0, Assembly assembly_0)
		{
			Type type;
			List<Type> list;
			Type type2;
			for (;;)
			{
				IL_01E9:
				type = null;
				for (;;)
				{
					IL_01C5:
					int num = StringUtils.IndexOf(string_0, '[');
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_0122;
					}
					for (;;)
					{
						IL_013E:
						int num3;
						switch (num2)
						{
						case 1:
						case 13:
						case 30:
							goto IL_0090;
						case 2:
							goto IL_0080;
						case 3:
							goto IL_00FB;
						case 4:
							goto IL_01C5;
						case 5:
							goto IL_01E9;
						case 6:
						case 27:
							goto IL_008A;
						case 7:
						case 22:
							goto IL_0006;
						case 8:
							goto IL_00A5;
						case 9:
							goto IL_00C6;
						case 10:
							goto IL_01F4;
						case 11:
						case 26:
							return type;
						case 12:
							num3 = 0;
							goto IL_0106;
						case 14:
							goto IL_0051;
						case 15:
						case 19:
							goto IL_0024;
						case 16:
							goto IL_0106;
						case 17:
							goto IL_00F1;
						case 18:
							goto IL_002E;
						case 20:
							goto IL_005B;
						case 21:
							goto IL_00E4;
						case 23:
							goto IL_0084;
						case 24:
							goto IL_009B;
						case 25:
							goto IL_0034;
						case 28:
							goto IL_006F;
						case 29:
							goto IL_0057;
						}
						break;
						IL_0006:
						int num4;
						int num5;
						if (num4 >= num5)
						{
							goto IL_01F4;
						}
						num2 = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
						{
							goto IL_0024;
						}
						continue;
						IL_0090:
						num4++;
						goto IL_0006;
						IL_0034:
						char c;
						if (c == ']')
						{
							goto IL_0051;
						}
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
						{
							goto IL_0090;
						}
						continue;
						IL_002E:
						if (c != '[')
						{
							goto IL_0034;
						}
						goto IL_0080;
						IL_0024:
						c = string_0[num4];
						goto IL_002E;
						IL_0106:
						int num6 = 0;
						num2 = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto IL_00F1;
						}
						continue;
						IL_00FB:
						num4 = num + 1;
						goto IL_0006;
						IL_00F1:
						num5 = string_0.Length - 1;
						goto IL_00FB;
						IL_0057:
						if (num3 == 0)
						{
							goto IL_005B;
						}
						goto IL_0090;
						IL_0051:
						num3--;
						goto IL_0057;
						IL_006F:
						StructMultiKey<string, string> structMultiKey;
						list.Add(this.method_2(structMultiKey));
						goto IL_0090;
						IL_005B:
						structMultiKey = ReflectionUtils.SplitFullyQualifiedTypeName(string_0.Substring(num6, num4 - num6));
						goto IL_006F;
						IL_008A:
						num3++;
						goto IL_0090;
						IL_0084:
						num6 = num4 + 1;
						goto IL_008A;
						IL_0080:
						if (num3 == 0)
						{
							goto IL_0084;
						}
						goto IL_008A;
					}
					goto IL_0122;
					IL_00A5:
					if (type2 != null)
					{
						goto IL_00C6;
					}
					num2 = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto Block_5;
					}
					goto IL_013E;
					IL_009B:
					string text;
					type2 = assembly_0.GetType(text);
					goto IL_00A5;
					IL_00E4:
					text = string_0.Substring(0, num);
					goto IL_009B;
					IL_00C6:
					list = new List<Type>();
					num2 = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
					{
						goto Block_6;
					}
					goto IL_013E;
					IL_0122:
					if (num < 0)
					{
						return type;
					}
					num2 = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto IL_00E4;
					}
					goto IL_013E;
				}
			}
			Block_5:
			Block_6:
			return type;
			IL_01F4:
			type = type2.MakeGenericType(list.ToArray());
			return type;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000049EB File Offset: 0x00002BEB
		private Type method_2([Nullable(new byte[] { 0, 2, 1 })] StructMultiKey<string, string> typeNameKey)
		{
			return this.threadSafeStore_0.Get(typeNameKey);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000049F9 File Offset: 0x00002BF9
		public override Type BindToType([Nullable(2)] string assemblyName, string typeName)
		{
			return this.method_2(new StructMultiKey<string, string>(assemblyName, typeName));
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00057A84 File Offset: 0x00055C84
		[NullableContext(2)]
		public override void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName)
		{
			for (;;)
			{
				assemblyName = serializedType.Assembly.FullName;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					IL_0003:
					typeName = serializedType.FullName;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_001C;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00057AE4 File Offset: 0x00055CE4
		static DefaultSerializationBinder()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_0021;
				}
				IL_0036:
				switch (num)
				{
				case 0:
					goto IL_0021;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					return;
				default:
					goto IL_0021;
				}
				IL_0003:
				DefaultSerializationBinder.Instance = new DefaultSerializationBinder();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					break;
				}
				goto IL_0036;
				IL_0021:
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_0003;
				}
				goto IL_0036;
			}
		}

		// Token: 0x040004E6 RID: 1254
		internal static readonly DefaultSerializationBinder Instance;

		// Token: 0x040004E7 RID: 1255
		[Nullable(new byte[] { 1, 0, 2, 1, 1 })]
		private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> threadSafeStore_0;
	}
}
