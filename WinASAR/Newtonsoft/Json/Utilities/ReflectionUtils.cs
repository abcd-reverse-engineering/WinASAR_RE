using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000D2 RID: 210
	[Nullable(0)]
	[NullableContext(1)]
	internal static class ReflectionUtils
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x0004F07C File Offset: 0x0004D27C
		static ReflectionUtils()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
				{
					goto IL_0021;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				ReflectionUtils.EmptyTypes = Type.EmptyTypes;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					break;
				}
				goto IL_0024;
				IL_0021:
				goto IL_0003;
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0004F0DC File Offset: 0x0004D2DC
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(propertyInfo, Class15.smethod_17(538827109 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_002D;
				}
				IL_0038:
				switch (num)
				{
				case 1:
					IL_002D:
					methodInfo = propertyInfo.GetGetMethod(true);
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0010;
				case 4:
					goto IL_00AB;
				case 5:
					goto IL_00A1;
				case 6:
					return true;
				case 7:
					return true;
				case 8:
					goto IL_0003;
				}
				break;
				IL_0010:
				if (methodInfo.IsVirtual)
				{
					return true;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					break;
				}
				goto IL_0038;
				IL_0003:
				if (methodInfo != null)
				{
					goto IL_0010;
				}
				break;
			}
			methodInfo = propertyInfo.GetSetMethod(true);
			IL_00A1:
			if (!(methodInfo != null))
			{
				return false;
			}
			IL_00AB:
			if (!methodInfo.IsVirtual)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		[return: Nullable(2)]
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			MethodInfo getMethod;
			MethodInfo setMethod;
			for (;;)
			{
				IL_006C:
				ValidationUtils.ArgumentNotNull(propertyInfo, Class15.smethod_17(2128248722 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
				for (;;)
				{
					IL_0061:
					getMethod = propertyInfo.GetGetMethod(true);
					IL_0053:
					while (!(getMethod != null))
					{
						int num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
						{
							goto IL_0061;
						}
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_008A;
							case 2:
								goto IL_0061;
							case 3:
								goto IL_006C;
							case 4:
								goto IL_0053;
							case 5:
								setMethod = propertyInfo.GetSetMethod(true);
								if (setMethod != null)
								{
									goto IL_008C;
								}
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
								{
									continue;
								}
								goto IL_0089;
							}
							goto Block_3;
						}
					}
					goto IL_0092;
				}
			}
			Block_3:
			goto IL_0092;
			IL_0089:
			IL_008A:
			return null;
			IL_008C:
			return setMethod.GetBaseDefinition();
			IL_0092:
			return getMethod.GetBaseDefinition();
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0004F248 File Offset: 0x0004D448
		public static bool IsPublic(PropertyInfo property)
		{
			for (;;)
			{
				IL_0095:
				MethodInfo getMethod = property.GetGetMethod();
				for (;;)
				{
					IL_0088:
					if (getMethod != null)
					{
						goto IL_007C;
					}
					for (;;)
					{
						IL_005F:
						MethodInfo setMethod = property.GetSetMethod();
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
						{
							goto IL_0026;
						}
						IL_0033:
						switch (num)
						{
						case 0:
							goto IL_0026;
						case 1:
							goto IL_007C;
						case 2:
							goto IL_0088;
						case 3:
							goto IL_0095;
						case 4:
							break;
						case 5:
							return false;
						case 6:
							return true;
						case 7:
							return true;
						case 8:
							continue;
						default:
							goto IL_0026;
						}
						IL_0006:
						if (!setMethod.IsPublic)
						{
							return false;
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
						{
							break;
						}
						goto IL_0033;
						IL_0026:
						if (!(setMethod != null))
						{
							goto Block_3;
						}
						goto IL_0006;
					}
					IL_007C:
					if (getMethod.IsPublic)
					{
						goto Block_6;
					}
					goto IL_005F;
				}
			}
			Block_3:
			return false;
			Block_6:
			return true;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0004F2FC File Offset: 0x0004D4FC
		[NullableContext(2)]
		public static Type GetObjectType(object v)
		{
			while (v != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0036;
					}
				}
				return v.GetType();
			}
			IL_0036:
			return null;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0004F340 File Offset: 0x0004D540
		public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, [Nullable(2)] GInterface2 binder)
		{
			string text;
			for (;;)
			{
				IL_003D:
				text = ReflectionUtils.smethod_0(t, binder);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (assemblyFormat != TypeNameAssemblyFormatHandling.Simple)
						{
							goto IL_0003;
						}
						goto IL_005A;
					case 2:
						goto IL_003D;
					case 3:
						goto IL_005A;
					case 4:
						goto IL_0003;
					}
					goto Block_4;
					IL_0003:
					if (assemblyFormat == TypeNameAssemblyFormatHandling.Full)
					{
						return text;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto Block_2;
					}
				}
			}
			Block_2:
			Block_4:
			goto IL_0063;
			IL_005A:
			return ReflectionUtils.smethod_1(text);
			IL_0063:
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0004F3B8 File Offset: 0x0004D5B8
		private static string smethod_0(Type type_0, [Nullable(2)] GInterface2 binder)
		{
			while (binder != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					goto IL_0015;
				}
				IL_0031:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_004C;
				}
				IL_0015:
				string text;
				string text2;
				binder.BindToName(type_0, out text, out text2);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_0031;
				}
				IL_004C:
				return text2 + ((text != null) ? (Class15.smethod_17(1042106623 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad) + text) : "");
			}
			return type_0.AssemblyQualifiedName;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0004F448 File Offset: 0x0004D648
		private static string smethod_1(string string_0)
		{
			StringBuilder stringBuilder;
			for (;;)
			{
				IL_0210:
				stringBuilder = new StringBuilder();
				for (;;)
				{
					bool flag = false;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						goto IL_013A;
					}
					IL_0154:
					bool flag2;
					bool flag3;
					switch (num)
					{
					case 0:
						goto IL_0041;
					case 1:
						IL_013A:
						flag2 = false;
						num = 36;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
						{
							goto IL_00A5;
						}
						goto IL_0154;
					case 2:
						goto IL_0110;
					case 3:
						goto IL_0113;
					case 4:
						goto IL_00BD;
					case 5:
						goto IL_0084;
					case 6:
						goto IL_00E8;
					case 7:
						goto IL_0023;
					case 8:
						goto IL_00E4;
					case 9:
						goto IL_00D8;
					case 10:
						break;
					case 11:
						goto IL_0047;
					case 12:
						goto IL_010D;
					case 13:
					case 16:
					case 21:
					case 27:
					case 32:
					case 34:
						goto IL_012F;
					case 14:
						goto IL_0116;
					case 15:
					case 35:
						goto IL_0065;
					case 17:
						continue;
					case 18:
						goto IL_0210;
					case 19:
						goto IL_0068;
					case 20:
						goto IL_00D5;
					case 22:
						goto IL_00A5;
					case 23:
					case 26:
						goto IL_000C;
					case 24:
						goto IL_0019;
					case 25:
						goto IL_00F4;
					case 28:
						goto IL_0125;
					case 29:
					case 30:
						goto IL_00F8;
					case 31:
						goto IL_0219;
					case 33:
						goto IL_0122;
					case 36:
						flag3 = false;
						break;
					default:
						goto IL_0041;
					}
					int num2 = 0;
					goto IL_000C;
					IL_0023:
					char c;
					if (c == ',')
					{
						goto IL_00E4;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_0041;
					}
					goto IL_0154;
					IL_0019:
					c = string_0[num2];
					goto IL_0023;
					IL_000C:
					if (num2 < string_0.Length)
					{
						goto IL_0019;
					}
					goto IL_0219;
					IL_0047:
					if (c == ']')
					{
						goto IL_010D;
					}
					num = 35;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
					{
						goto IL_0065;
					}
					goto IL_0154;
					IL_0041:
					if (c != '[')
					{
						goto IL_0047;
					}
					goto IL_00A5;
					IL_0068:
					if (flag2)
					{
						goto IL_012F;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_0084;
					}
					goto IL_0154;
					IL_0065:
					flag3 = false;
					goto IL_0068;
					IL_0084:
					stringBuilder.Append(c);
					num = 32;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
					{
						goto IL_00E4;
					}
					goto IL_0154;
					IL_00A5:
					flag = false;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto IL_0154;
					}
					IL_00BD:
					flag2 = false;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_00D5;
					}
					goto IL_0154;
					IL_00F8:
					flag2 = true;
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
					{
						goto IL_010D;
					}
					goto IL_0154;
					IL_00F4:
					if (flag)
					{
						goto IL_00F8;
					}
					goto IL_0122;
					IL_00E4:
					if (flag3)
					{
						goto IL_00E8;
					}
					goto IL_00F4;
					IL_012F:
					num2++;
					goto IL_000C;
					IL_0125:
					stringBuilder.Append(c);
					goto IL_012F;
					IL_0122:
					flag = true;
					goto IL_0125;
					IL_0116:
					stringBuilder.Append(c);
					goto IL_012F;
					IL_0113:
					flag3 = false;
					goto IL_0116;
					IL_0110:
					flag2 = false;
					goto IL_0113;
					IL_010D:
					flag = false;
					goto IL_0110;
					IL_00E8:
					stringBuilder.Append(c);
					goto IL_012F;
					IL_00D8:
					stringBuilder.Append(c);
					goto IL_012F;
					IL_00D5:
					flag3 = true;
					goto IL_00D8;
				}
			}
			IL_0219:
			return stringBuilder.ToString();
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0004F678 File Offset: 0x0004D878
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(t, Class15.smethod_17(314794377 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0046;
					case 2:
						continue;
					case 3:
						goto IL_0050;
					}
					break;
				}
				goto IL_0045;
			}
			return true;
			IL_0045:
			IL_0046:
			if (!t.IsValueType())
			{
				goto IL_0050;
			}
			return true;
			IL_0050:
			return ReflectionUtils.GetDefaultConstructor(t, nonPublic) != null;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000044B4 File Offset: 0x000026B4
		[return: Nullable(2)]
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return ReflectionUtils.GetDefaultConstructor(t, false);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0004F6E4 File Offset: 0x0004D8E4
		[return: Nullable(2)]
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			BindingFlags bindingFlags;
			for (;;)
			{
				IL_004B:
				bindingFlags = BindingFlags.Instance | BindingFlags.Public;
				while (nonPublic)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
					{
						goto IL_0015;
					}
					IL_002D:
					switch (num)
					{
					case 1:
						goto IL_0052;
					case 2:
						continue;
					case 3:
						goto IL_004B;
					}
					IL_0015:
					bindingFlags |= BindingFlags.NonPublic;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
					{
						goto IL_002D;
					}
					break;
				}
				break;
			}
			IL_0052:
			return t.GetConstructors(bindingFlags).SingleOrDefault(new Func<ConstructorInfo, bool>(ReflectionUtils.<>c.fgXxbudAr0.method_0));
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0004F770 File Offset: 0x0004D970
		public static bool IsNullable(Type t)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(t, Class15.smethod_17(2060584052 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0062;
				}
				IL_0003:
				if (!t.IsValueType())
				{
					break;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_001C;
				}
			}
			return true;
			IL_0062:
			return ReflectionUtils.IsNullableType(t);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0004F7E8 File Offset: 0x0004D9E8
		public static bool IsNullableType(Type t)
		{
			for (;;)
			{
				IL_0030:
				ValidationUtils.ArgumentNotNull(t, Class15.smethod_17(1471369247 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (!t.IsGenericType())
						{
							return false;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0030;
					}
					goto Block_2;
				}
			}
			Block_2:
			return t.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0004F86C File Offset: 0x0004DA6C
		public static Type EnsureNotNullableType(Type t)
		{
			while (ReflectionUtils.IsNullableType(t))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return t;
					}
				}
				return Nullable.GetUnderlyingType(t);
			}
			return t;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0004F8B8 File Offset: 0x0004DAB8
		public static Type EnsureNotByRefType(Type t)
		{
			while (t.IsByRef)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					goto IL_0034;
				}
				IL_0029:
				while (!t.HasElementType)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_0034;
					}
				}
				return t.GetElementType();
				IL_0034:
				switch (num)
				{
				case 0:
					goto IL_0029;
				case 1:
					break;
				case 2:
					return t;
				default:
					goto IL_0029;
				}
			}
			return t;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0004F920 File Offset: 0x0004DB20
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			while (!type.IsGenericType())
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return false;
			}
			return type.GetGenericTypeDefinition() == genericInterfaceDefinition;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0004F96C File Offset: 0x0004DB6C
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			Type type2;
			return ReflectionUtils.ImplementsGenericDefinition(type, genericInterfaceDefinition, out type2);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0004F984 File Offset: 0x0004DB84
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, [Nullable(2)] [NotNullWhen(true)] out Type implementingType)
		{
			Type type2;
			for (;;)
			{
				IL_019B:
				ValidationUtils.ArgumentNotNull(type, Class15.smethod_17(676715838 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
				for (;;)
				{
					IL_0169:
					ValidationUtils.ArgumentNotNull(genericInterfaceDefinition, Class15.smethod_17(314794375 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
					int num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
					{
						for (;;)
						{
							Type genericTypeDefinition;
							switch (num)
							{
							case 0:
							case 21:
								goto IL_0060;
							case 1:
							case 3:
								goto IL_0045;
							case 2:
								goto IL_007A;
							case 4:
								goto IL_0042;
							case 5:
								goto IL_0050;
							case 6:
								goto IL_0169;
							case 7:
								goto IL_019B;
							case 8:
								return false;
							case 9:
								goto IL_002D;
							case 10:
								goto IL_01BB;
							case 11:
								return true;
							case 12:
							case 25:
								goto IL_01CB;
							case 13:
								if (!genericInterfaceDefinition.IsInterface())
								{
									goto Block_10;
								}
								goto IL_009A;
							case 14:
								if (genericInterfaceDefinition == genericTypeDefinition)
								{
									goto IL_01C5;
								}
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
								{
									goto IL_0060;
								}
								continue;
							case 15:
								goto IL_0025;
							case 16:
								return true;
							case 17:
							case 20:
								goto IL_003A;
							case 18:
								goto IL_009A;
							case 19:
								goto IL_0057;
							case 22:
								break;
							case 23:
								goto IL_01C0;
							case 24:
								goto IL_01C5;
							default:
								goto IL_0060;
							}
							IL_0006:
							if (type.IsGenericType())
							{
								goto IL_0025;
							}
							num = 17;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
							{
								goto IL_007A;
							}
							continue;
							IL_0060:
							int num2;
							num2++;
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
							{
								goto IL_0045;
							}
							continue;
							IL_0057:
							if (!type2.IsGenericType())
							{
								goto IL_0060;
							}
							goto IL_007A;
							IL_0050:
							Type[] interfaces;
							type2 = interfaces[num2];
							goto IL_0057;
							IL_0045:
							if (num2 < interfaces.Length)
							{
								goto IL_0050;
							}
							goto IL_01C0;
							IL_0042:
							num2 = 0;
							goto IL_0045;
							IL_003A:
							interfaces = type.GetInterfaces();
							goto IL_0042;
							IL_009A:
							if (!genericInterfaceDefinition.IsGenericTypeDefinition())
							{
								goto IL_01CB;
							}
							if (!type.IsInterface())
							{
								goto IL_003A;
							}
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
							{
								goto IL_0006;
							}
							continue;
							IL_002D:
							Type genericTypeDefinition2;
							if (!(genericInterfaceDefinition == genericTypeDefinition2))
							{
								goto IL_003A;
							}
							goto IL_01BB;
							IL_0025:
							genericTypeDefinition2 = type.GetGenericTypeDefinition();
							goto IL_002D;
							IL_007A:
							genericTypeDefinition = type2.GetGenericTypeDefinition();
							num = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
							{
								goto Block_4;
							}
						}
					}
				}
			}
			Block_4:
			return false;
			Block_10:
			goto IL_01CB;
			IL_01BB:
			implementingType = type;
			return true;
			IL_01C0:
			implementingType = null;
			return false;
			IL_01C5:
			implementingType = type2;
			return true;
			IL_01CB:
			throw new ArgumentNullException(Class15.smethod_17(1270989074 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112).FormatWith(CultureInfo.InvariantCulture, genericInterfaceDefinition));
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0004FB84 File Offset: 0x0004DD84
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			Type type2;
			return ReflectionUtils.InheritsGenericDefinition(type, genericClassDefinition, out type2);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0004FB9C File Offset: 0x0004DD9C
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, [Nullable(2)] out Type implementingType)
		{
			for (;;)
			{
				IL_0078:
				ValidationUtils.ArgumentNotNull(type, Class15.smethod_17(1793875380 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(genericClassDefinition, Class15.smethod_17(2008571929 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
					{
						goto IL_0022;
					}
					IL_002D:
					switch (num)
					{
					case 1:
						IL_0022:
						if (genericClassDefinition.IsClass())
						{
							goto IL_0003;
						}
						break;
					case 2:
						continue;
					case 3:
						goto IL_0078;
					case 4:
						goto IL_0003;
					}
					goto Block_4;
					IL_0003:
					if (genericClassDefinition.IsGenericTypeDefinition())
					{
						goto IL_00BC;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto Block_2;
					}
					goto IL_002D;
				}
			}
			Block_2:
			Block_4:
			throw new ArgumentNullException(Class15.smethod_17(89060174 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, genericClassDefinition));
			IL_00BC:
			return ReflectionUtils.smethod_2(type, genericClassDefinition, out implementingType);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0004FC70 File Offset: 0x0004DE70
		private static bool smethod_2(Type type_0, Type type_1, [Nullable(2)] out Type implementingType)
		{
			Type type;
			for (;;)
			{
				type = type_0;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto IL_003C;
				}
				IL_0047:
				switch (num)
				{
				case 0:
				case 7:
					goto IL_003C;
				case 1:
				case 4:
					break;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				case 5:
					return true;
				case 6:
					goto IL_002D;
				case 8:
					goto IL_0092;
				case 9:
					return false;
				case 10:
					goto IL_0097;
				default:
					goto IL_003C;
				}
				IL_0010:
				if (type.IsGenericType())
				{
					goto IL_002D;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
				{
					goto IL_003C;
				}
				goto IL_0047;
				IL_0003:
				if (type != null)
				{
					goto IL_0010;
				}
				break;
				IL_003C:
				type = type.BaseType();
				goto IL_0003;
				IL_002D:
				if (!(type_1 == type.GetGenericTypeDefinition()))
				{
					goto IL_003C;
				}
				goto IL_0097;
			}
			IL_0092:
			implementingType = null;
			return false;
			IL_0097:
			implementingType = type;
			return true;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0004FD1C File Offset: 0x0004DF1C
		[return: Nullable(2)]
		public static Type GetCollectionItemType(Type type)
		{
			Type type2;
			for (;;)
			{
				IL_008D:
				ValidationUtils.ArgumentNotNull(type, Class15.smethod_17(1176439806 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_00BA;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_00BA;
					case 2:
						goto IL_00BC;
					case 3:
						goto IL_00D0;
					case 4:
						goto IL_011C;
					case 5:
						if (!type.IsArray)
						{
							goto IL_0006;
						}
						goto IL_00BC;
					case 6:
						goto IL_008D;
					case 7:
						goto IL_0006;
					}
					goto Block_6;
					IL_0006:
					if (ReflectionUtils.ImplementsGenericDefinition(type, typeof(IEnumerable<>), out type2))
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
						{
							goto Block_2;
						}
					}
					else
					{
						if (!typeof(IEnumerable).IsAssignableFrom(type))
						{
							goto IL_00F6;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
						{
							goto Block_4;
						}
					}
				}
			}
			Block_2:
			Block_4:
			Block_6:
			goto IL_00C7;
			IL_00BA:
			return null;
			IL_00BC:
			return type.GetElementType();
			IL_00C7:
			if (!type2.IsGenericTypeDefinition())
			{
				goto IL_011C;
			}
			IL_00D0:
			throw new Exception(Class15.smethod_17(299927007 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, type));
			IL_00F6:
			throw new Exception(Class15.smethod_17(314794671 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927).FormatWith(CultureInfo.InvariantCulture, type));
			IL_011C:
			return type2.GetGenericArguments()[0];
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0004FE50 File Offset: 0x0004E050
		[NullableContext(2)]
		public static void GetDictionaryKeyValueTypes([Nullable(1)] Type dictionaryType, out Type keyType, out Type valueType)
		{
			Type type;
			for (;;)
			{
				IL_00D1:
				ValidationUtils.ArgumentNotNull(dictionaryType, Class15.smethod_17(1953676059 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0082;
				}
				for (;;)
				{
					IL_0099:
					switch (num)
					{
					case 1:
						goto IL_00D1;
					case 2:
						return;
					case 3:
						return;
					case 4:
						goto IL_0100;
					case 5:
						goto IL_004E;
					case 6:
						if (typeof(IDictionary).IsAssignableFrom(dictionaryType))
						{
							goto IL_0020;
						}
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
						{
							goto Block_3;
						}
						continue;
					case 7:
						goto IL_0020;
					case 8:
						goto IL_0006;
					case 9:
						goto IL_013C;
					case 10:
						goto IL_0136;
					case 11:
						goto IL_0144;
					}
					break;
					IL_0006:
					valueType = null;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto Block_1;
					}
					continue;
					IL_0020:
					keyType = null;
					goto IL_0006;
				}
				goto IL_0082;
				IL_004E:
				if (!type.IsGenericTypeDefinition())
				{
					goto IL_0126;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto IL_0099;
				}
				IL_0082:
				if (ReflectionUtils.ImplementsGenericDefinition(dictionaryType, typeof(IDictionary<, >), out type))
				{
					goto IL_004E;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_004E;
				}
				goto IL_0099;
			}
			Block_1:
			Block_3:
			return;
			IL_0100:
			throw new Exception(Class15.smethod_17(41419653 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).FormatWith(CultureInfo.InvariantCulture, dictionaryType));
			IL_0126:
			Type[] genericArguments = type.GetGenericArguments();
			IL_0136:
			keyType = genericArguments[0];
			IL_013C:
			valueType = genericArguments[1];
			return;
			IL_0144:
			throw new Exception(Class15.smethod_17(1985289296 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba).FormatWith(CultureInfo.InvariantCulture, dictionaryType));
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0004FFC8 File Offset: 0x0004E1C8
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			MemberTypes memberTypes;
			for (;;)
			{
				IL_007B:
				ValidationUtils.ArgumentNotNull(member, Class15.smethod_17(1678104146 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_003C;
				}
				for (;;)
				{
					IL_0047:
					switch (num)
					{
					case 1:
					case 9:
						goto IL_00CB;
					case 2:
						goto IL_00AB;
					case 3:
						memberTypes = member.MemberType();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
						{
							continue;
						}
						break;
					case 4:
						goto IL_007B;
					case 5:
						goto IL_00D0;
					case 6:
						goto IL_00B3;
					case 7:
						goto IL_0003;
					case 8:
					case 10:
						goto IL_00E5;
					}
					break;
				}
				goto IL_003C;
				IL_0003:
				if (memberTypes == MemberTypes.Event)
				{
					goto IL_00BF;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					break;
				}
				goto IL_0047;
				IL_003C:
				if (memberTypes > MemberTypes.Field)
				{
					goto Block_3;
				}
				goto IL_0003;
			}
			goto IL_00AB;
			Block_3:
			goto IL_00CB;
			IL_00AB:
			if (memberTypes != MemberTypes.Field)
			{
				goto IL_00E5;
			}
			IL_00B3:
			return ((FieldInfo)member).FieldType;
			IL_00BF:
			return ((EventInfo)member).EventHandlerType;
			IL_00CB:
			if (memberTypes == MemberTypes.Method)
			{
				return ((MethodInfo)member).ReturnType;
			}
			IL_00D0:
			if (memberTypes == MemberTypes.Property)
			{
				return ((PropertyInfo)member).PropertyType;
			}
			IL_00E5:
			throw new ArgumentException(Class15.smethod_17(676723508 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b), Class15.smethod_17(1678104146 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000500F8 File Offset: 0x0004E2F8
		public static bool IsByRefLikeType(Type type)
		{
			while (type.IsValueType())
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					goto IL_0089;
				}
				IL_00A7:
				Attribute[] attributes;
				switch (num)
				{
				case 0:
					return true;
				case 1:
					IL_0089:
					attributes = ReflectionUtils.GetAttributes(type, null, false);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
					{
						goto IL_0084;
					}
					goto IL_00A7;
				case 2:
					continue;
				case 3:
					goto IL_0084;
				case 4:
				case 9:
					goto IL_001D;
				case 5:
					return false;
				case 6:
				case 8:
					break;
				case 7:
					return false;
				default:
					return true;
				}
				IL_0065:
				int num2;
				if (num2 >= attributes.Length)
				{
					return false;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_00A7;
				}
				IL_001D:
				if (!string.Equals(attributes[num2].GetType().FullName, Class15.smethod_17(1760318637 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), StringComparison.Ordinal))
				{
					num2++;
					goto IL_0065;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					return true;
				}
				goto IL_00A7;
				IL_0084:
				num2 = 0;
				goto IL_0065;
			}
			return false;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000501F0 File Offset: 0x0004E3F0
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(property, Class15.smethod_17(1829633759 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
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
			return property.GetIndexParameters().Length != 0;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00050248 File Offset: 0x0004E448
		[return: Nullable(2)]
		public static object GetMemberValue(MemberInfo member, object target)
		{
			for (;;)
			{
				IL_00A9:
				ValidationUtils.ArgumentNotNull(member, Class15.smethod_17(1471369925 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(target, Class15.smethod_17(1387477752 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						goto IL_0006;
					}
					IL_004B:
					MemberTypes memberTypes;
					switch (num)
					{
					case 1:
						goto IL_00C6;
					case 2:
						goto IL_0020;
					case 3:
						if (memberTypes != MemberTypes.Field)
						{
							goto IL_0020;
						}
						goto IL_00C6;
					case 4:
						IL_0006:
						memberTypes = member.MemberType();
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
						{
							goto IL_0020;
						}
						goto IL_004B;
					case 5:
						continue;
					case 6:
						goto IL_00A9;
					case 7:
					case 8:
						goto IL_0152;
					}
					goto Block_4;
					IL_0020:
					if (memberTypes != MemberTypes.Property)
					{
						goto Block_1;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto Block_2;
					}
					goto IL_004B;
				}
			}
			Block_1:
			goto IL_0152;
			Block_2:
			Block_4:
			goto IL_00D4;
			IL_00C6:
			return ((FieldInfo)member).GetValue(target);
			IL_00D4:
			try
			{
				object value = ((PropertyInfo)member).GetValue(target, null);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					switch (num2)
					{
					}
				}
				return value;
			}
			catch (TargetParameterCountException ex)
			{
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
				{
					switch (num3)
					{
					}
				}
				throw new ArgumentException(Class15.smethod_17(1424565730 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, member.Name), ex);
			}
			IL_0152:
			throw new ArgumentException(Class15.smethod_17(1471370573 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e).FormatWith(CultureInfo.InvariantCulture, member.Name), Class15.smethod_17(2057003765 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000503FC File Offset: 0x0004E5FC
		public static void SetMemberValue(MemberInfo member, object target, [Nullable(2)] object value)
		{
			for (;;)
			{
				IL_00B3:
				ValidationUtils.ArgumentNotNull(member, Class15.smethod_17(299926563 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
				for (;;)
				{
					IL_0096:
					ValidationUtils.ArgumentNotNull(target, Class15.smethod_17(649962478 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
					for (;;)
					{
						MemberTypes memberTypes = member.MemberType();
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							goto IL_001E;
						}
						IL_004B:
						switch (num)
						{
						case 1:
							goto IL_001E;
						case 2:
							return;
						case 3:
							goto IL_00D0;
						case 4:
							goto IL_0096;
						case 5:
							goto IL_00B3;
						case 6:
							goto IL_0006;
						case 7:
							continue;
						case 8:
							return;
						}
						goto Block_3;
						IL_0006:
						if (memberTypes != MemberTypes.Property)
						{
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
							{
								goto IL_004B;
							}
						}
						else
						{
							((PropertyInfo)member).SetValue(target, value, null);
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
							{
								goto IL_004B;
							}
							return;
						}
						IL_001E:
						if (memberTypes != MemberTypes.Field)
						{
							goto IL_0006;
						}
						goto IL_0110;
					}
				}
			}
			Block_3:
			goto IL_0110;
			IL_00D0:
			throw new ArgumentException(Class15.smethod_17(1471370423 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e).FormatWith(CultureInfo.InvariantCulture, member.Name), Class15.smethod_17(2071424354 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808));
			IL_0110:
			((FieldInfo)member).SetValue(target, value);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0005052C File Offset: 0x0004E72C
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			PropertyInfo propertyInfo;
			FieldInfo fieldInfo;
			for (;;)
			{
				IL_00CB:
				MemberTypes memberTypes = member.MemberType();
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto Block_8;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return true;
					case 2:
						if (memberTypes != MemberTypes.Field)
						{
							goto IL_0041;
						}
						goto IL_0059;
					case 3:
						goto IL_00CB;
					case 4:
						goto IL_0059;
					case 5:
						return false;
					case 6:
						return true;
					case 7:
						goto IL_0024;
					case 8:
						return false;
					case 9:
						goto IL_0041;
					case 10:
						goto IL_00F0;
					case 11:
						goto IL_0006;
					case 12:
						return false;
					case 13:
						return true;
					case 14:
						goto IL_0103;
					}
					goto Block_7;
					IL_0006:
					if (!propertyInfo.CanRead)
					{
						return false;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						goto IL_0024;
					}
					continue;
					IL_0041:
					if (memberTypes == MemberTypes.Property)
					{
						propertyInfo = (PropertyInfo)member;
						goto IL_0006;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						goto IL_0059;
					}
					continue;
					IL_0024:
					if (nonPublic)
					{
						return true;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
					{
						goto Block_3;
					}
					continue;
					IL_0059:
					fieldInfo = (FieldInfo)member;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto Block_5;
					}
				}
			}
			Block_3:
			goto IL_00F0;
			Block_5:
			Block_7:
			Block_8:
			if (!nonPublic)
			{
				goto IL_0103;
			}
			return true;
			IL_00F0:
			return propertyInfo.GetGetMethod(nonPublic) != null;
			IL_0103:
			if (fieldInfo.IsPublic)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00050648 File Offset: 0x0004E848
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			PropertyInfo propertyInfo;
			for (;;)
			{
				IL_00B4:
				MemberTypes memberTypes = member.MemberType();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
				{
					goto IL_0059;
				}
				for (;;)
				{
					IL_0064:
					switch (num)
					{
					case 1:
						goto IL_00B4;
					case 2:
						if (nonPublic)
						{
							return true;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
						{
							goto Block_5;
						}
						continue;
					case 3:
						goto IL_00D0;
					case 4:
						return true;
					case 5:
						return false;
					case 6:
						return true;
					case 7:
						goto IL_0103;
					case 8:
						goto IL_0029;
					case 9:
						return false;
					case 10:
						return false;
					case 11:
						goto IL_0006;
					case 12:
						goto IL_00E3;
					case 13:
						return false;
					case 14:
						goto IL_00EF;
					case 15:
						goto IL_0108;
					case 16:
						return true;
					}
					break;
				}
				goto IL_0059;
				Block_5:
				continue;
				IL_0006:
				if (!propertyInfo.CanWrite)
				{
					return false;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					continue;
				}
				goto IL_0064;
				IL_0029:
				if (memberTypes != MemberTypes.Property)
				{
					break;
				}
				propertyInfo = (PropertyInfo)member;
				goto IL_0006;
				IL_0059:
				if (memberTypes != MemberTypes.Field)
				{
					goto IL_0029;
				}
				goto IL_00E3;
			}
			return false;
			IL_00D0:
			return propertyInfo.GetSetMethod(nonPublic) != null;
			IL_00E3:
			FieldInfo fieldInfo = (FieldInfo)member;
			IL_00EF:
			if (!fieldInfo.IsLiteral)
			{
				if (fieldInfo.IsInitOnly)
				{
					goto IL_0103;
				}
				goto IL_0108;
			}
			return false;
			IL_0103:
			if (canSetReadOnly)
			{
				goto IL_0108;
			}
			return false;
			IL_0108:
			if (nonPublic)
			{
				return true;
			}
			if (!fieldInfo.IsPublic)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00050770 File Offset: 0x0004E970
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			List<MemberInfo> list = new List<MemberInfo>();
			list.AddRange(ReflectionUtils.GetFields(type, bindingAttr));
			list.AddRange(ReflectionUtils.GetProperties(type, bindingAttr));
			List<MemberInfo> list2 = new List<MemberInfo>(list.Count);
			foreach (IGrouping<string, MemberInfo> grouping in list.GroupBy(new Func<MemberInfo, string>(ReflectionUtils.<>c.fgXxbudAr0.method_1)))
			{
				if (grouping.Count<MemberInfo>() == 1)
				{
					list2.Add(grouping.First<MemberInfo>());
				}
				else
				{
					List<MemberInfo> list3 = new List<MemberInfo>();
					using (IEnumerator<MemberInfo> enumerator2 = grouping.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ReflectionUtils.<>c__DisplayClass31_0 CS$<>8__locals1 = new ReflectionUtils.<>c__DisplayClass31_0();
							CS$<>8__locals1.memberInfo_0 = enumerator2.Current;
							if (list3.Count == 0)
							{
								list3.Add(CS$<>8__locals1.memberInfo_0);
							}
							else if ((!ReflectionUtils.smethod_3(CS$<>8__locals1.memberInfo_0, bindingAttr) || CS$<>8__locals1.memberInfo_0.Name == Class15.smethod_17(82295618 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909)) && !list3.Any(new Func<MemberInfo, bool>(CS$<>8__locals1.method_0)))
							{
								list3.Add(CS$<>8__locals1.memberInfo_0);
							}
						}
					}
					list2.AddRange(list3);
				}
			}
			return list2;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000508E8 File Offset: 0x0004EAE8
		private static bool smethod_3(object object_0, BindingFlags bindingFlags_0)
		{
			MemberInfo[] member;
			for (;;)
			{
				IL_0114:
				int num;
				PropertyInfo propertyInfo;
				if (object_0.MemberType() != MemberTypes.Property)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto Block_9;
					}
				}
				else
				{
					propertyInfo = (PropertyInfo)object_0;
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
					{
						break;
					}
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_0132;
					case 2:
						goto IL_00A4;
					case 3:
						return false;
					case 4:
						goto IL_0114;
					case 5:
						goto IL_003D;
					case 6:
						return false;
					case 7:
						return false;
					case 8:
						if (!propertyInfo.IsVirtual())
						{
							return false;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_00A4;
						}
						continue;
					case 9:
						goto IL_0137;
					case 10:
						return false;
					case 11:
						goto IL_0028;
					case 12:
						return false;
					}
					goto Block_8;
					IL_003D:
					Type genericTypeDefinition;
					if (genericTypeDefinition == null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
						{
							goto Block_4;
						}
						continue;
					}
					else
					{
						member = genericTypeDefinition.GetMember(propertyInfo.Name, bindingFlags_0);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
						{
							goto Block_5;
						}
						continue;
					}
					IL_0028:
					Type declaringType;
					if (declaringType.IsGenericType())
					{
						genericTypeDefinition = declaringType.GetGenericTypeDefinition();
						goto IL_003D;
					}
					return false;
					IL_00A4:
					declaringType = propertyInfo.DeclaringType;
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto IL_0028;
					}
				}
			}
			return false;
			Block_4:
			return false;
			Block_5:
			goto IL_0132;
			Block_8:
			Block_9:
			return false;
			IL_0132:
			if (member.Length == 0)
			{
				return false;
			}
			IL_0137:
			if (ReflectionUtils.GetMemberUnderlyingType(member[0]).IsGenericParameter)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000044BD File Offset: 0x000026BD
		[return: Nullable(2)]
		public static T GetAttribute<[Nullable(0)] T>(ICustomAttributeProvider attributeProvider) where T : Attribute
		{
			return ReflectionUtils.GetAttribute<T>(attributeProvider, true);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00050A44 File Offset: 0x0004EC44
		[return: Nullable(2)]
		public static T GetAttribute<[Nullable(0)] T>(ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
		{
			T[] attributes = ReflectionUtils.GetAttributes<T>(attributeProvider, inherit);
			if (attributes == null)
			{
				return default(T);
			}
			return attributes.FirstOrDefault<T>();
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00050A6C File Offset: 0x0004EC6C
		public static T[] GetAttributes<[Nullable(0)] T>(ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
		{
			Attribute[] attributes = ReflectionUtils.GetAttributes(attributeProvider, typeof(T), inherit);
			T[] array = attributes as T[];
			if (array != null)
			{
				return array;
			}
			return attributes.Cast<T>().ToArray<T>();
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00050AA4 File Offset: 0x0004ECA4
		public static Attribute[] GetAttributes(ICustomAttributeProvider attributeProvider, [Nullable(2)] Type attributeType, bool inherit)
		{
			Type type;
			Assembly assembly;
			Module module;
			ICustomAttributeProvider customAttributeProvider;
			ParameterInfo parameterInfo;
			MemberInfo memberInfo;
			for (;;)
			{
				IL_0170:
				ValidationUtils.ArgumentNotNull(attributeProvider, Class15.smethod_17(1116157279 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54));
				for (;;)
				{
					IL_016B:
					for (;;)
					{
						IL_0160:
						type = attributeProvider as Type;
						for (;;)
						{
							IL_0159:
							if (type == null)
							{
								goto IL_0122;
							}
							int num = 23;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
							{
								goto Block_7;
							}
							for (;;)
							{
								IL_00B7:
								switch (num)
								{
								case 1:
									goto IL_001F;
								case 2:
									goto IL_0078;
								case 3:
									goto IL_01D3;
								case 4:
									goto IL_01DC;
								case 5:
									goto IL_021C;
								case 6:
									goto IL_0159;
								case 7:
									goto IL_01C1;
								case 8:
									goto IL_0028;
								case 9:
									goto IL_01CA;
								case 10:
									goto IL_022E;
								case 11:
									goto IL_002F;
								case 12:
									goto IL_0093;
								case 13:
									goto IL_009A;
								case 14:
									goto IL_0160;
								case 15:
								case 23:
									goto IL_0225;
								case 16:
									goto IL_01A5;
								case 17:
									if (assembly == null)
									{
										goto IL_0078;
									}
									goto IL_01B8;
								case 18:
									goto IL_01FE;
								case 19:
									if (module == null)
									{
										num = 1;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
										{
											goto IL_001F;
										}
										continue;
									}
									else
									{
										if (!(attributeType != null))
										{
											goto IL_021C;
										}
										num = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
										{
											continue;
										}
									}
									break;
								case 20:
									goto IL_016B;
								case 21:
									goto IL_0170;
								case 22:
									goto IL_0122;
								}
								goto Block_5;
								IL_002F:
								customAttributeProvider = (ICustomAttributeProvider)attributeProvider;
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
								{
									goto Block_2;
								}
								continue;
								IL_0028:
								if (parameterInfo == null)
								{
									goto IL_002F;
								}
								goto IL_01F5;
								IL_001F:
								parameterInfo = attributeProvider as ParameterInfo;
								goto IL_0028;
								IL_0078:
								memberInfo = attributeProvider as MemberInfo;
								num = 8;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
								{
									goto IL_0093;
								}
								continue;
								IL_009A:
								module = attributeProvider as Module;
								num = 19;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
								{
									continue;
								}
								goto IL_0199;
								IL_0093:
								if (memberInfo == null)
								{
									goto IL_009A;
								}
								goto IL_019C;
							}
							IL_0122:
							assembly = attributeProvider as Assembly;
							num = 17;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
							{
								goto Block_6;
							}
							goto IL_00B7;
						}
					}
				}
			}
			Block_2:
			goto IL_01D3;
			Block_5:
			goto IL_0212;
			Block_6:
			goto IL_022E;
			Block_7:
			goto IL_021C;
			IL_0199:
			goto IL_01D3;
			IL_019C:
			if (attributeType != null)
			{
				return Attribute.GetCustomAttributes(memberInfo, attributeType, inherit);
			}
			IL_01A5:
			return Attribute.GetCustomAttributes(memberInfo, inherit);
			IL_01B8:
			if (!(attributeType != null))
			{
				goto IL_01CA;
			}
			IL_01C1:
			return Attribute.GetCustomAttributes(assembly, attributeType);
			IL_01CA:
			return Attribute.GetCustomAttributes(assembly);
			IL_01D3:
			object[] array;
			if (attributeType != null)
			{
				array = customAttributeProvider.GetCustomAttributes(attributeType, inherit);
				goto IL_01EF;
			}
			IL_01DC:
			array = customAttributeProvider.GetCustomAttributes(inherit);
			IL_01EF:
			return (Attribute[])array;
			IL_01F5:
			if (attributeType != null)
			{
				return Attribute.GetCustomAttributes(parameterInfo, attributeType, inherit);
			}
			IL_01FE:
			return Attribute.GetCustomAttributes(parameterInfo, inherit);
			IL_0212:
			return Attribute.GetCustomAttributes(module, attributeType, inherit);
			IL_021C:
			return Attribute.GetCustomAttributes(module, inherit);
			IL_0225:
			IEnumerable enumerable;
			if (attributeType != null)
			{
				enumerable = type.GetCustomAttributes(attributeType, inherit);
				goto IL_0241;
			}
			IL_022E:
			enumerable = type.GetCustomAttributes(inherit);
			IL_0241:
			return enumerable.Cast<Attribute>().ToArray<Attribute>();
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00050CFC File Offset: 0x0004EEFC
		[return: Nullable(new byte[] { 0, 2, 1 })]
		public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName)
		{
			int? num = ReflectionUtils.smethod_4(fullyQualifiedTypeName);
			string text;
			string text2;
			if (num != null)
			{
				text = fullyQualifiedTypeName.Trim(0, num.GetValueOrDefault());
				text2 = fullyQualifiedTypeName.Trim(num.GetValueOrDefault() + 1, fullyQualifiedTypeName.Length - num.GetValueOrDefault() - 1);
			}
			else
			{
				text = fullyQualifiedTypeName;
				text2 = null;
			}
			return new StructMultiKey<string, string>(text2, text);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00050D58 File Offset: 0x0004EF58
		private static int? smethod_4(string string_0)
		{
			int num = 0;
			for (int i = 0; i < string_0.Length; i++)
			{
				char c = string_0[i];
				if (c != ',')
				{
					if (c != '[')
					{
						if (c == ']')
						{
							num--;
						}
					}
					else
					{
						num++;
					}
				}
				else if (num == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		[return: Nullable(2)]
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			IL_008F:
			while (memberInfo.MemberType() == MemberTypes.Property)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_0034;
				}
				PropertyInfo propertyInfo;
				for (;;)
				{
					IL_0077:
					switch (num)
					{
					case 1:
						propertyInfo = (PropertyInfo)memberInfo;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_008F;
					case 3:
						goto IL_00A0;
					}
					break;
				}
				IL_0034:
				Type[] array = propertyInfo.GetIndexParameters().Select(new Func<ParameterInfo, Type>(ReflectionUtils.<>c.fgXxbudAr0.method_2)).ToArray<Type>();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_0077;
				}
				IL_00A0:
				return targetType.GetProperty(propertyInfo.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, propertyInfo.PropertyType, array, null);
			}
			return targetType.GetMember(memberInfo.Name, memberInfo.MemberType(), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SingleOrDefault<MemberInfo>();
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000044C6 File Offset: 0x000026C6
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			ValidationUtils.ArgumentNotNull(targetType, Class15.smethod_17(594352428 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
			List<MemberInfo> list = new List<MemberInfo>(targetType.GetFields(bindingAttr));
			ReflectionUtils.smethod_5(list, targetType, bindingAttr);
			return list.Cast<FieldInfo>();
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00050E98 File Offset: 0x0004F098
		private static void smethod_5(IList<MemberInfo> ilist_0, Type type_0, BindingFlags bindingFlags_0)
		{
			Type type = type_0;
			if ((bindingFlags_0 & BindingFlags.NonPublic) != BindingFlags.Default)
			{
				BindingFlags bindingFlags = bindingFlags_0.RemoveFlag(BindingFlags.Public);
				while ((type = type.BaseType()) != null)
				{
					IEnumerable<FieldInfo> enumerable = type.GetFields(bindingFlags).Where(new Func<FieldInfo, bool>(ReflectionUtils.<>c.fgXxbudAr0.method_3));
					ilist_0.AddRange(enumerable);
				}
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00050EFC File Offset: 0x0004F0FC
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			ValidationUtils.ArgumentNotNull(targetType, Class15.smethod_17(1570971301 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
			List<PropertyInfo> list = new List<PropertyInfo>(targetType.GetProperties(bindingAttr));
			if (targetType.IsInterface())
			{
				foreach (Type type in targetType.GetInterfaces())
				{
					list.AddRange(type.GetProperties(bindingAttr));
				}
			}
			ReflectionUtils.smethod_6(list, targetType, bindingAttr);
			for (int j = 0; j < list.Count; j++)
			{
				PropertyInfo propertyInfo = list[j];
				if (propertyInfo.DeclaringType != targetType)
				{
					PropertyInfo propertyInfo2 = (PropertyInfo)ReflectionUtils.GetMemberInfoFromType(propertyInfo.DeclaringType, propertyInfo);
					list[j] = propertyInfo2;
				}
			}
			return list;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00050FB8 File Offset: 0x0004F1B8
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			while ((bindingAttr & flag) != flag)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return bindingAttr;
			}
			return bindingAttr ^ flag;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00050FF8 File Offset: 0x0004F1F8
		private static void smethod_6(IList<PropertyInfo> ilist_0, Type type_0, BindingFlags bindingFlags_0)
		{
			Type type = type_0;
			while ((type = type.BaseType()) != null)
			{
				foreach (PropertyInfo propertyInfo in type.GetProperties(bindingFlags_0))
				{
					ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1 = new ReflectionUtils.<>c__DisplayClass44_0();
					CS$<>8__locals1.propertyInfo_0 = propertyInfo;
					if (CS$<>8__locals1.propertyInfo_0.IsVirtual())
					{
						ReflectionUtils.<>c__DisplayClass44_1 CS$<>8__locals2 = new ReflectionUtils.<>c__DisplayClass44_1();
						CS$<>8__locals2.<>c__DisplayClass44_0_0 = CS$<>8__locals1;
						ReflectionUtils.<>c__DisplayClass44_1 CS$<>8__locals3 = CS$<>8__locals2;
						MethodInfo baseDefinition = CS$<>8__locals2.<>c__DisplayClass44_0_0.propertyInfo_0.GetBaseDefinition();
						if (baseDefinition == null)
						{
							goto IL_00F4;
						}
						Type type2;
						if ((type2 = baseDefinition.DeclaringType) == null)
						{
							goto IL_00F4;
						}
						IL_0106:
						CS$<>8__locals3.type_0 = type2;
						if (ilist_0.IndexOf(new Func<PropertyInfo, bool>(CS$<>8__locals2.method_0)) == -1)
						{
							ilist_0.Add(CS$<>8__locals2.<>c__DisplayClass44_0_0.propertyInfo_0);
							goto IL_0133;
						}
						goto IL_0133;
						IL_00F4:
						type2 = CS$<>8__locals2.<>c__DisplayClass44_0_0.propertyInfo_0.DeclaringType;
						goto IL_0106;
					}
					if (!ReflectionUtils.IsPublic(CS$<>8__locals1.propertyInfo_0))
					{
						int num = ilist_0.IndexOf(new Func<PropertyInfo, bool>(CS$<>8__locals1.method_0));
						if (num == -1)
						{
							ilist_0.Add(CS$<>8__locals1.propertyInfo_0);
						}
						else if (!ReflectionUtils.IsPublic(ilist_0[num]))
						{
							ilist_0[num] = CS$<>8__locals1.propertyInfo_0;
						}
					}
					else if (ilist_0.IndexOf(new Func<PropertyInfo, bool>(CS$<>8__locals1.method_1)) == -1)
					{
						ilist_0.Add(CS$<>8__locals1.propertyInfo_0);
					}
					IL_0133:;
				}
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00051158 File Offset: 0x0004F358
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
				{
					goto IL_001F;
				}
				goto IL_003B;
				IL_0003:
				Type type_0 = methodDeclaringType;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					continue;
				}
				goto IL_003B;
				IL_001F:
				string string_0 = method;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_0003;
				}
				IL_003B:
				switch (num)
				{
				case 0:
					goto IL_001F;
				case 1:
					break;
				case 2:
					goto IL_0003;
				case 3:
					goto IL_006F;
				default:
					goto IL_001F;
				}
			}
			IL_006F:
			return currentType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Any(new Func<MethodInfo, bool>(CS$<>8__locals1.method_0));
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000511F0 File Offset: 0x0004F3F0
		[return: Nullable(2)]
		public static object GetDefaultValue(Type type)
		{
			IL_015C:
			while (type.IsValueType())
			{
				PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(type);
				DateTime dateTime;
				BigInteger bigInteger;
				for (;;)
				{
					int num;
					switch (typeCode)
					{
					case PrimitiveTypeCode.Char:
					case PrimitiveTypeCode.SByte:
					case PrimitiveTypeCode.Int16:
					case PrimitiveTypeCode.UInt16:
					case PrimitiveTypeCode.Int32:
					case PrimitiveTypeCode.Byte:
					case PrimitiveTypeCode.UInt32:
						goto IL_016A;
					case PrimitiveTypeCode.CharNullable:
					case PrimitiveTypeCode.BooleanNullable:
					case PrimitiveTypeCode.SByteNullable:
					case PrimitiveTypeCode.Int16Nullable:
					case PrimitiveTypeCode.UInt16Nullable:
					case PrimitiveTypeCode.Int32Nullable:
					case PrimitiveTypeCode.ByteNullable:
					case PrimitiveTypeCode.UInt32Nullable:
					case PrimitiveTypeCode.Int64Nullable:
					case PrimitiveTypeCode.UInt64Nullable:
					case PrimitiveTypeCode.SingleNullable:
					case PrimitiveTypeCode.DoubleNullable:
					case PrimitiveTypeCode.DateTimeNullable:
					case PrimitiveTypeCode.DateTimeOffsetNullable:
					case PrimitiveTypeCode.DecimalNullable:
						IL_008A:
						if (ReflectionUtils.IsNullable(type))
						{
							goto IL_01DE;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
						{
							goto Block_1;
						}
						break;
					case PrimitiveTypeCode.Boolean:
						goto IL_01B5;
					case PrimitiveTypeCode.Int64:
					case PrimitiveTypeCode.UInt64:
						goto IL_0171;
					case PrimitiveTypeCode.Single:
						goto IL_0180;
					case PrimitiveTypeCode.Double:
						goto IL_018B;
					case PrimitiveTypeCode.DateTime:
						dateTime = default(DateTime);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
						{
							goto Block_5;
						}
						break;
					case PrimitiveTypeCode.DateTimeOffset:
						goto IL_019D;
					case PrimitiveTypeCode.Decimal:
						goto IL_01A7;
					case PrimitiveTypeCode.Guid:
						goto IL_01E0;
					default:
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
						{
							goto IL_002A;
						}
						break;
					}
					IL_004F:
					switch (num)
					{
					case 1:
						goto IL_01D4;
					case 2:
						goto IL_01BC;
					case 3:
						goto IL_01C4;
					case 4:
						goto IL_01CB;
					case 5:
						IL_002A:
						if (typeCode != PrimitiveTypeCode.BigInteger)
						{
							goto IL_008A;
						}
						bigInteger = default(BigInteger);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
						{
							goto IL_004F;
						}
						goto IL_01D3;
					case 6:
						goto IL_01DE;
					case 7:
						goto IL_01E8;
					case 8:
						continue;
					case 9:
						goto IL_008A;
					case 10:
						goto IL_01DC;
					case 11:
						goto IL_015C;
					}
					goto Block_3;
				}
				Block_1:
				goto IL_01C4;
				Block_3:
				Block_5:
				goto IL_01B5;
				IL_016A:
				return 0;
				IL_0171:
				return 0L;
				IL_0180:
				return 0f;
				IL_018B:
				return 0.0;
				IL_019D:
				DateTimeOffset dateTimeOffset = default(DateTimeOffset);
				goto IL_01CB;
				IL_01A7:
				return 0m;
				IL_01B5:
				return false;
				IL_01BC:
				return dateTime;
				IL_01C4:
				return Activator.CreateInstance(type);
				IL_01CB:
				return dateTimeOffset;
				IL_01D3:
				IL_01D4:
				return bigInteger;
				IL_01DC:
				return null;
				IL_01DE:
				return null;
				IL_01E0:
				Guid guid = default(Guid);
				IL_01E8:
				return guid;
			}
			goto IL_01DC;
		}

		// Token: 0x04000482 RID: 1154
		public static readonly Type[] EmptyTypes;
	}
}
