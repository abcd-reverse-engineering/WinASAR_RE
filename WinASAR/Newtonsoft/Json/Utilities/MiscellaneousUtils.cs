using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000CB RID: 203
	[Nullable(0)]
	[NullableContext(1)]
	internal static class MiscellaneousUtils
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x00002420 File Offset: 0x00000620
		[NullableContext(2)]
		[Conditional("DEBUG")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, string message = null)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		[NullableContext(2)]
		public static bool ValueEquals(object objA, object objB)
		{
			IL_015C:
			while (objA != objB)
			{
				if (objA != null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						for (;;)
						{
							switch (num)
							{
							case 1:
								if (objB == null)
								{
									num = 8;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
									{
										goto Block_12;
									}
									continue;
								}
								else
								{
									if (!(objA.GetType() != objB.GetType()))
									{
										goto Block_13;
									}
									goto IL_00BC;
								}
								break;
							case 2:
								return false;
							case 3:
								goto IL_016C;
							case 4:
							case 8:
							case 12:
								goto IL_0058;
							case 5:
								goto IL_00C7;
							case 6:
								return true;
							case 7:
								goto IL_015C;
							case 9:
								return false;
							case 10:
								goto IL_00BC;
							case 11:
								goto IL_0045;
							case 13:
								goto IL_0179;
							case 14:
								goto IL_004D;
							case 15:
								if (!(objB is decimal))
								{
									return false;
								}
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
								{
									continue;
								}
								break;
							case 16:
								goto IL_0078;
							case 17:
								goto IL_018F;
							case 18:
								goto IL_0026;
							}
							goto Block_14;
							IL_0026:
							if (!(objA is double))
							{
								goto IL_0045;
							}
							num = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
							{
								goto IL_0058;
							}
							continue;
							IL_00BC:
							if (ConvertUtils.IsInteger(objA))
							{
								goto IL_00C7;
							}
							goto IL_0026;
							IL_0058:
							if (objB is double)
							{
								goto IL_019C;
							}
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
							{
								goto IL_0078;
							}
							continue;
							IL_0045:
							if (!(objA is float))
							{
								goto IL_004D;
							}
							goto IL_0058;
							IL_0078:
							if (objB is float)
							{
								goto IL_019C;
							}
							num = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
							{
								break;
							}
							continue;
							IL_00C7:
							if (ConvertUtils.IsInteger(objB))
							{
								goto Block_10;
							}
							goto IL_0026;
							IL_004D:
							if (objA is decimal)
							{
								goto IL_0058;
							}
							return false;
						}
						break;
						goto IL_019C;
						Block_10:
						goto IL_016C;
						Block_12:
						return false;
						Block_13:
						goto IL_018F;
						Block_14:
						goto IL_019C;
						IL_016C:
						decimal num2 = Convert.ToDecimal(objA, CultureInfo.CurrentCulture);
						IL_0179:
						return num2.Equals(Convert.ToDecimal(objB, CultureInfo.CurrentCulture));
						IL_018F:
						return objA.Equals(objB);
					}
					IL_019C:
					return MathUtils.ApproxEquals(Convert.ToDouble(objA, CultureInfo.CurrentCulture), Convert.ToDouble(objB, CultureInfo.CurrentCulture));
				}
				return false;
			}
			return true;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			string text;
			for (;;)
			{
				text = message + Environment.NewLine + Class15.smethod_17(1243276080 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95).FormatWith(CultureInfo.InvariantCulture, actualValue);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
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
			return new ArgumentOutOfRangeException(paramName, text);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0004E50C File Offset: 0x0004C70C
		public static string ToString([Nullable(2)] object value)
		{
			while (value != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					string text;
					switch (num)
					{
					case 0:
						goto IL_0079;
					case 1:
						text = value as string;
						break;
					case 2:
						continue;
					case 3:
						goto IL_0080;
					case 4:
						goto IL_0046;
					case 5:
						break;
					default:
						goto IL_0079;
					}
					if (text == null)
					{
						goto IL_0079;
					}
					IL_0046:
					return Class15.smethod_17(1807890812 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3) + text + Class15.smethod_17(1793857828 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
				}
				IL_0079:
				return value.ToString();
			}
			IL_0080:
			return Class15.smethod_17(635822995 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0004E5B0 File Offset: 0x0004C7B0
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			for (;;)
			{
				int num = a1.Length;
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0075;
				}
				IL_0083:
				int num3;
				int num4;
				switch (num2)
				{
				case 0:
					goto IL_005E;
				case 1:
					IL_0075:
					num3 = num.CompareTo(a2.Length);
					goto IL_0045;
				case 2:
					continue;
				case 3:
					goto IL_0006;
				case 4:
					goto IL_0045;
				case 5:
					return 0;
				case 6:
					break;
				case 7:
				case 10:
					goto IL_0038;
				case 8:
					return num4;
				case 9:
					return num3;
				default:
					goto IL_005E;
				}
				IL_0019:
				if (num4 != 0)
				{
					return num4;
				}
				int num5;
				num5++;
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
				{
					goto IL_0038;
				}
				goto IL_0083;
				IL_0006:
				num4 = a1[num5].CompareTo(a2[num5]);
				goto IL_0019;
				IL_0038:
				if (num5 >= a1.Length)
				{
					break;
				}
				goto IL_0006;
				IL_0045:
				if (num3 != 0)
				{
					return num3;
				}
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_0083;
				}
				IL_005E:
				num5 = 0;
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_0038;
				}
				goto IL_0083;
			}
			return 0;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0004E694 File Offset: 0x0004C894
		[return: Nullable(2)]
		public static string GetPrefix(string qualifiedName)
		{
			string text;
			for (;;)
			{
				string text2;
				MiscellaneousUtils.GetQualifiedNameParts(qualifiedName, out text, out text2);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
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
			return text;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0004E6D0 File Offset: 0x0004C8D0
		public static string GetLocalName(string qualifiedName)
		{
			string text2;
			for (;;)
			{
				string text;
				MiscellaneousUtils.GetQualifiedNameParts(qualifiedName, out text, out text2);
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
			return text2;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0004E70C File Offset: 0x0004C90C
		public static void GetQualifiedNameParts(string qualifiedName, [Nullable(2)] out string prefix, out string localName)
		{
			int num;
			for (;;)
			{
				IL_008E:
				num = StringUtils.IndexOf(qualifiedName, ':');
				int num2 = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_000A;
				}
				for (;;)
				{
					IL_005E:
					switch (num2)
					{
					case 1:
						return;
					case 2:
						return;
					case 3:
					case 6:
						goto IL_000A;
					case 4:
						if (num == -1)
						{
							goto IL_000A;
						}
						num2 = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							continue;
						}
						return;
					case 5:
						goto IL_008E;
					case 7:
						localName = qualifiedName;
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
						{
							return;
						}
						continue;
					case 8:
						goto IL_0006;
					case 9:
						goto IL_00BF;
					}
					goto Block_4;
				}
				IL_0006:
				if (num == 0)
				{
					goto IL_000A;
				}
				Block_4:
				goto IL_001F;
				IL_000A:
				prefix = null;
				num2 = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_005E;
				}
				IL_001F:
				if (qualifiedName.Length - 1 == num)
				{
					goto IL_000A;
				}
				goto IL_00B4;
			}
			return;
			IL_00B4:
			prefix = qualifiedName.Substring(0, num);
			IL_00BF:
			localName = qualifiedName.Substring(num + 1);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0004E7E4 File Offset: 0x0004C9E4
		internal static RegexOptions GetRegexOptions(string optionsText)
		{
			RegexOptions regexOptions;
			for (;;)
			{
				IL_0142:
				regexOptions = RegexOptions.None;
				for (;;)
				{
					IL_013D:
					int i = 0;
					while (i < optionsText.Length)
					{
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
						{
							goto IL_00B9;
						}
						goto IL_00C5;
						for (;;)
						{
							IL_009F:
							regexOptions |= RegexOptions.Multiline;
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
							{
								goto IL_00C5;
							}
						}
						IL_0026:
						i++;
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							continue;
						}
						goto IL_00C5;
						IL_0020:
						regexOptions |= RegexOptions.IgnoreCase;
						goto IL_0026;
						IL_0090:
						char c;
						if (c != 'i')
						{
							goto IL_0096;
						}
						goto IL_0020;
						IL_0061:
						if (c <= 'm')
						{
							goto IL_0090;
						}
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
						{
							goto IL_0079;
						}
						goto IL_00C5;
						IL_00B9:
						c = optionsText[i];
						goto IL_0061;
						IL_00C5:
						switch (num)
						{
						case 0:
						case 2:
						case 9:
						case 11:
						case 14:
						case 19:
							goto IL_0026;
						case 1:
							goto IL_009F;
						case 3:
						case 15:
							goto IL_00B9;
						case 4:
						case 21:
							continue;
						case 5:
							goto IL_0096;
						case 6:
							goto IL_007F;
						case 7:
							goto IL_013D;
						case 8:
							goto IL_0142;
						case 10:
							goto IL_0088;
						case 12:
						case 16:
							goto IL_0079;
						case 13:
							goto IL_0090;
						case 17:
							goto IL_0061;
						case 18:
							return regexOptions;
						case 20:
							break;
						case 22:
							goto IL_0020;
						default:
							goto IL_0026;
						}
						IL_0046:
						regexOptions |= RegexOptions.Singleline;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
						{
							goto IL_0026;
						}
						goto IL_00C5;
						IL_0079:
						if (c == 's')
						{
							goto IL_0046;
						}
						IL_007F:
						if (c != 'x')
						{
							goto IL_0026;
						}
						IL_0088:
						regexOptions |= RegexOptions.ExplicitCapture;
						goto IL_0026;
						IL_0096:
						if (c != 'm')
						{
							goto IL_0026;
						}
						goto IL_009F;
					}
					return regexOptions;
				}
			}
			return regexOptions;
		}
	}
}
