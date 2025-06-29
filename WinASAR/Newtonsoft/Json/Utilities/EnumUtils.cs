using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000AC RID: 172
	[NullableContext(1)]
	[Nullable(0)]
	internal static class EnumUtils
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x000499B8 File Offset: 0x00047BB8
		private static EnumInfo smethod_0([Nullable(new byte[] { 0, 1, 2 })] StructMultiKey<Type, NamingStrategy> key)
		{
			Type value = key.Value1;
			string[] names = Enum.GetNames(value);
			string[] array = new string[names.Length];
			ulong[] array2 = new ulong[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				string text = names[i];
				FieldInfo field = value.GetField(text, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				array2[i] = EnumUtils.smethod_2(field.GetValue(null));
				string text2 = field.GetCustomAttributes(typeof(EnumMemberAttribute), true).Cast<EnumMemberAttribute>().Select(new Func<EnumMemberAttribute, string>(EnumUtils.<>c.<>c_0.method_0))
					.SingleOrDefault<string>();
				bool flag = text2 != null;
				string text3 = text2 ?? text;
				if (Array.IndexOf<string>(array, text3, 0, i) != -1)
				{
					throw new InvalidOperationException(Class15.smethod_17(1116147593 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54).FormatWith(CultureInfo.InvariantCulture, text3, value.Name));
				}
				array[i] = ((key.Value2 != null) ? key.Value2.GetPropertyName(text3, flag) : text3);
			}
			return new EnumInfo(value.IsDefined(typeof(FlagsAttribute), false), array2, names, array);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00049AE8 File Offset: 0x00047CE8
		[NullableContext(0)]
		[return: Nullable(new byte[] { 1, 0 })]
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsDefined(typeof(FlagsAttribute), false))
			{
				throw new ArgumentException(Class15.smethod_17(1424563950 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, typeFromHandle));
			}
			Type underlyingType = Enum.GetUnderlyingType(value.GetType());
			ulong num = EnumUtils.smethod_2(value);
			EnumInfo enumValuesAndNames = EnumUtils.GetEnumValuesAndNames(typeFromHandle);
			IList<T> list = new List<T>();
			for (int i = 0; i < enumValuesAndNames.Values.Length; i++)
			{
				ulong num2 = enumValuesAndNames.Values[i];
				if ((num & num2) == num2 && num2 != 0UL)
				{
					list.Add((T)((object)Convert.ChangeType(num2, underlyingType, CultureInfo.CurrentCulture)));
				}
			}
			if (list.Count == 0)
			{
				if (enumValuesAndNames.Values.Any(new Func<ulong, bool>(EnumUtils.<>c__4<T>.<>c__4_0.method_0)))
				{
					list.Add(default(T));
				}
			}
			return list;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00003F5A File Offset: 0x0000215A
		public static bool TryToString(Type enumType, object value, bool camelCase, [NotNullWhen(true)] [Nullable(2)] out string name)
		{
			return EnumUtils.TryToString(enumType, value, (!camelCase) ? null : EnumUtils.camelCaseNamingStrategy_0, out name);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00049BFC File Offset: 0x00047DFC
		public static bool TryToString(Type enumType, object value, [Nullable(2)] NamingStrategy namingStrategy, [NotNullWhen(true)] [Nullable(2)] out string name)
		{
			EnumInfo enumInfo;
			ulong num3;
			for (;;)
			{
				enumInfo = EnumUtils.threadSafeStore_0.Get(new StructMultiKey<Type, NamingStrategy>(enumType, namingStrategy));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_0068;
				}
				IL_0083:
				switch (num)
				{
				case 1:
					goto IL_0068;
				case 2:
					continue;
				case 3:
					goto IL_00E2;
				case 4:
					goto IL_0031;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					goto IL_004A;
				case 8:
					goto IL_0006;
				case 9:
					goto IL_00F1;
				case 10:
					goto IL_00F7;
				}
				IL_000F:
				int num2 = Array.BinarySearch<ulong>(enumInfo.Values, num3);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_0031;
				}
				goto IL_0083;
				IL_0006:
				if (!enumInfo.IsFlags)
				{
					goto IL_000F;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0083;
				}
				continue;
				IL_0068:
				num3 = EnumUtils.smethod_2(value);
				goto IL_0006;
				IL_0031:
				if (num2 < 0)
				{
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto IL_0068;
					}
					goto IL_0083;
				}
				IL_004A:
				name = enumInfo.ResolvedNames[num2];
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_0068;
				}
				goto IL_0083;
			}
			IL_00E2:
			name = EnumUtils.smethod_1(enumInfo, num3);
			IL_00F1:
			return name != null;
			IL_00F7:
			name = null;
			return false;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00049D04 File Offset: 0x00047F04
		[return: Nullable(2)]
		private static string smethod_1(object object_0, ulong ulong_0)
		{
			string[] resolvedNames;
			ulong[] values;
			StringBuilder stringBuilder;
			string text2;
			for (;;)
			{
				IL_01E2:
				resolvedNames = object_0.ResolvedNames;
				for (;;)
				{
					IL_01D8:
					values = object_0.Values;
					for (;;)
					{
						IL_01CE:
						int num = values.Length - 1;
						for (;;)
						{
							IL_01B0:
							stringBuilder = new StringBuilder();
							int num2 = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
							{
								goto Block_7;
							}
							for (;;)
							{
								IL_011F:
								bool flag;
								ulong num3;
								switch (num2)
								{
								case 1:
								case 12:
									goto IL_0203;
								case 2:
									goto IL_003A;
								case 3:
									goto IL_01D8;
								case 4:
									goto IL_01E2;
								case 5:
									goto IL_0052;
								case 6:
									flag = true;
									num2 = 31;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
									{
										continue;
									}
									goto IL_01AF;
								case 7:
									goto IL_007B;
								case 9:
								case 24:
									goto IL_0013;
								case 10:
									goto IL_0085;
								case 11:
									goto IL_01B0;
								case 13:
									goto IL_002F;
								case 15:
								case 21:
									goto IL_01EF;
								case 16:
									goto IL_0208;
								case 17:
								case 23:
									goto IL_0082;
								case 18:
									goto IL_0077;
								case 19:
									goto IL_000F;
								case 20:
									goto IL_00DA;
								case 22:
									goto IL_00C0;
								case 25:
									goto IL_00EE;
								case 27:
								case 29:
									goto IL_00A6;
								case 28:
									goto IL_008C;
								case 30:
									goto IL_01CE;
								case 31:
									num3 = ulong_0;
									goto IL_00A6;
								case 32:
									goto IL_01FD;
								case 33:
									goto IL_0006;
								}
								goto Block_6;
								for (;;)
								{
									IL_00EE:
									num--;
									num2 = 27;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
									{
										goto IL_011F;
									}
								}
								IL_0013:
								string text = resolvedNames[num];
								num2 = 8;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
								{
									goto IL_002F;
								}
								continue;
								IL_000F:
								if (flag)
								{
									goto IL_0013;
								}
								goto IL_0052;
								IL_0006:
								ulong_0 -= values[num];
								goto IL_000F;
								IL_00DA:
								if ((ulong_0 & values[num]) == values[num])
								{
									goto IL_0006;
								}
								goto IL_00EE;
								IL_0077:
								if (num == 0)
								{
									goto IL_007B;
								}
								goto IL_00DA;
								IL_00A6:
								if (num < 0)
								{
									goto IL_0082;
								}
								goto IL_0077;
								IL_003A:
								flag = false;
								num2 = 25;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
								{
									goto IL_0052;
								}
								continue;
								IL_002F:
								stringBuilder.Insert(0, text);
								goto IL_003A;
								IL_008C:
								if (values.Length == 0)
								{
									goto IL_0203;
								}
								num2 = 32;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
								{
									goto IL_00A6;
								}
								continue;
								IL_0085:
								if (num3 == 0UL)
								{
									goto IL_008C;
								}
								goto IL_01EF;
								IL_0082:
								if (ulong_0 == 0UL)
								{
									goto IL_0085;
								}
								num2 = 17;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
								{
									continue;
								}
								IL_00C0:
								text2 = null;
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
								{
									goto Block_3;
								}
								continue;
								IL_0052:
								stringBuilder.Insert(0, Class15.smethod_17(1802357803 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
								goto IL_0013;
								IL_007B:
								if (values[num] == 0UL)
								{
									goto IL_0082;
								}
								goto IL_00DA;
							}
							IL_01AF:;
						}
					}
				}
			}
			Block_3:
			Block_6:
			Block_7:
			return text2;
			IL_01EF:
			return stringBuilder.ToString();
			IL_01FD:
			if (values[0] == 0UL)
			{
				goto IL_0208;
			}
			IL_0203:
			return null;
			IL_0208:
			text2 = resolvedNames[0];
			return text2;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00003F6F File Offset: 0x0000216F
		public static EnumInfo GetEnumValuesAndNames(Type enumType)
		{
			return EnumUtils.threadSafeStore_0.Get(new StructMultiKey<Type, NamingStrategy>(enumType, null));
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00049F24 File Offset: 0x00048124
		private static ulong smethod_2(object object_0)
		{
			for (;;)
			{
				IL_0081:
				bool flag;
				PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(object_0.GetType(), out flag);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_00F3;
					case 2:
						switch (typeCode)
						{
						case PrimitiveTypeCode.Char:
							goto IL_00A7;
						case PrimitiveTypeCode.CharNullable:
						case PrimitiveTypeCode.BooleanNullable:
						case PrimitiveTypeCode.SByteNullable:
						case PrimitiveTypeCode.Int16Nullable:
						case PrimitiveTypeCode.UInt16Nullable:
						case PrimitiveTypeCode.Int32Nullable:
						case PrimitiveTypeCode.ByteNullable:
						case PrimitiveTypeCode.UInt32Nullable:
						case PrimitiveTypeCode.Int64Nullable:
							goto IL_00F3;
						case PrimitiveTypeCode.Boolean:
							goto IL_00AF;
						case PrimitiveTypeCode.SByte:
							break;
						case PrimitiveTypeCode.Int16:
							goto IL_00C4;
						case PrimitiveTypeCode.UInt16:
							goto IL_00CC;
						case PrimitiveTypeCode.Int32:
							goto IL_00D4;
						case PrimitiveTypeCode.Byte:
							goto IL_00DC;
						case PrimitiveTypeCode.UInt32:
							goto IL_00E4;
						case PrimitiveTypeCode.Int64:
							goto IL_00EC;
						case PrimitiveTypeCode.UInt64:
							goto IL_010E;
						default:
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
							{
								continue;
							}
							break;
						}
						break;
					case 3:
						goto IL_0081;
					}
					goto Block_2;
				}
			}
			Block_2:
			goto IL_00BC;
			IL_00A7:
			return (ulong)((char)object_0);
			IL_00AF:
			return (ulong)Convert.ToByte((bool)object_0);
			IL_00BC:
			return (ulong)((long)((sbyte)object_0));
			IL_00C4:
			return (ulong)((long)((short)object_0));
			IL_00CC:
			return (ulong)((ushort)object_0);
			IL_00D4:
			return (ulong)((long)((int)object_0));
			IL_00DC:
			return (ulong)((byte)object_0);
			IL_00E4:
			return (ulong)((uint)object_0);
			IL_00EC:
			return (ulong)((long)object_0);
			IL_00F3:
			throw new InvalidOperationException(Class15.smethod_17(926365247 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
			IL_010E:
			return (ulong)object_0;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0004A048 File Offset: 0x00048248
		public static object ParseEnum(Type enumType, [Nullable(2)] NamingStrategy namingStrategy, string value, bool disallowNumber)
		{
			int? num4;
			ulong[] values;
			ulong num9;
			object obj;
			for (;;)
			{
				IL_0001:
				ValidationUtils.ArgumentNotNull(enumType, Class15.smethod_17(676710274 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
				int num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_0031;
				}
				int num3;
				int num2;
				for (;;)
				{
					IL_0416:
					switch (num)
					{
					case 1:
						goto IL_017D;
					case 2:
						goto IL_0330;
					case 3:
						goto IL_015F;
					case 4:
						goto IL_0309;
					case 5:
						goto IL_00DE;
					case 6:
					case 39:
						goto IL_01E6;
					case 7:
					case 37:
						goto IL_019C;
					case 8:
						goto IL_004C;
					case 9:
					case 20:
						goto IL_0370;
					case 10:
						goto IL_051F;
					case 11:
						goto IL_052C;
					case 12:
						goto IL_05BE;
					case 13:
					case 55:
					case 61:
						goto IL_00BA;
					case 14:
						goto IL_0156;
					case 15:
						goto IL_018A;
					case 16:
						goto IL_03FC;
					case 17:
					case 60:
						goto IL_02C7;
					case 18:
						goto IL_01CB;
					case 19:
					case 58:
						goto IL_02E8;
					case 21:
						goto IL_007F;
					case 22:
					case 38:
						goto IL_0121;
					case 23:
						goto IL_05AD;
					case 24:
						goto IL_0288;
					case 25:
					case 32:
						goto IL_02A3;
					case 26:
						goto IL_014A;
					case 27:
					case 59:
						goto IL_00C3;
					case 29:
					case 43:
						goto IL_0181;
					case 30:
						goto IL_03B0;
					case 31:
						goto IL_05EE;
					case 33:
						goto IL_03ED;
					case 34:
						goto IL_03D7;
					case 35:
						goto IL_0057;
					case 36:
						goto IL_0208;
					case 40:
					case 52:
						num2 = value.IndexOf(',', num3);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
						{
							goto IL_03B0;
						}
						continue;
					case 41:
						goto IL_0031;
					case 42:
						goto IL_0001;
					case 44:
						goto IL_03B8;
					case 45:
						goto IL_0574;
					case 46:
						goto IL_0571;
					case 47:
						goto IL_05A3;
					case 48:
						goto IL_057D;
					case 49:
						goto IL_0091;
					case 50:
						goto IL_009D;
					case 51:
						goto IL_02CF;
					case 53:
						goto IL_00EF;
					case 54:
						goto IL_0210;
					case 56:
						goto IL_0213;
					case 57:
						goto IL_00F6;
					}
					goto Block_20;
					IL_03B8:
					num2 = value.Length;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
					{
						break;
					}
					continue;
					IL_03B0:
					if (num2 == -1)
					{
						goto IL_03B8;
					}
					break;
				}
				goto IL_017D;
				IL_03ED:
				if (num4 != null)
				{
					goto IL_02E8;
				}
				IL_03D7:
				string[] names;
				string[] resolvedNames;
				int num5;
				num4 = EnumUtils.smethod_3(value, names, resolvedNames, num3, num5, StringComparison.OrdinalIgnoreCase);
				goto IL_02E8;
				Block_20:
				goto IL_02D8;
				IL_009D:
				int num6 = -1;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					goto IL_03FC;
				}
				goto IL_0416;
				IL_0091:
				if (num4 == null)
				{
					goto IL_009D;
				}
				goto IL_05EE;
				IL_007F:
				num4 = EnumUtils.smethod_4(resolvedNames, value, 0, value.Length, StringComparison.Ordinal);
				goto IL_0091;
				IL_0057:
				EnumInfo enumInfo = EnumUtils.threadSafeStore_0.Get(new StructMultiKey<Type, NamingStrategy>(enumType, namingStrategy));
				names = enumInfo.Names;
				resolvedNames = enumInfo.ResolvedNames;
				values = enumInfo.Values;
				goto IL_007F;
				IL_004C:
				if (enumType.IsEnum())
				{
					goto IL_0057;
				}
				goto IL_05BE;
				IL_0031:
				ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(974439475 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
				goto IL_004C;
				IL_00C3:
				int num7;
				num7--;
				num = 61;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0416;
				}
				IL_00DE:
				if (!char.IsWhiteSpace(value[num7 - 1]))
				{
					goto IL_00EF;
				}
				goto IL_00C3;
				IL_00BA:
				if (num7 <= num3)
				{
					goto IL_00EF;
				}
				goto IL_00DE;
				IL_018A:
				if (char.IsWhiteSpace(value[num3]))
				{
					goto IL_019C;
				}
				goto IL_00BA;
				IL_0181:
				if (num3 < num2)
				{
					goto IL_018A;
				}
				goto IL_00BA;
				IL_017D:
				num7 = num2;
				goto IL_0181;
				IL_00F6:
				num4 = EnumUtils.smethod_3(value, names, resolvedNames, num3, num5, StringComparison.Ordinal);
				num = 33;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_02D8;
				}
				goto IL_0416;
				IL_00EF:
				num5 = num7 - num3;
				goto IL_00F6;
				IL_0121:
				char c;
				if (num6 != -1)
				{
					c = value[num6];
					goto IL_014A;
				}
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_01E6;
				}
				goto IL_0416;
				IL_02D8:
				int num8;
				if (num8 < value.Length)
				{
					goto IL_02A3;
				}
				goto IL_0121;
				IL_02C7:
				num8++;
				goto IL_02D8;
				IL_02CF:
				num6 = num8;
				goto IL_0121;
				IL_02A3:
				if (!char.IsWhiteSpace(value[num8]))
				{
					goto IL_02CF;
				}
				num = 29;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_02C7;
				}
				goto IL_0416;
				IL_015F:
				if (c != '+')
				{
					goto IL_0268;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_017D;
				}
				goto IL_0416;
				IL_0156:
				if (c != '-')
				{
					goto IL_015F;
				}
				goto IL_0370;
				IL_014A:
				if (!char.IsDigit(c))
				{
					goto IL_0156;
				}
				goto IL_0370;
				IL_019C:
				num3++;
				num = 43;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					goto IL_02E8;
				}
				goto IL_0416;
				IL_01CB:
				num3 = num2 + 1;
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
				{
					goto IL_01E6;
				}
				goto IL_0416;
				IL_02E8:
				if (num4 != null)
				{
					num9 |= values[num4.Value];
					goto IL_01CB;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto IL_0309;
				}
				goto IL_0416;
				IL_01E6:
				if (num3 > value.Length)
				{
					goto IL_05A3;
				}
				num = 52;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					goto IL_0208;
				}
				goto IL_0416;
				IL_0268:
				num9 = 0UL;
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
				{
					goto IL_0288;
				}
				goto IL_0416;
				IL_051F:
				if (obj == null)
				{
					goto IL_0268;
				}
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto Block_15;
				}
				goto IL_0416;
				IL_0213:
				Type underlyingType;
				try
				{
					obj = Convert.ChangeType(value, underlyingType, CultureInfo.InvariantCulture);
					int num10 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						switch (num10)
						{
						}
					}
					goto IL_051F;
				}
				catch (FormatException)
				{
					int num11 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						switch (num11)
						{
						}
					}
					goto IL_051F;
				}
				goto IL_0268;
				IL_0210:
				obj = null;
				goto IL_0213;
				IL_0208:
				value = value.Trim();
				goto IL_0210;
				IL_0288:
				num3 = num6;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_02D8;
				}
				goto IL_0416;
				IL_0309:
				num4 = EnumUtils.smethod_4(resolvedNames, value, 0, value.Length, StringComparison.OrdinalIgnoreCase);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_0416;
				}
				IL_0330:
				if (num4 == null)
				{
					goto IL_054A;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					break;
				}
				goto IL_0416;
				IL_0370:
				underlyingType = Enum.GetUnderlyingType(enumType);
				num = 36;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					break;
				}
				goto IL_0416;
				IL_03FC:
				num8 = 0;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					goto IL_02D8;
				}
				goto IL_0416;
			}
			goto IL_05AD;
			Block_15:
			goto IL_0571;
			goto IL_05AD;
			IL_052C:
			throw new ArgumentException(Class15.smethod_17(1176444566 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
			IL_054A:
			throw new ArgumentException(Class15.smethod_17(1176444500 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af).FormatWith(CultureInfo.InvariantCulture, value));
			IL_0571:
			if (disallowNumber)
			{
				goto IL_057D;
			}
			IL_0574:
			return Enum.ToObject(enumType, obj);
			IL_057D:
			throw new FormatException(Class15.smethod_17(2056999177 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48).FormatWith(CultureInfo.InvariantCulture, value));
			IL_05A3:
			return Enum.ToObject(enumType, num9);
			IL_05AD:
			return Enum.ToObject(enumType, values[num4.Value]);
			IL_05BE:
			throw new ArgumentException(Class15.smethod_17(1424563814 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf), Class15.smethod_17(314793973 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
			IL_05EE:
			return Enum.ToObject(enumType, values[num4.Value]);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0004A664 File Offset: 0x00048864
		private static int? smethod_3(string string_0, object object_0, object object_1, int int_0, int int_1, StringComparison stringComparison_0)
		{
			int? num = EnumUtils.smethod_4(object_1, string_0, int_0, int_1, stringComparison_0);
			if (num == null)
			{
				num = EnumUtils.smethod_4(object_0, string_0, int_0, int_1, stringComparison_0);
			}
			return num;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0004A698 File Offset: 0x00048898
		private static int? smethod_4(object object_0, string string_0, int int_0, int int_1, StringComparison stringComparison_0)
		{
			for (int i = 0; i < object_0.Length; i++)
			{
				if (object_0[i].Length == int_1 && string.Compare(object_0[i], 0, string_0, int_0, int_1, stringComparison_0) == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0004A6E0 File Offset: 0x000488E0
		static EnumUtils()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_002D;
				}
				IL_0030:
				switch (num)
				{
				case 1:
					IL_002D:
					goto IL_0003;
				case 2:
					continue;
				case 3:
					return;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				EnumUtils.threadSafeStore_0 = new ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo>(new Func<StructMultiKey<Type, NamingStrategy>, EnumInfo>(EnumUtils.smethod_0));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					break;
				}
				goto IL_0030;
			}
			EnumUtils.camelCaseNamingStrategy_0 = new CamelCaseNamingStrategy();
		}

		// Token: 0x0400041C RID: 1052
		[Nullable(new byte[] { 1, 0, 1, 2, 1 })]
		private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> threadSafeStore_0;

		// Token: 0x0400041D RID: 1053
		private static CamelCaseNamingStrategy camelCaseNamingStrategy_0;
	}
}
