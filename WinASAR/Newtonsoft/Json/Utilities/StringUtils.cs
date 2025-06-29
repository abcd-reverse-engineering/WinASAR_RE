using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000DB RID: 219
	[Nullable(0)]
	[NullableContext(1)]
	internal static class StringUtils
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x000045FD File Offset: 0x000027FD
		[NullableContext(2)]
		public static bool IsNullOrEmpty([NotNullWhen(false)] string value)
		{
			return string.IsNullOrEmpty(value);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00004605 File Offset: 0x00002805
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0)
		{
			return format.smethod_0(provider, new object[] { arg0 });
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00004618 File Offset: 0x00002818
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1)
		{
			return format.smethod_0(provider, new object[] { arg0, arg1 });
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0000462F File Offset: 0x0000282F
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1, [Nullable(2)] object arg2)
		{
			return format.smethod_0(provider, new object[] { arg0, arg1, arg2 });
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0000464B File Offset: 0x0000284B
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string FormatWith([Nullable(1)] this string format, [Nullable(1)] IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return format.smethod_0(provider, new object[] { arg0, arg1, arg2, arg3 });
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00051B7C File Offset: 0x0004FD7C
		private static string smethod_0(this string string_0, IFormatProvider iformatProvider_0, [Nullable(new byte[] { 1, 2 })] params object[] args)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(string_0, Class15.smethod_17(2048547967 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
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
			return string.Format(iformatProvider_0, string_0, args);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00051BD0 File Offset: 0x0004FDD0
		public static bool IsWhiteSpace(string s)
		{
			for (;;)
			{
				int num;
				int num2;
				if (s == null)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_007C;
					}
				}
				else
				{
					if (s.Length != 0)
					{
						num2 = 0;
						goto IL_0082;
					}
					return false;
				}
				IL_004B:
				switch (num)
				{
				case 0:
					goto IL_007C;
				case 1:
					return false;
				case 2:
					goto IL_00AC;
				case 3:
					continue;
				case 4:
				case 9:
					break;
				case 5:
					return false;
				case 6:
				case 8:
					goto IL_0082;
				case 7:
					return true;
				default:
					goto IL_007C;
				}
				IL_0028:
				if (!char.IsWhiteSpace(s[num2]))
				{
					return false;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					goto IL_004B;
				}
				goto IL_007C;
				IL_0082:
				if (num2 >= s.Length)
				{
					return true;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_0028;
				}
				goto IL_004B;
				IL_007C:
				num2++;
				goto IL_0082;
			}
			IL_00AC:
			throw new ArgumentNullException(Class15.smethod_17(974425241 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000466C File Offset: 0x0000286C
		public static StringWriter CreateStringWriter(int capacity)
		{
			return new StringWriter(new StringBuilder(capacity), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00051CAC File Offset: 0x0004FEAC
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
			for (;;)
			{
				IL_00A8:
				buffer[0] = '\\';
				for (;;)
				{
					buffer[1] = 'u';
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_0048;
					}
					IL_006B:
					switch (num)
					{
					case 1:
						IL_0048:
						buffer[2] = MathUtils.IntToHex((int)((c >> 12) & '\u000f'));
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
						{
							goto IL_0006;
						}
						goto IL_006B;
					case 2:
						continue;
					case 3:
						goto IL_00A8;
					case 4:
						goto IL_0026;
					case 5:
						return;
					case 6:
						goto IL_0006;
					}
					goto Block_3;
					IL_0006:
					buffer[3] = MathUtils.IntToHex((int)((c >> 8) & '\u000f'));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
					{
						goto IL_006B;
					}
					IL_0026:
					buffer[4] = MathUtils.IntToHex((int)((c >> 4) & '\u000f'));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto Block_1;
					}
					goto IL_006B;
				}
			}
			Block_1:
			Block_3:
			buffer[5] = MathUtils.IntToHex((int)(c & '\u000f'));
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00051D78 File Offset: 0x0004FF78
		[return: Nullable(2)]
		public static TSource ForgivingCaseSensitiveFind<[Nullable(2)] TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			StringUtils.<>c__DisplayClass14_0<TSource> CS$<>8__locals1 = new StringUtils.<>c__DisplayClass14_0<TSource>();
			CS$<>8__locals1.func_0 = valueSelector;
			CS$<>8__locals1.string_0 = testValue;
			if (source == null)
			{
				throw new ArgumentNullException(Class15.smethod_17(1270998432 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
			}
			if (CS$<>8__locals1.func_0 == null)
			{
				throw new ArgumentNullException(Class15.smethod_17(1116157283 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54));
			}
			IEnumerable<TSource> enumerable = source.Where(new Func<TSource, bool>(CS$<>8__locals1.method_0));
			if (enumerable.Count<TSource>() <= 1)
			{
				return enumerable.SingleOrDefault<TSource>();
			}
			return source.Where(new Func<TSource, bool>(CS$<>8__locals1.method_1)).SingleOrDefault<TSource>();
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00051E14 File Offset: 0x00050014
		public static string ToCamelCase(string s)
		{
			IL_01A0:
			while (!StringUtils.IsNullOrEmpty(s))
			{
				int num = 5;
				char[] array;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					for (;;)
					{
						switch (num)
						{
						case 3:
							goto IL_0055;
						case 4:
							return s;
						case 5:
							if (char.IsUpper(s[0]))
							{
								array = s.ToCharArray();
								goto IL_012F;
							}
							return s;
						case 6:
							goto IL_01A0;
						case 7:
							goto IL_00BD;
						case 8:
						case 15:
							goto IL_00E2;
						case 10:
							goto IL_0079;
						case 11:
							goto IL_0081;
						case 12:
							goto IL_012F;
						case 13:
							goto IL_0031;
						case 14:
							goto IL_0086;
						case 16:
							goto IL_00B3;
						case 17:
							goto IL_0092;
						case 18:
							goto IL_0020;
						}
						break;
						IL_0031:
						int num2;
						array[num2] = StringUtils.OaIduOkocL(array[num2]);
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
						{
							goto IL_0055;
						}
						continue;
						IL_0020:
						if (char.IsSeparator(array[num2 + 1]))
						{
							goto IL_0031;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
						{
							break;
						}
						continue;
						IL_0055:
						array[num2] = StringUtils.OaIduOkocL(array[num2]);
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto IL_0079;
						}
						continue;
						IL_00B3:
						bool flag;
						if (num2 > 0 && flag)
						{
							goto IL_00BD;
						}
						goto IL_0055;
						IL_0092:
						flag = num2 + 1 < array.Length;
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
						{
							goto IL_00B3;
						}
						continue;
						IL_0086:
						if (char.IsUpper(array[num2]))
						{
							goto IL_0092;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							break;
						}
						continue;
						IL_0081:
						if (num2 == 1)
						{
							goto IL_0086;
						}
						goto IL_0092;
						IL_00E2:
						if (num2 < array.Length)
						{
							goto IL_0081;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							break;
						}
						continue;
						IL_012F:
						num2 = 0;
						goto IL_00E2;
						IL_0079:
						num2++;
						goto IL_00E2;
						IL_00BD:
						if (char.IsUpper(array[num2 + 1]))
						{
							goto IL_0055;
						}
						num = 17;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
						{
							goto IL_0020;
						}
					}
				}
				return new string(array);
			}
			return s;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00051FE4 File Offset: 0x000501E4
		private static char OaIduOkocL(char char_0)
		{
			for (;;)
			{
				char_0 = char.ToLower(char_0, CultureInfo.InvariantCulture);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
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
			return char_0;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0000467E File Offset: 0x0000287E
		public static string ToSnakeCase(string s)
		{
			return StringUtils.smethod_1(s, '_');
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00004688 File Offset: 0x00002888
		public static string ToKebabCase(string s)
		{
			return StringUtils.smethod_1(s, '-');
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00052024 File Offset: 0x00050224
		private static string smethod_1(string string_0, char char_0)
		{
			StringBuilder stringBuilder;
			for (;;)
			{
				if (!StringUtils.IsNullOrEmpty(string_0))
				{
					stringBuilder = new StringBuilder();
					goto IL_02CE;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					break;
				}
				IL_022A:
				int num2;
				StringUtils.Enum0 @enum;
				switch (num)
				{
				case 1:
					continue;
				case 2:
				case 3:
				case 35:
				case 36:
				case 37:
					goto IL_01CB;
				case 4:
					goto IL_00FF;
				case 5:
					goto IL_00C6;
				case 6:
					goto IL_01C3;
				case 7:
					goto IL_0020;
				case 8:
				case 14:
				case 21:
				case 28:
				case 30:
					goto IL_01E4;
				case 9:
				case 27:
					goto IL_0047;
				case 10:
					goto IL_00D4;
				case 11:
					goto IL_0075;
				case 12:
					goto IL_0099;
				case 13:
					goto IL_0175;
				case 15:
					num2 = 0;
					goto IL_0047;
				case 16:
					goto IL_00DE;
				case 17:
					goto IL_0150;
				case 18:
					goto IL_0181;
				case 19:
					@enum = (StringUtils.Enum0)1;
					goto IL_01E4;
				case 20:
					goto IL_0108;
				case 22:
					goto IL_00AB;
				case 23:
					goto IL_003F;
				case 24:
				case 32:
					goto IL_0069;
				case 25:
					goto IL_01B8;
				case 26:
					goto IL_0186;
				case 29:
					goto IL_007C;
				case 31:
					goto IL_0319;
				case 33:
					goto IL_013F;
				case 34:
					IL_02CE:
					@enum = (StringUtils.Enum0)0;
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto IL_0099;
					}
					goto IL_022A;
				case 38:
					goto IL_0012;
				}
				break;
				IL_0020:
				char c;
				stringBuilder.Append(c);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
				{
					goto IL_003F;
				}
				goto IL_022A;
				IL_01CB:
				c = char.ToLower(string_0[num2], CultureInfo.InvariantCulture);
				goto IL_0020;
				IL_0012:
				stringBuilder.Append(char_0);
				goto IL_01CB;
				IL_00AB:
				bool flag;
				switch (@enum)
				{
				case (StringUtils.Enum0)1:
				case (StringUtils.Enum0)3:
					goto IL_0012;
				case (StringUtils.Enum0)2:
					IL_00C6:
					flag = num2 + 1 < string_0.Length;
					goto IL_00D4;
				default:
					goto IL_01CB;
				}
				IL_0099:
				if (char.IsUpper(string_0[num2]))
				{
					goto IL_00AB;
				}
				goto IL_013F;
				IL_0069:
				if (string_0[num2] == ' ')
				{
					goto IL_0075;
				}
				goto IL_0099;
				IL_0047:
				if (num2 >= string_0.Length)
				{
					goto IL_0319;
				}
				num = 32;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					goto IL_0069;
				}
				goto IL_022A;
				IL_01E4:
				num2++;
				goto IL_0047;
				IL_0075:
				if (@enum != (StringUtils.Enum0)0)
				{
					goto IL_007C;
				}
				goto IL_01E4;
				IL_003F:
				@enum = (StringUtils.Enum0)2;
				goto IL_01E4;
				IL_007C:
				@enum = (StringUtils.Enum0)3;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					goto IL_01E4;
				}
				goto IL_022A;
				IL_00DE:
				char c2 = string_0[num2 + 1];
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_00FF;
				}
				goto IL_022A;
				IL_00D4:
				if (num2 > 0 && flag)
				{
					goto IL_00DE;
				}
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_01CB;
				}
				goto IL_022A;
				IL_0108:
				@enum = (StringUtils.Enum0)0;
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_01E4;
				}
				goto IL_022A;
				IL_00FF:
				stringBuilder.Append(char_0);
				goto IL_0108;
				IL_013F:
				if (string_0[num2] != char_0)
				{
					goto IL_01C3;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					break;
				}
				goto IL_022A;
				IL_0150:
				stringBuilder.Append(string_0[num2]);
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_0175;
				}
				goto IL_022A;
				IL_01C3:
				if (@enum != (StringUtils.Enum0)3)
				{
					goto IL_0150;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					goto IL_022A;
				}
				IL_01B8:
				stringBuilder.Append(char_0);
				goto IL_0150;
				IL_0186:
				stringBuilder.Append(char_0);
				num = 37;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_01C3;
				}
				goto IL_022A;
				IL_0175:
				if (char.IsUpper(c2))
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						break;
					}
					goto IL_022A;
				}
				IL_0181:
				if (c2 != char_0)
				{
					goto IL_0186;
				}
				goto IL_01CB;
			}
			return string_0;
			IL_0319:
			return stringBuilder.ToString();
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00004692 File Offset: 0x00002892
		public static bool IsHighSurrogate(char c)
		{
			return char.IsHighSurrogate(c);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0000469A File Offset: 0x0000289A
		public static bool IsLowSurrogate(char c)
		{
			return char.IsLowSurrogate(c);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000046A2 File Offset: 0x000028A2
		public static int IndexOf(string s, char c)
		{
			return s.IndexOf(c);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000046AB File Offset: 0x000028AB
		public static string Replace(string s, string oldValue, string newValue)
		{
			return s.Replace(oldValue, newValue);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00052354 File Offset: 0x00050554
		public static bool StartsWith(this string source, char value)
		{
			while (source.Length > 0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return source[0] == value;
			}
			return false;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000523A0 File Offset: 0x000505A0
		public static bool EndsWith(this string source, char value)
		{
			while (source.Length <= 0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0037;
					}
				}
				return false;
			}
			IL_0037:
			return source[source.Length - 1] == value;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000523F8 File Offset: 0x000505F8
		public static string Trim(this string s, int start, int length)
		{
			IL_0136:
			while (s != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_00BD;
				}
				int num2;
				for (;;)
				{
					IL_00E2:
					switch (num)
					{
					case 1:
						goto IL_0136;
					case 2:
						goto IL_01AD;
					case 3:
						goto IL_003C;
					case 4:
						num2 = start + length - 1;
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
						{
							goto IL_007E;
						}
						continue;
					case 5:
						goto IL_007E;
					case 6:
					case 7:
						goto IL_0073;
					case 8:
						goto IL_013F;
					case 9:
						goto IL_015A;
					case 10:
					case 11:
					case 18:
						goto IL_01A5;
					case 12:
						goto IL_008E;
					case 13:
						goto IL_0020;
					case 14:
						goto IL_019F;
					case 15:
						goto IL_0190;
					case 16:
						goto IL_01B3;
					case 17:
						goto IL_0175;
					}
					break;
					IL_0020:
					start++;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto IL_0073;
					}
					continue;
					IL_003C:
					if (char.IsWhiteSpace(s[start]))
					{
						goto IL_0020;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
					{
						goto IL_007E;
					}
					continue;
					IL_0073:
					if (start < num2)
					{
						goto IL_003C;
					}
					goto IL_01A5;
					IL_007E:
					if (num2 >= s.Length)
					{
						goto IL_015A;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
					{
						goto IL_0073;
					}
				}
				goto IL_00BD;
				IL_015A:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(2060583880 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177));
				IL_0190:
				if (!char.IsWhiteSpace(s[num2]))
				{
					goto IL_01B3;
				}
				IL_019F:
				num2--;
				IL_01A5:
				if (num2 >= start)
				{
					goto IL_0190;
				}
				IL_01B3:
				return s.Substring(start, num2 - start + 1);
				IL_008E:
				if (length < 0)
				{
					goto IL_013F;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
				{
					goto IL_00E2;
				}
				IL_00BD:
				if (start < 0)
				{
					goto IL_0175;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_008E;
				}
				goto IL_00E2;
				IL_013F:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(432135735 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
				IL_0175:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(698982374 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
			}
			IL_01AD:
			throw new ArgumentNullException();
		}

		// Token: 0x0400049C RID: 1180
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x0400049D RID: 1181
		public const string Empty = "";

		// Token: 0x0400049E RID: 1182
		public const char CarriageReturn = '\r';

		// Token: 0x0400049F RID: 1183
		public const char LineFeed = '\n';

		// Token: 0x040004A0 RID: 1184
		public const char Tab = '\t';

		// Token: 0x020000DC RID: 220
		[NullableContext(0)]
		private enum Enum0
		{

		}
	}
}
