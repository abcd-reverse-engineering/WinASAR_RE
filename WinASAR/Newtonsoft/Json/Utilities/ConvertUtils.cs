using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000089 RID: 137
	[NullableContext(1)]
	[Nullable(0)]
	internal static class ConvertUtils
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x00040560 File Offset: 0x0003E760
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			bool flag;
			return ConvertUtils.GetTypeCode(t, out flag);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00040578 File Offset: 0x0003E778
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			IL_00E6:
			PrimitiveTypeCode primitiveTypeCode;
			while (!ConvertUtils.dictionary_0.TryGetValue(t, out primitiveTypeCode))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					Type underlyingType;
					for (;;)
					{
						switch (num)
						{
						case 1:
							if (t.IsEnum())
							{
								goto IL_00FE;
							}
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
							{
								goto IL_005A;
							}
							continue;
						case 2:
							goto IL_00E6;
						case 3:
							return primitiveTypeCode;
						case 4:
							goto IL_0076;
						case 5:
							goto IL_013B;
						case 6:
							goto IL_0104;
						case 7:
							goto IL_005A;
						case 8:
							goto IL_00FE;
						case 9:
							goto IL_003A;
						case 10:
							goto IL_0020;
						case 11:
							goto IL_0113;
						}
						break;
						IL_0020:
						isEnum = false;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
						{
							break;
						}
						continue;
						IL_003A:
						if (!underlyingType.IsEnum())
						{
							goto IL_0020;
						}
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
						{
							goto Block_4;
						}
						continue;
						IL_005A:
						if (!ReflectionUtils.IsNullableType(t))
						{
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
							{
								goto IL_0020;
							}
							continue;
						}
						IL_0076:
						underlyingType = Nullable.GetUnderlyingType(t);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
						{
							goto IL_003A;
						}
					}
					return PrimitiveTypeCode.Object;
					Block_4:
					goto IL_0104;
					IL_00FE:
					isEnum = true;
					IL_0104:
					return ConvertUtils.GetTypeCode(Enum.GetUnderlyingType(t));
					IL_0113:
					Type type = typeof(Nullable<>).MakeGenericType(new Type[] { Enum.GetUnderlyingType(underlyingType) });
					isEnum = true;
					return ConvertUtils.GetTypeCode(type);
				}
				return PrimitiveTypeCode.Object;
			}
			IL_013B:
			isEnum = false;
			return primitiveTypeCode;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00003910 File Offset: 0x00001B10
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return ConvertUtils.typeInformation_0[(int)convertable.GetTypeCode()];
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000391E File Offset: 0x00001B1E
		public static bool IsConvertible(Type t)
		{
			return typeof(IConvertible).IsAssignableFrom(t);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00003930 File Offset: 0x00001B30
		public static TimeSpan ParseTimeSpan(string input)
		{
			return TimeSpan.Parse(input, CultureInfo.InvariantCulture);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000406C8 File Offset: 0x0003E8C8
		[NullableContext(2)]
		private static Func<object, object> smethod_0([Nullable(new byte[] { 0, 1, 1 })] StructMultiKey<Type, Type> t)
		{
			ConvertUtils.<>c__DisplayClass8_0 CS$<>8__locals1 = new ConvertUtils.<>c__DisplayClass8_0();
			Type value = t.Value1;
			Type value2 = t.Value2;
			MethodInfo methodInfo;
			if ((methodInfo = value2.GetMethod(Class15.smethod_17(552194544 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), new Type[] { value })) == null)
			{
				methodInfo = value2.GetMethod(Class15.smethod_17(486509348 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), new Type[] { value });
			}
			MethodInfo methodInfo2 = methodInfo;
			if (methodInfo2 == null)
			{
				return null;
			}
			CS$<>8__locals1.methodCall_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo2);
			return new Func<object, object>(CS$<>8__locals1.method_0);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00040760 File Offset: 0x0003E960
		internal static BigInteger ToBigInteger(object value)
		{
			IL_0204:
			while (!(value is BigInteger))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
				{
					goto IL_0170;
				}
				long num2;
				for (;;)
				{
					IL_018C:
					switch (num)
					{
					case 1:
						goto IL_0204;
					case 2:
						goto IL_0215;
					case 3:
						goto IL_0136;
					case 4:
						goto IL_0166;
					case 5:
						goto IL_0232;
					case 6:
						goto IL_0251;
					case 7:
						goto IL_0100;
					case 8:
					{
						BigInteger bigInteger;
						return bigInteger;
					}
					case 9:
						goto IL_024D;
					case 10:
						goto IL_02B9;
					case 11:
						goto IL_0223;
					case 12:
						goto IL_00DE;
					case 13:
						goto IL_0042;
					case 14:
						goto IL_0245;
					case 15:
						goto IL_00BC;
					case 16:
						goto IL_027C;
					case 17:
						goto IL_009A;
					case 18:
						goto IL_023D;
					case 19:
						goto IL_005F;
					case 20:
						goto IL_0284;
					case 21:
						goto IL_028C;
					case 22:
						goto IL_0294;
					case 23:
						goto IL_029C;
					case 24:
						num2 = (long)value;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
						{
							goto Block_2;
						}
						continue;
					case 25:
						goto IL_02A4;
					case 26:
						goto IL_02AC;
					}
					goto Block_17;
				}
				Block_2:
				continue;
				Block_17:
				goto IL_0170;
				IL_0215:
				return new BigInteger(num2);
				IL_0223:
				float num3;
				return new BigInteger(num3);
				IL_0294:
				double num4;
				return new BigInteger(num4);
				IL_02A4:
				decimal num5;
				return new BigInteger(num5);
				IL_0042:
				if (value is long)
				{
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_018C;
					}
				}
				else if (value is uint)
				{
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_0232;
					}
					goto IL_018C;
				}
				else
				{
					if (value is ulong)
					{
						goto IL_009A;
					}
					goto IL_0245;
				}
				IL_005F:
				if (!(value is int))
				{
					goto IL_0042;
				}
				goto IL_0284;
				IL_009A:
				ulong num6 = (ulong)value;
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_023D;
				}
				goto IL_018C;
				IL_00BC:
				num5 = (decimal)value;
				num = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
				{
					goto IL_024D;
				}
				goto IL_018C;
				IL_0100:
				if (value is float)
				{
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_00DE;
					}
					goto IL_018C;
				}
				else if (value is double)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_0136;
					}
					goto IL_018C;
				}
				else
				{
					if (!(value is decimal))
					{
						goto IL_005F;
					}
					goto IL_00BC;
				}
				IL_0166:
				string text;
				if (text == null)
				{
					goto IL_0100;
				}
				goto IL_02AC;
				IL_00DE:
				num3 = (float)value;
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_0251;
				}
				goto IL_018C;
				IL_0136:
				num4 = (double)value;
				num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					BigInteger bigInteger;
					return bigInteger;
				}
				goto IL_018C;
				IL_0170:
				text = value as string;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_0166;
				}
				goto IL_018C;
				IL_0232:
				uint num7 = (uint)value;
				goto IL_029C;
				IL_023D:
				return new BigInteger(num6);
				IL_0245:
				byte[] array = value as byte[];
				IL_024D:
				if (array != null)
				{
					goto IL_027C;
				}
				IL_0251:
				throw new InvalidCastException(Class15.smethod_17(1176442566 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af).FormatWith(CultureInfo.InvariantCulture, value.GetType()));
				IL_027C:
				return new BigInteger(array);
				IL_0284:
				int num8 = (int)value;
				IL_028C:
				return new BigInteger(num8);
				IL_029C:
				return new BigInteger(num7);
				IL_02AC:
				return BigInteger.Parse(text, CultureInfo.InvariantCulture);
			}
			IL_02B9:
			return (BigInteger)value;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00040A30 File Offset: 0x0003EC30
		public static object FromBigInteger(BigInteger i, Type targetType)
		{
			object obj;
			for (;;)
			{
				int num;
				if (targetType == typeof(decimal))
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto Block_6;
					}
				}
				else
				{
					if (targetType == typeof(double))
					{
						goto IL_01AB;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
					{
						goto IL_002D;
					}
				}
				IL_007C:
				switch (num)
				{
				case 1:
					goto IL_00DC;
				case 2:
					continue;
				case 3:
					IL_002D:
					if (targetType == typeof(float))
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
						{
							goto IL_007C;
						}
					}
					else
					{
						if (!(targetType == typeof(ulong)))
						{
							goto IL_00F6;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
						{
							goto IL_007C;
						}
						continue;
					}
					break;
				case 4:
					goto IL_0108;
				case 5:
				case 6:
					goto IL_011D;
				case 7:
					return obj;
				case 8:
					goto IL_01AB;
				case 9:
					goto IL_019F;
				}
				break;
			}
			goto IL_00E9;
			Block_6:
			IL_00DC:
			return (decimal)i;
			IL_00E9:
			return (float)i;
			IL_00F6:
			if (!(targetType == typeof(bool)))
			{
				goto IL_011D;
			}
			IL_0108:
			return i != 0L;
			IL_011D:
			try
			{
				obj = global::System.Convert.ChangeType((long)i, targetType, CultureInfo.InvariantCulture);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					switch (num2)
					{
					}
				}
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					switch (num3)
					{
					}
				}
				throw new InvalidOperationException(Class15.smethod_17(1829618185 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, targetType), ex);
			}
			return obj;
			IL_019F:
			return (ulong)i;
			IL_01AB:
			return (double)i;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00040C04 File Offset: 0x0003EE04
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			for (;;)
			{
				object obj;
				ConvertUtils.ConvertResult convertResult = ConvertUtils.smethod_1(initialValue, culture, targetType, out obj);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					goto IL_0003;
				}
				IL_002B:
				switch (num)
				{
				case 1:
					return obj;
				case 2:
					IL_0003:
					switch (convertResult)
					{
					case ConvertUtils.ConvertResult.Success:
						return obj;
					case ConvertUtils.ConvertResult.CannotConvertNull:
						goto IL_007F;
					case ConvertUtils.ConvertResult.NotInstantiableType:
						goto IL_00AB;
					case ConvertUtils.ConvertResult.NoValidConversion:
						goto IL_00E6;
					default:
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
						{
							goto IL_002B;
						}
						break;
					}
					break;
				case 3:
					continue;
				}
				break;
			}
			throw new InvalidOperationException(Class15.smethod_17(649970574 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
			IL_007F:
			throw new Exception(Class15.smethod_17(299941481 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
			IL_00AB:
			throw new ArgumentException(Class15.smethod_17(1678109818 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a).FormatWith(CultureInfo.InvariantCulture, targetType), Class15.smethod_17(1570971301 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
			IL_00E6:
			throw new InvalidOperationException(Class15.smethod_17(974434453 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f).FormatWith(CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00040D28 File Offset: 0x0003EF28
		private static bool TryConvert([Nullable(2)] object initialValue, object culture, Type targetType, [Nullable(2)] out object value)
		{
			bool flag;
			try
			{
				if (ConvertUtils.smethod_1(initialValue, culture, targetType, out value) == ConvertUtils.ConvertResult.Success)
				{
					goto IL_0069;
				}
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
				{
					goto IL_0081;
				}
				do
				{
					IL_0049:
					switch (num)
					{
					case 1:
						goto IL_0081;
					case 2:
						goto IL_007E;
					case 3:
					case 5:
						value = null;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
						{
							continue;
						}
						break;
					case 4:
						goto IL_0069;
					}
					flag = false;
					num = 1;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0);
				goto IL_0081;
				IL_0069:
				flag = true;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_0049;
				}
				IL_007E:
				IL_0081:;
			}
			catch
			{
				for (;;)
				{
					IL_00AE:
					value = null;
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 1:
							flag = false;
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_00AE;
						}
						goto Block_6;
					}
				}
				Block_6:;
			}
			return flag;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00040E10 File Offset: 0x0003F010
		private static ConvertUtils.ConvertResult smethod_1([Nullable(2)] object initialValue, object object_0, Type type_0, [Nullable(2)] out object value)
		{
			IL_0620:
			while (initialValue != null)
			{
				if (!ReflectionUtils.IsNullableType(type_0))
				{
					goto IL_05FE;
				}
				int num = 62;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					goto IL_0362;
				}
				Type type;
				string text;
				TypeConverter converter;
				for (;;)
				{
					IL_04AF:
					switch (num)
					{
					case 1:
						value = ConvertUtils.smethod_2(null, type, type_0);
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
						{
							goto Block_36;
						}
						continue;
					case 2:
						return ConvertUtils.ConvertResult.Success;
					case 3:
						return ConvertUtils.ConvertResult.Success;
					case 4:
						goto IL_0194;
					case 5:
						goto IL_019C;
					case 6:
						return ConvertUtils.ConvertResult.Success;
					case 7:
						goto IL_0210;
					case 8:
						goto IL_01F1;
					case 9:
						goto IL_0088;
					case 10:
						goto IL_0122;
					case 11:
						return ConvertUtils.ConvertResult.Success;
					case 12:
						return ConvertUtils.ConvertResult.Success;
					case 13:
						goto IL_014C;
					case 14:
						goto IL_011E;
					case 15:
						goto IL_068C;
					case 16:
						return ConvertUtils.ConvertResult.Success;
					case 17:
						goto IL_0036;
					case 18:
						return ConvertUtils.ConvertResult.NoValidConversion;
					case 19:
						goto IL_00B3;
					case 20:
						goto IL_063E;
					case 21:
						goto IL_0277;
					case 22:
					case 42:
						text = initialValue as string;
						num = 53;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto Block_35;
						}
						continue;
					case 23:
						goto IL_05FE;
					case 24:
						return ConvertUtils.ConvertResult.Success;
					case 25:
						goto IL_0228;
					case 26:
						return ConvertUtils.ConvertResult.Success;
					case 27:
						goto IL_0115;
					case 28:
						goto IL_0362;
					case 29:
						return ConvertUtils.ConvertResult.Success;
					case 30:
						return ConvertUtils.ConvertResult.Success;
					case 31:
						goto IL_027F;
					case 32:
						return ConvertUtils.ConvertResult.CannotConvertNull;
					case 33:
						goto IL_069A;
					case 34:
						goto IL_062B;
					case 35:
						goto IL_0242;
					case 36:
						goto IL_01C9;
					case 37:
						goto IL_0649;
					case 38:
						goto IL_0620;
					case 39:
						return ConvertUtils.ConvertResult.NoValidConversion;
					case 40:
						goto IL_02C2;
					case 41:
						goto IL_06CA;
					case 43:
						goto IL_03E2;
					case 44:
						return ConvertUtils.ConvertResult.Success;
					case 45:
						goto IL_038C;
					case 46:
						goto IL_0666;
					case 47:
					case 74:
						goto IL_02EF;
					case 48:
						goto IL_03FD;
					case 49:
						return ConvertUtils.ConvertResult.Success;
					case 50:
						goto IL_031A;
					case 51:
						return ConvertUtils.ConvertResult.Success;
					case 52:
						goto IL_015A;
					case 53:
						if (text == null)
						{
							goto IL_00E9;
						}
						num = 67;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
						{
							goto Block_34;
						}
						continue;
					case 54:
						goto IL_02D2;
					case 55:
						goto IL_06D9;
					case 56:
						goto IL_0230;
					case 57:
						return ConvertUtils.ConvertResult.Success;
					case 58:
						goto IL_017F;
					case 59:
						return ConvertUtils.ConvertResult.Success;
					case 60:
						goto IL_00C5;
					case 61:
						return ConvertUtils.ConvertResult.Success;
					case 62:
						goto IL_05F6;
					case 63:
						goto IL_067B;
					case 64:
						return ConvertUtils.ConvertResult.NotInstantiableType;
					case 65:
						if (converter == null)
						{
							goto IL_002B;
						}
						num = 48;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_0421;
						}
						continue;
					case 66:
						goto IL_0421;
					case 67:
						if (type_0 == typeof(Guid))
						{
							goto IL_069A;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
						{
							goto IL_0362;
						}
						continue;
					case 68:
						goto IL_06AA;
					case 69:
						goto IL_02CA;
					case 70:
						return ConvertUtils.ConvertResult.Success;
					case 71:
						goto IL_0093;
					case 72:
						goto IL_0162;
					case 73:
						goto IL_01B7;
					case 75:
						goto IL_030C;
					case 76:
						return ConvertUtils.ConvertResult.Success;
					case 77:
						goto IL_002B;
					case 78:
						goto IL_0705;
					}
					break;
					IL_0036:
					if (!ReflectionUtils.IsNullable(type_0))
					{
						goto IL_06FA;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
					{
						break;
					}
					continue;
					IL_002B:
					if (initialValue == DBNull.Value)
					{
						goto IL_0036;
					}
					if (!type_0.IsInterface())
					{
						goto IL_02C2;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
					{
						goto IL_02EF;
					}
					continue;
					IL_0421:
					if (!converter.CanConvertFrom(type))
					{
						goto IL_002B;
					}
					goto IL_067B;
					IL_02D2:
					value = null;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
					{
						goto Block_20;
					}
					continue;
					IL_02CA:
					if (!type_0.IsAbstract())
					{
						goto IL_02D2;
					}
					goto IL_02EF;
					IL_02C2:
					if (!type_0.IsGenericTypeDefinition())
					{
						goto IL_02CA;
					}
					IL_02EF:
					value = null;
					num = 64;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto Block_21;
					}
				}
				goto IL_0056;
				Block_35:
				goto IL_019C;
				Block_36:
				goto IL_0194;
				IL_05F6:
				type_0 = Nullable.GetUnderlyingType(type_0);
				goto IL_05FE;
				Block_20:
				return ConvertUtils.ConvertResult.NoValidConversion;
				Block_21:
				return ConvertUtils.ConvertResult.Success;
				Block_34:
				return ConvertUtils.ConvertResult.Success;
				IL_062B:
				if (initialValue is string)
				{
					goto IL_06AA;
				}
				if (!ConvertUtils.IsInteger(initialValue))
				{
					goto IL_06E8;
				}
				IL_063E:
				value = Enum.ToObject(type_0, initialValue);
				return ConvertUtils.ConvertResult.Success;
				IL_0649:
				throw new ArgumentNullException(Class15.smethod_17(1424563174 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf));
				IL_0666:
				value = ConvertUtils.ParseTimeSpan(text);
				return ConvertUtils.ConvertResult.Success;
				IL_067B:
				value = converter.ConvertFrom(null, object_0, initialValue);
				return ConvertUtils.ConvertResult.Success;
				IL_069A:
				value = new Guid(text);
				return ConvertUtils.ConvertResult.Success;
				IL_06AA:
				value = Enum.Parse(type_0, initialValue.ToString(), true);
				return ConvertUtils.ConvertResult.Success;
				IL_06FA:
				value = null;
				return ConvertUtils.ConvertResult.CannotConvertNull;
				IL_0056:
				if (type_0 == type)
				{
					goto IL_0210;
				}
				if (!ConvertUtils.IsConvertible(initialValue.GetType()))
				{
					goto IL_015A;
				}
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
				{
					goto IL_0088;
				}
				goto IL_04AF;
				IL_0093:
				if (!type_0.IsEnum())
				{
					goto IL_06E8;
				}
				num = 34;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_00B3;
				}
				goto IL_04AF;
				IL_0088:
				if (ConvertUtils.IsConvertible(type_0))
				{
					goto IL_0093;
				}
				goto IL_015A;
				IL_00C5:
				value = Type.GetType(text, true);
				num = 47;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					return ConvertUtils.ConvertResult.Success;
				}
				goto IL_04AF;
				IL_00B3:
				if (typeof(Type).IsAssignableFrom(type_0))
				{
					goto IL_00C5;
				}
				goto IL_00E9;
				IL_03E2:
				if (!(type_0 == typeof(Version)))
				{
					goto IL_00B3;
				}
				goto IL_030C;
				IL_00E9:
				if (type_0 == typeof(BigInteger))
				{
					goto IL_06D9;
				}
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					goto IL_014C;
				}
				goto IL_04AF;
				IL_012F:
				converter = TypeDescriptor.GetConverter(type_0);
				num = 65;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_014C;
				}
				goto IL_04AF;
				IL_0122:
				TypeConverter converter2;
				if (!converter2.CanConvertTo(type_0))
				{
					goto IL_012F;
				}
				goto IL_06CA;
				IL_011E:
				if (converter2 != null)
				{
					goto IL_0122;
				}
				goto IL_012F;
				IL_0115:
				converter2 = TypeDescriptor.GetConverter(type);
				goto IL_011E;
				IL_014C:
				if (!(initialValue is BigInteger))
				{
					goto IL_0115;
				}
				goto IL_0277;
				IL_0162:
				DateTime dateTime = (DateTime)initialValue;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
				{
					goto IL_017F;
				}
				goto IL_04AF;
				IL_015A:
				if (initialValue is DateTime)
				{
					goto IL_0162;
				}
				goto IL_0194;
				IL_019C:
				byte[] array;
				if (array != null)
				{
					goto IL_01B7;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_01F1;
				}
				goto IL_04AF;
				IL_0194:
				array = initialValue as byte[];
				goto IL_019C;
				IL_017F:
				if (!(type_0 == typeof(DateTimeOffset)))
				{
					goto IL_0194;
				}
				goto IL_0705;
				IL_01C9:
				value = new Guid(array);
				num = 45;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					return ConvertUtils.ConvertResult.Success;
				}
				goto IL_04AF;
				IL_01B7:
				if (type_0 == typeof(Guid))
				{
					goto IL_01C9;
				}
				IL_01F1:
				if (initialValue is Guid)
				{
					goto IL_0228;
				}
				num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					goto IL_0277;
				}
				goto IL_04AF;
				IL_0210:
				value = initialValue;
				num = 44;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_0228;
				}
				goto IL_04AF;
				IL_0242:
				Guid guid;
				value = guid.ToByteArray();
				num = 30;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_0210;
				}
				goto IL_04AF;
				IL_0230:
				if (type_0 == typeof(byte[]))
				{
					goto IL_0242;
				}
				num = 42;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_0277;
				}
				goto IL_04AF;
				IL_0228:
				guid = (Guid)initialValue;
				goto IL_0230;
				IL_027F:
				BigInteger bigInteger;
				value = ConvertUtils.FromBigInteger(bigInteger, type_0);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
				{
					return ConvertUtils.ConvertResult.Success;
				}
				goto IL_04AF;
				IL_0277:
				bigInteger = (BigInteger)initialValue;
				goto IL_027F;
				IL_031A:
				Version version;
				value = version;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					return ConvertUtils.ConvertResult.Success;
				}
				goto IL_04AF;
				IL_030C:
				if (ConvertUtils.VersionTryParse(text, out version))
				{
					goto IL_031A;
				}
				value = null;
				return ConvertUtils.ConvertResult.NoValidConversion;
				IL_0362:
				if (type_0 == typeof(Uri))
				{
					goto IL_03FD;
				}
				num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_04AF;
				}
				IL_038C:
				if (type_0 == typeof(TimeSpan))
				{
					num = 46;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						return ConvertUtils.ConvertResult.Success;
					}
					goto IL_04AF;
				}
				else
				{
					if (type_0 == typeof(byte[]))
					{
						goto IL_068C;
					}
					num = 34;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						goto IL_03E2;
					}
					goto IL_04AF;
				}
				IL_03FD:
				value = new Uri(text, UriKind.RelativeOrAbsolute);
				num = 46;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					return ConvertUtils.ConvertResult.Success;
				}
				goto IL_04AF;
				IL_05FE:
				type = initialValue.GetType();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_0056;
				}
				goto IL_04AF;
				IL_068C:
				value = global::System.Convert.FromBase64String(text);
				return ConvertUtils.ConvertResult.Success;
				IL_06CA:
				value = converter2.ConvertTo(null, object_0, initialValue, type_0);
				return ConvertUtils.ConvertResult.Success;
				IL_06D9:
				value = ConvertUtils.ToBigInteger(initialValue);
				return ConvertUtils.ConvertResult.Success;
				IL_06E8:
				value = global::System.Convert.ChangeType(initialValue, type_0, object_0);
				return ConvertUtils.ConvertResult.Success;
				IL_0705:
				value = new DateTimeOffset(dateTime);
				return ConvertUtils.ConvertResult.Success;
			}
			goto IL_0649;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00041534 File Offset: 0x0003F734
		[return: Nullable(2)]
		public static object ConvertOrCast([Nullable(2)] object initialValue, CultureInfo culture, Type targetType)
		{
			for (;;)
			{
				int num;
				if (targetType == typeof(object))
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						goto Block_7;
					}
				}
				else
				{
					if (initialValue != null)
					{
						goto IL_001A;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_003D;
					}
				}
				IL_0048:
				object obj;
				switch (num)
				{
				case 1:
					IL_003D:
					if (ReflectionUtils.IsNullable(targetType))
					{
						goto Block_5;
					}
					goto IL_001A;
				case 2:
					return initialValue;
				case 3:
					continue;
				case 4:
					goto IL_00A8;
				case 5:
					return obj;
				}
				break;
				IL_001A:
				if (ConvertUtils.TryConvert(initialValue, culture, targetType, out obj))
				{
					return obj;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					break;
				}
				goto IL_0048;
			}
			goto IL_0098;
			Block_5:
			goto IL_00A8;
			goto IL_0098;
			Block_7:
			return initialValue;
			IL_0098:
			return ConvertUtils.smethod_2(initialValue, ReflectionUtils.GetObjectType(initialValue), targetType);
			IL_00A8:
			return null;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000415F0 File Offset: 0x0003F7F0
		[return: Nullable(2)]
		private static object smethod_2([Nullable(2)] object value, Type type_0, Type type_1)
		{
			Func<object, object> func;
			for (;;)
			{
				int num;
				if (value != null)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						goto IL_0073;
					}
				}
				else
				{
					if (ReflectionUtils.IsNullable(type_1))
					{
						goto IL_011C;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						break;
					}
				}
				IL_007D:
				Type type;
				switch (num)
				{
				case 0:
					goto IL_005B;
				case 1:
					goto IL_00C6;
				case 2:
					IL_0073:
					type = value.GetType();
					break;
				case 3:
					continue;
				case 4:
					break;
				case 5:
					goto IL_00CF;
				case 6:
					goto IL_011C;
				case 7:
					return value;
				default:
					goto IL_005B;
				}
				if (type_1.IsAssignableFrom(type))
				{
					return value;
				}
				func = ConvertUtils.threadSafeStore_0.Get(new StructMultiKey<Type, Type>(type, type_1));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
				{
					goto IL_007D;
				}
				IL_005B:
				if (func == null)
				{
					break;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
				{
					goto Block_5;
				}
				goto IL_007D;
			}
			goto IL_00CF;
			Block_5:
			IL_00C6:
			return func(value);
			IL_00CF:
			string text = Class15.smethod_17(642152986 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			string text2;
			if (type_0 != null)
			{
				if ((text2 = type_0.ToString()) != null)
				{
					goto IL_010E;
				}
			}
			text2 = Class15.smethod_17(926364431 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296);
			IL_010E:
			throw new ArgumentException(text.FormatWith(invariantCulture, text2, type_1));
			IL_011C:
			return null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000393D File Offset: 0x00001B3D
		public static bool VersionTryParse(string input, [Nullable(2)] [NotNullWhen(true)] out Version result)
		{
			return Version.TryParse(input, out result);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0004171C File Offset: 0x0003F91C
		public static bool IsInteger(object value)
		{
			PrimitiveTypeCode typeCode;
			for (;;)
			{
				typeCode = ConvertUtils.GetTypeCode(value.GetType());
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0038;
					case 2:
						continue;
					case 3:
						return false;
					}
					break;
				}
				goto IL_0037;
			}
			return true;
			IL_0037:
			IL_0038:
			switch (typeCode)
			{
			case PrimitiveTypeCode.SByte:
			case PrimitiveTypeCode.Int16:
			case PrimitiveTypeCode.UInt16:
			case PrimitiveTypeCode.Int32:
			case PrimitiveTypeCode.Byte:
			case PrimitiveTypeCode.UInt32:
			case PrimitiveTypeCode.Int64:
			case PrimitiveTypeCode.UInt64:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000417AC File Offset: 0x0003F9AC
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			for (;;)
			{
				IL_02E4:
				value = 0;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0047;
				}
				bool flag;
				int num2;
				int num3;
				int num4;
				int num5;
				for (;;)
				{
					IL_0229:
					switch (num)
					{
					case 1:
						goto IL_00FD;
					case 2:
						return ParseResult.Invalid;
					case 3:
						goto IL_0125;
					case 4:
						goto IL_01F3;
					case 5:
						goto IL_006B;
					case 6:
						if (!flag)
						{
							goto IL_01C7;
						}
						num = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
						{
							goto Block_20;
						}
						continue;
					case 7:
					case 36:
						goto IL_00CE;
					case 8:
					case 17:
						goto IL_00C8;
					case 9:
						return ParseResult.Success;
					case 10:
						goto IL_0178;
					case 11:
						goto IL_0170;
					case 12:
						return ParseResult.Overflow;
					case 13:
						goto IL_011E;
					case 14:
						return ParseResult.Invalid;
					case 15:
						if (num2 <= value)
						{
							goto Block_18;
						}
						goto IL_01BA;
					case 16:
						return ParseResult.Invalid;
					case 18:
					case 43:
						return ParseResult.Invalid;
					case 19:
						if (length != 1)
						{
							goto IL_01FE;
						}
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
						{
							goto IL_01F3;
						}
						continue;
					case 20:
					case 31:
						goto IL_003B;
					case 21:
						goto IL_00A9;
					case 22:
						goto IL_00D7;
					case 23:
						goto IL_0024;
					case 24:
						goto IL_00DF;
					case 25:
						goto IL_01CE;
					case 26:
						goto IL_01C7;
					case 27:
						goto IL_019D;
					case 28:
						goto IL_01C2;
					case 29:
						goto IL_01BA;
					case 30:
						return ParseResult.Overflow;
					case 32:
					case 34:
						goto IL_0180;
					case 33:
						return ParseResult.Invalid;
					case 35:
						goto IL_0089;
					case 37:
						goto IL_0047;
					case 38:
						goto IL_02E4;
					case 39:
						return ParseResult.Overflow;
					case 40:
						goto IL_002C;
					case 41:
					case 42:
						goto IL_0006;
					}
					goto Block_21;
					IL_0180:
					if (num3 < num4)
					{
						goto IL_019D;
					}
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						goto Block_14;
					}
					continue;
					IL_01BA:
					num3++;
					goto IL_0180;
					IL_019D:
					num5 = (int)(chars[num3] - '0');
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto Block_15;
					}
				}
				IL_01C7:
				num4 = start + length;
				goto IL_0170;
				IL_01C2:
				length--;
				goto IL_01C7;
				IL_01FE:
				start++;
				goto IL_01C2;
				Block_14:
				goto IL_0170;
				IL_01F3:
				num3++;
				goto IL_00C8;
				Block_20:
				goto IL_01F3;
				Block_18:
				value = num2;
				goto IL_01F3;
				IL_01CE:
				if (chars[start] - '0' > '\u0002')
				{
					goto IL_0178;
				}
				goto IL_00C5;
				Block_21:
				Block_15:
				goto IL_014E;
				IL_0006:
				int num7;
				int num6 = (int)(chars[num7] - '0');
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_0024;
				}
				goto IL_0229;
				IL_003B:
				if (num7 < num4)
				{
					goto IL_0006;
				}
				return ParseResult.Overflow;
				IL_002C:
				if (num6 <= 9)
				{
					num7++;
					goto IL_003B;
				}
				return ParseResult.Invalid;
				IL_0024:
				if (num6 >= 0)
				{
					goto IL_002C;
				}
				return ParseResult.Invalid;
				IL_0047:
				if (length == 0)
				{
					return ParseResult.Invalid;
				}
				flag = chars[start] == '-';
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
				{
					goto IL_0229;
				}
				IL_006B:
				if (num5 > 9)
				{
					return ParseResult.Invalid;
				}
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_0229;
				}
				IL_0089:
				num3++;
				num = 34;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto IL_0170;
				}
				goto IL_0229;
				IL_00A9:
				if (length != 10)
				{
					goto IL_00C5;
				}
				num = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
				{
					goto IL_00CE;
				}
				goto IL_0229;
				IL_0170:
				if (length > 10)
				{
					goto IL_0178;
				}
				goto IL_00A9;
				IL_00DF:
				if (num5 > 9)
				{
					return ParseResult.Invalid;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_00FD;
				}
				goto IL_0229;
				IL_00D7:
				if (num5 >= 0)
				{
					goto IL_00DF;
				}
				return ParseResult.Invalid;
				IL_00CE:
				num5 = (int)(chars[num3] - '0');
				goto IL_00D7;
				IL_00C8:
				if (num3 < num4)
				{
					goto IL_00CE;
				}
				goto IL_011E;
				IL_00C5:
				num3 = start;
				goto IL_00C8;
				IL_00FD:
				num2 = 10 * value - num5;
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_014E;
				}
				goto IL_0229;
				IL_0125:
				if (value == -2147483648)
				{
					break;
				}
				value = -value;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_014E;
				}
				goto IL_0229;
				IL_011E:
				if (!flag)
				{
					goto IL_0125;
				}
				return ParseResult.Success;
				IL_014E:
				if (num5 < 0)
				{
					return ParseResult.Invalid;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_006B;
				}
				goto IL_0229;
				IL_0178:
				num7 = start;
				goto IL_003B;
			}
			return ParseResult.Overflow;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00041ACC File Offset: 0x0003FCCC
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			bool flag;
			for (;;)
			{
				IL_029B:
				value = 0L;
				int num = 33;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
				{
					goto IL_016F;
				}
				int num4;
				int num5;
				for (;;)
				{
					IL_01F0:
					switch (num)
					{
					case 0:
						goto IL_0024;
					case 1:
					case 23:
						goto IL_017E;
					case 2:
						goto IL_00F4;
					case 3:
						return ParseResult.Overflow;
					case 4:
						goto IL_01B2;
					case 5:
						goto IL_0148;
					case 6:
						return ParseResult.Overflow;
					case 7:
						goto IL_0199;
					case 8:
						length--;
						goto IL_0072;
					case 9:
						goto IL_016F;
					case 10:
					case 35:
						goto IL_0038;
					case 11:
					case 26:
						goto IL_00CE;
					case 12:
						goto IL_012E;
					case 13:
						goto IL_00AA;
					case 14:
						return ParseResult.Overflow;
					case 15:
						goto IL_0094;
					case 16:
						return ParseResult.Invalid;
					case 17:
						return ParseResult.Invalid;
					case 18:
						goto IL_009C;
					case 19:
					case 27:
						return ParseResult.Invalid;
					case 20:
						goto IL_002C;
					case 21:
						goto IL_00A5;
					case 22:
						return ParseResult.Invalid;
					case 24:
						goto IL_02C9;
					case 25:
						goto IL_013F;
					case 28:
						return ParseResult.Invalid;
					case 29:
						goto IL_0137;
					case 30:
						return ParseResult.Success;
					case 31:
						goto IL_0077;
					case 32:
						goto IL_007C;
					case 33:
						if (length != 0)
						{
							flag = chars[start] == '-';
							goto IL_0199;
						}
						return ParseResult.Invalid;
					case 34:
						goto IL_029B;
					case 36:
						goto IL_0111;
					case 37:
						goto IL_02C5;
					case 38:
						goto IL_0072;
					case 39:
						break;
					default:
						goto IL_0024;
					}
					IL_0006:
					int num3;
					int num2 = (int)(chars[num3] - '0');
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto IL_0024;
					}
					continue;
					IL_0038:
					if (num3 < num4)
					{
						goto IL_0006;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
					{
						goto Block_3;
					}
					continue;
					IL_002C:
					if (num2 <= 9)
					{
						num3++;
						goto IL_0038;
					}
					num = 28;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto Block_4;
					}
					continue;
					IL_0024:
					if (num2 >= 0)
					{
						goto IL_002C;
					}
					return ParseResult.Invalid;
					IL_007C:
					num5 = start;
					num = 23;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
					{
						goto IL_0094;
					}
					continue;
					IL_0077:
					if (length <= 19)
					{
						goto IL_007C;
					}
					goto IL_00F4;
					IL_0072:
					num4 = start + length;
					goto IL_0077;
					IL_0199:
					if (!flag)
					{
						goto IL_0072;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_01B2;
					}
					continue;
					IL_00F4:
					num3 = start;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto IL_0038;
					}
					continue;
					IL_01B2:
					if (length == 1)
					{
						num = 17;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
						{
							return ParseResult.Invalid;
						}
					}
					else
					{
						start++;
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
						{
							break;
						}
					}
				}
				goto IL_017E;
				IL_00AA:
				int num6;
				if (num6 > 9)
				{
					return ParseResult.Invalid;
				}
				num5++;
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto IL_00CE;
				}
				goto IL_01F0;
				IL_00A5:
				if (num6 >= 0)
				{
					goto IL_00AA;
				}
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto Block_7;
				}
				goto IL_01F0;
				IL_009C:
				num6 = (int)(chars[num5] - '0');
				goto IL_00A5;
				IL_00CE:
				if (num5 >= num4)
				{
					goto Block_6;
				}
				goto IL_009C;
				IL_0094:
				num5++;
				goto IL_00CE;
				IL_016F:
				long num7;
				if (num7 > value)
				{
					goto IL_0094;
				}
				value = num7;
				IL_0111:
				num5++;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto IL_017E;
				}
				goto IL_01F0;
				IL_0148:
				num7 = 10L * value - (long)num6;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_016F;
				}
				goto IL_01F0;
				IL_013F:
				if (num6 <= 9)
				{
					goto IL_0148;
				}
				return ParseResult.Invalid;
				IL_0137:
				if (num6 >= 0)
				{
					goto IL_013F;
				}
				return ParseResult.Invalid;
				IL_012E:
				num6 = (int)(chars[num5] - '0');
				goto IL_0137;
				IL_017E:
				if (num5 >= num4)
				{
					goto Block_11;
				}
				goto IL_012E;
			}
			Block_3:
			return ParseResult.Overflow;
			Block_4:
			return ParseResult.Invalid;
			Block_6:
			return ParseResult.Overflow;
			Block_7:
			return ParseResult.Invalid;
			Block_11:
			IL_02C5:
			if (flag)
			{
				return ParseResult.Success;
			}
			IL_02C9:
			if (value != -9223372036854775808L)
			{
				value = -value;
				return ParseResult.Success;
			}
			return ParseResult.Overflow;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00041DC4 File Offset: 0x0003FFC4
		public static ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value)
		{
			bool flag;
			int num6;
			for (;;)
			{
				IL_0A77:
				value = 0m;
				IL_0A6E:
				while (length != 0)
				{
					flag = chars[start] == '-';
					int num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto IL_07F2;
					}
					int? num2;
					int num3;
					char? c2;
					char? c;
					char c3;
					int? num5;
					int num7;
					int num8;
					int num9;
					int num10;
					int num11;
					for (;;)
					{
						IL_082B:
						bool flag2;
						switch (num)
						{
						case 1:
						case 83:
							goto IL_008E;
						case 2:
							goto IL_075C;
						case 3:
							goto IL_03D6;
						case 4:
						case 114:
							return ParseResult.Invalid;
						case 5:
							goto IL_0206;
						case 6:
							goto IL_051D;
						case 7:
							if ((num2.GetValueOrDefault() > num3) & (num2 != null))
							{
								return ParseResult.Overflow;
							}
							num = 124;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
							{
								continue;
							}
							goto IL_0A80;
						case 8:
							goto IL_055B;
						case 9:
							goto IL_04AA;
						case 10:
							goto IL_03A5;
						case 11:
							goto IL_043E;
						case 12:
						case 25:
						case 49:
						case 99:
						case 104:
							goto IL_0B26;
						case 13:
							return ParseResult.Invalid;
						case 14:
							goto IL_03F5;
						case 15:
							goto IL_0591;
						case 16:
							return ParseResult.Invalid;
						case 17:
							goto IL_0442;
						case 18:
							goto IL_07F2;
						case 19:
							goto IL_005A;
						case 20:
							goto IL_06B7;
						case 21:
							goto IL_0086;
						case 22:
						case 23:
							goto IL_04FE;
						case 24:
							goto IL_0789;
						case 26:
							goto IL_0264;
						case 27:
							goto IL_07E6;
						case 28:
							goto IL_00BD;
						case 29:
						case 86:
							goto IL_0154;
						case 30:
							goto IL_0209;
						case 31:
							goto IL_03C3;
						case 32:
							goto IL_06BD;
						case 33:
							goto IL_0A86;
						case 34:
							goto IL_010C;
						case 35:
							goto IL_0493;
						case 36:
							goto IL_0783;
						case 37:
						case 135:
							goto IL_016E;
						case 38:
							goto IL_03DA;
						case 39:
							goto IL_06F2;
						case 40:
						case 105:
						case 111:
							goto IL_0060;
						case 41:
							goto IL_0A6E;
						case 42:
							goto IL_0A77;
						case 43:
							return ParseResult.Invalid;
						case 44:
							goto IL_022E;
						case 45:
							return ParseResult.Invalid;
						case 46:
						case 72:
						case 81:
						case 97:
						case 103:
							goto IL_0189;
						case 47:
							goto IL_015C;
						case 48:
							goto IL_0097;
						case 50:
							goto IL_0381;
						case 51:
							goto IL_0664;
						case 52:
							return ParseResult.Overflow;
						case 53:
							goto IL_049C;
						case 54:
							goto IL_0121;
						case 55:
							goto IL_0B2A;
						case 56:
						case 140:
							c = c2;
							num = 34;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
							{
								goto IL_0493;
							}
							continue;
						case 57:
							return ParseResult.Invalid;
						case 58:
						case 102:
						case 124:
							goto IL_0B0E;
						case 59:
							goto IL_077D;
						case 60:
						case 119:
							goto IL_0361;
						case 61:
							goto IL_0108;
						case 62:
							goto IL_039C;
						case 63:
							goto IL_06B1;
						case 64:
							return ParseResult.Success;
						case 65:
						case 77:
							goto IL_01B6;
						case 66:
							goto IL_04B2;
						case 67:
						case 85:
							return ParseResult.Success;
						case 68:
							goto IL_0227;
						case 69:
							goto IL_052B;
						case 70:
							return ParseResult.Invalid;
						case 71:
							goto IL_0310;
						case 73:
							goto IL_00C6;
						case 74:
							goto IL_041B;
						case 75:
							IL_04CB:
							num3 = 53;
							goto IL_04CF;
						case 76:
							goto IL_0223;
						case 78:
							goto IL_0534;
						case 79:
							goto IL_069F;
						case 80:
							goto IL_0165;
						case 82:
							goto IL_06C9;
						case 84:
						case 116:
							if (c3 >= '0')
							{
								goto IL_0737;
							}
							return ParseResult.Invalid;
						case 87:
							goto IL_07B0;
						case 88:
							return ParseResult.Overflow;
						case 89:
							goto IL_03D0;
						case 90:
							if (c3 != '.')
							{
								goto IL_0684;
							}
							goto IL_05CE;
						case 91:
							goto IL_012A;
						case 92:
							goto IL_0041;
						case 93:
							goto IL_041F;
						case 94:
							return ParseResult.Invalid;
						case 95:
							goto IL_025C;
						case 96:
							goto IL_00B3;
						case 98:
							goto IL_007E;
						case 100:
							goto IL_0737;
						case 101:
							goto IL_06E9;
						case 106:
							goto IL_07A7;
						case 107:
							goto IL_01EC;
						case 108:
							goto IL_07C8;
						case 109:
							goto IL_06C0;
						case 110:
							goto IL_01DA;
						case 112:
							goto IL_022B;
						case 113:
							goto IL_01A9;
						case 115:
							goto IL_0762;
						case 117:
							goto IL_04E7;
						case 118:
							return ParseResult.Invalid;
						case 120:
							goto IL_0684;
						case 121:
							goto IL_0428;
						case 122:
							return ParseResult.Overflow;
						case 123:
							goto IL_04CF;
						case 125:
							return ParseResult.Invalid;
						case 126:
							goto IL_0642;
						case 127:
							flag2 = true;
							goto IL_0664;
						case 128:
							goto IL_0239;
						case 129:
							goto IL_02E1;
						case 130:
							goto IL_0244;
						case 131:
							return ParseResult.Invalid;
						case 132:
							if (flag2)
							{
								goto IL_0642;
							}
							goto IL_0189;
						case 133:
							goto IL_04ED;
						case 134:
							goto IL_05CE;
						case 136:
							goto IL_0AC8;
						case 137:
							goto IL_0AE8;
						case 138:
							goto IL_0436;
						case 139:
							goto IL_01BE;
						case 141:
							goto IL_0029;
						}
						goto Block_48;
						IL_04B4:
						int? num4;
						num2 = num4;
						num = 57;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
						{
							goto IL_04CB;
						}
						continue;
						IL_04B2:
						num4 = num5;
						goto IL_04B4;
						IL_04AA:
						num5 = null;
						goto IL_04B2;
						IL_0493:
						if (c == null)
						{
							goto IL_04AA;
						}
						IL_049C:
						num4 = new int?((int)c.GetValueOrDefault());
						goto IL_04B4;
						IL_04FE:
						if (num6 < 0)
						{
							goto IL_051D;
						}
						num = 104;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							goto Block_19;
						}
						continue;
						IL_04ED:
						value += 1m;
						goto IL_04FE;
						IL_04E7:
						if (num6 >= -28)
						{
							goto IL_04ED;
						}
						goto IL_04FE;
						IL_04CF:
						if ((num2.GetValueOrDefault() >= num3) & (num2 != null))
						{
							goto IL_04E7;
						}
						goto IL_04FE;
						IL_055B:
						value *= new decimal(1, 0, 0, false, (byte)(-num6 - 28));
						num = 49;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
						{
							goto IL_0591;
						}
						continue;
						IL_0534:
						value /= 10000000000000000000000000000m;
						goto IL_055B;
						IL_052B:
						if (num6 < -28)
						{
							goto IL_0534;
						}
						goto IL_0AC8;
						IL_051D:
						if (num7 + num6 + 28 > 0)
						{
							goto IL_052B;
						}
						goto IL_0AE8;
						IL_05CE:
						if (num8 == start)
						{
							goto Block_23;
						}
						if (num8 + 1 == num9)
						{
							num = 25;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
							{
								goto Block_25;
							}
							continue;
						}
						else if (num10 != num9)
						{
							num = 43;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							num10 = num8 + 1;
							num = 41;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
							{
								goto Block_28;
							}
							continue;
						}
						IL_0789:
						if (c3 == '.')
						{
							goto IL_05CE;
						}
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
						{
							goto IL_07A7;
						}
						continue;
						IL_0783:
						c3 = chars[num8];
						goto IL_0789;
						IL_077D:
						if (num8 != num9)
						{
							goto IL_0783;
						}
						goto IL_07BF;
						IL_0642:
						num6 = -num6;
						num = 72;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
						{
							goto Block_29;
						}
						continue;
						IL_0664:
						num8++;
						num = 40;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
						{
							goto Block_30;
						}
						continue;
						IL_06C9:
						if (c3 != '-')
						{
							goto IL_0060;
						}
						num = 127;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
						{
							goto IL_0684;
						}
						continue;
						IL_06C0:
						if (c3 != '+')
						{
							goto IL_06C9;
						}
						goto IL_005A;
						IL_06BD:
						flag2 = false;
						goto IL_06C0;
						IL_06B7:
						c3 = chars[num8];
						goto IL_06BD;
						IL_06B1:
						num11 = num8 - 1;
						goto IL_06B7;
						IL_069F:
						if (num8 == num9)
						{
							goto Block_33;
						}
						if (num10 < num9)
						{
							goto IL_06B1;
						}
						goto IL_06B7;
						IL_06F2:
						if (num8 == start)
						{
							num = 13;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (num8 == num10)
							{
								goto Block_32;
							}
							num8++;
							goto IL_069F;
						}
						IL_07B0:
						if (c3 != 'E')
						{
							goto Block_43;
						}
						goto IL_06F2;
						IL_07A7:
						if (c3 != 'e')
						{
							goto IL_07B0;
						}
						goto IL_06F2;
						IL_06E9:
						if (c3 == 'e')
						{
							goto IL_06F2;
						}
						num = 84;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
						{
							goto Block_38;
						}
						continue;
						IL_0684:
						if (c3 != 'E')
						{
							goto IL_06E9;
						}
						goto IL_06F2;
						IL_0737:
						if (c3 > '9')
						{
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							if (num8 == start)
							{
								goto IL_075C;
							}
							goto IL_07BF;
						}
						IL_0762:
						num8++;
						num = 28;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
						{
							goto IL_077D;
						}
						continue;
						IL_075C:
						if (c3 == '0')
						{
							goto IL_0762;
						}
						goto IL_07BF;
					}
					IL_07C8:
					if (num7 == 28)
					{
						goto IL_0108;
					}
					goto IL_0121;
					IL_07BF:
					if (num7 < 29)
					{
						goto IL_07C8;
					}
					goto IL_015C;
					Block_29:
					goto IL_0060;
					IL_07E6:
					bool? flag4;
					bool flag3 = flag4.GetValueOrDefault();
					goto IL_011F;
					Block_28:
					goto IL_0189;
					Block_19:
					goto IL_041F;
					Block_48:
					goto IL_045B;
					Block_38:
					goto IL_005A;
					IL_0041:
					bool? flag5;
					flag4 = flag5;
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						goto IL_005A;
					}
					goto IL_082B;
					IL_0029:
					ulong num12;
					ulong num13;
					flag5 = new bool?(num12 > 7922816251426433759UL || (num12 == 7922816251426433759UL && (num13 > 354395033UL || (num13 == 354395033UL && c3 > '5'))));
					goto IL_0041;
					IL_010C:
					bool? flag6;
					if (flag6 != null)
					{
						flag3 = flag6.GetValueOrDefault();
						goto IL_011F;
					}
					goto IL_0029;
					IL_0108:
					flag6 = flag5;
					goto IL_010C;
					IL_0060:
					if (num8 < num9)
					{
						goto IL_0381;
					}
					num = 132;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
					{
						goto IL_007E;
					}
					goto IL_082B;
					IL_005A:
					num8++;
					goto IL_0060;
					IL_0097:
					int num14;
					num6 += num14;
					num = 56;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_00B3;
					}
					goto IL_082B;
					IL_008E:
					if (num8 >= num9)
					{
						goto IL_0097;
					}
					goto IL_0361;
					IL_0086:
					flag5 = null;
					goto IL_008E;
					IL_007E:
					c2 = null;
					goto IL_0086;
					IL_025C:
					num14 = 0;
					goto IL_007E;
					IL_00C6:
					value = num12 / new decimal(1, 0, 0, false, (byte)(num7 - 19)) + num13;
					num = 77;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_0108;
					}
					goto IL_082B;
					IL_00BD:
					if (num7 > 19)
					{
						goto IL_00C6;
					}
					goto IL_01A9;
					IL_00B3:
					num6 -= num11 - num10;
					goto IL_00BD;
					IL_012A:
					num12 = num12 * 10UL + (ulong)((long)(c3 - '0'));
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
					{
						goto IL_0154;
					}
					goto IL_082B;
					IL_0121:
					if (num7 < 19)
					{
						goto IL_012A;
					}
					goto IL_02E1;
					IL_011F:
					if (!flag3)
					{
						goto IL_0121;
					}
					goto IL_015C;
					IL_016E:
					num14++;
					num = 103;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_0189;
					}
					goto IL_082B;
					IL_0165:
					c2 = new char?(c3);
					goto IL_016E;
					IL_015C:
					if (c2 == null)
					{
						goto IL_0165;
					}
					goto IL_016E;
					IL_0189:
					num8++;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_008E;
					}
					goto IL_082B;
					IL_0154:
					num7++;
					goto IL_0189;
					IL_01BE:
					num7 += num6;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto IL_01DA;
					}
					goto IL_082B;
					IL_01B6:
					if (num6 > 0)
					{
						goto IL_01BE;
					}
					num = 56;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto Block_14;
					}
					goto IL_082B;
					IL_01A9:
					value = num12;
					goto IL_01B6;
					IL_01EC:
					if (num6 > 1)
					{
						goto IL_0264;
					}
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						goto IL_0206;
					}
					goto IL_082B;
					IL_01DA:
					if (num7 > 29)
					{
						return ParseResult.Overflow;
					}
					if (num7 == 29)
					{
						goto IL_01EC;
					}
					goto IL_0310;
					IL_0209:
					num9 = start + length;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_0223;
					}
					goto IL_082B;
					IL_0206:
					num8 = start;
					goto IL_0209;
					IL_07F2:
					if (flag)
					{
						goto IL_0591;
					}
					goto IL_0206;
					IL_0244:
					num7 = 0;
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto IL_025C;
					}
					goto IL_082B;
					IL_0239:
					num13 = 0UL;
					goto IL_0244;
					IL_022E:
					num12 = 0UL;
					goto IL_0239;
					IL_022B:
					num6 = 0;
					goto IL_022E;
					IL_0227:
					num11 = num9;
					goto IL_022B;
					IL_0223:
					num10 = num9;
					goto IL_0227;
					IL_0264:
					value /= new decimal(1, 0, 0, false, (byte)(num6 - 1));
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto IL_005A;
					}
					goto IL_082B;
					IL_02E1:
					num13 = num13 * 10UL + (ulong)((long)(c3 - '0'));
					num = 86;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto IL_039C;
					}
					goto IL_082B;
					IL_0310:
					value /= new decimal(1, 0, 0, false, (byte)num6);
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto Block_13;
					}
					goto IL_082B;
					IL_0361:
					c3 = chars[num8];
					num = 90;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						goto Block_15;
					}
					goto IL_082B;
					IL_0381:
					c3 = chars[num8];
					num = 52;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_039C;
					}
					goto IL_082B;
					IL_03A5:
					if (c3 > '9')
					{
						return ParseResult.Invalid;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						goto IL_03C3;
					}
					goto IL_082B;
					IL_039C:
					if (c3 >= '0')
					{
						goto IL_03A5;
					}
					return ParseResult.Invalid;
					IL_03DA:
					num8++;
					num = 111;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						goto IL_03F5;
					}
					goto IL_082B;
					IL_03D6:
					int num15;
					num6 = num15;
					goto IL_03DA;
					IL_03D0:
					if (num6 < num15)
					{
						goto IL_03D6;
					}
					goto IL_03DA;
					IL_03C3:
					num15 = 10 * num6 + (int)(c3 - '0');
					goto IL_03D0;
					IL_0442:
					num3 = 53;
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						goto IL_045B;
					}
					goto IL_082B;
					IL_0440:
					int? num16;
					num2 = num16;
					goto IL_0442;
					IL_043E:
					num16 = num5;
					goto IL_0440;
					IL_0436:
					num5 = null;
					goto IL_043E;
					IL_041F:
					if (c != null)
					{
						goto IL_0428;
					}
					goto IL_0436;
					IL_041B:
					c = c2;
					goto IL_041F;
					IL_03F5:
					if (value == 7922816251426433759354395033m)
					{
						goto IL_041B;
					}
					goto IL_0B0E;
					IL_0428:
					num16 = new int?((int)c.GetValueOrDefault());
					goto IL_0440;
					IL_045B:
					length--;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto Block_17;
					}
					goto IL_082B;
					IL_0591:
					if (length == 1)
					{
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
						{
							goto Block_21;
						}
						goto IL_082B;
					}
					else
					{
						start++;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
						{
							goto IL_045B;
						}
						goto IL_082B;
					}
				}
				goto Block_49;
			}
			Block_13:
			goto IL_0B26;
			Block_14:
			return ParseResult.Overflow;
			Block_15:
			return ParseResult.Invalid;
			Block_17:
			return ParseResult.Invalid;
			Block_21:
			return ParseResult.Invalid;
			Block_23:
			return ParseResult.Invalid;
			Block_25:
			return ParseResult.Invalid;
			Block_27:
			return ParseResult.Invalid;
			Block_30:
			return ParseResult.Invalid;
			Block_32:
			return ParseResult.Invalid;
			Block_33:
			return ParseResult.Invalid;
			Block_39:
			return ParseResult.Invalid;
			Block_41:
			return ParseResult.Invalid;
			Block_43:
			return ParseResult.Invalid;
			Block_49:
			return ParseResult.Invalid;
			IL_0A80:
			goto IL_0B26;
			IL_0A86:
			if (!(value > 7922816251426433759354395033m))
			{
				goto IL_0B0E;
			}
			return ParseResult.Overflow;
			IL_0AC8:
			value *= new decimal(1, 0, 0, false, (byte)(-(byte)num6));
			goto IL_0B26;
			IL_0AE8:
			value = ((!flag) ? 0m : 0m);
			return ParseResult.Success;
			IL_0B0E:
			value *= 10m;
			IL_0B26:
			if (!flag)
			{
				return ParseResult.Success;
			}
			IL_0B2A:
			value = -value;
			return ParseResult.Success;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00003946 File Offset: 0x00001B46
		public static bool TryConvertGuid(string s, out Guid g)
		{
			return Guid.TryParseExact(s, Class15.smethod_17(1788638140 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), out g);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00042910 File Offset: 0x00040B10
		public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
		{
			for (;;)
			{
				IL_017A:
				value = 0;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
				{
					goto IL_00F4;
				}
				goto IL_010B;
				IL_0006:
				char c;
				while (c > 'f')
				{
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
					{
						goto IL_010B;
					}
				}
				goto IL_0023;
				int num2;
				do
				{
					IL_010B:
					switch (num)
					{
					case 1:
						goto IL_00F4;
					case 2:
						goto IL_017A;
					case 3:
					case 14:
						goto IL_0061;
					case 4:
					case 6:
					case 17:
						goto IL_00A7;
					case 5:
						goto IL_002C;
					case 7:
					case 24:
						goto IL_0006;
					case 8:
					case 10:
						goto IL_009F;
					case 9:
						goto IL_0091;
					case 11:
					case 16:
						goto IL_0097;
					case 12:
					case 20:
						goto IL_0199;
					case 13:
						return false;
					case 15:
						return true;
					case 18:
						if (c < 'A')
						{
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 19:
						goto IL_0070;
					case 21:
						goto IL_0076;
					case 22:
						goto IL_006A;
					case 23:
						goto IL_0023;
					}
					num2 = (int)(c - '7');
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0);
				goto IL_00A7;
				Block_8:
				goto IL_0006;
				IL_002C:
				num2 = (int)(c - 'W');
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					goto IL_0061;
				}
				goto IL_010B;
				IL_0023:
				if (c >= 'a')
				{
					goto IL_002C;
				}
				goto IL_0199;
				IL_0076:
				num2 = (int)(c - '0');
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
				{
					goto IL_00A7;
				}
				goto IL_010B;
				IL_0070:
				if (c >= '0')
				{
					goto IL_0076;
				}
				goto IL_0061;
				IL_006A:
				if (c <= '9')
				{
					goto IL_0070;
				}
				goto IL_0061;
				IL_009F:
				int num3;
				c = text[num3];
				goto IL_006A;
				IL_0097:
				if (num3 < end)
				{
					goto IL_009F;
				}
				break;
				IL_0091:
				num3++;
				goto IL_0097;
				IL_00A7:
				value += num2 << (end - 1 - num3) * 4;
				goto IL_0091;
				IL_00F4:
				num3 = start;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_0097;
				}
				goto IL_010B;
				IL_0061:
				if (c > 'F')
				{
					goto IL_0006;
				}
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					goto IL_002C;
				}
				goto IL_010B;
			}
			return true;
			IL_0199:
			value = 0;
			return false;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00042ABC File Offset: 0x00040CBC
		static ConvertUtils()
		{
			for (;;)
			{
				IL_04D9:
				for (;;)
				{
					IL_04D3:
					for (;;)
					{
						IL_01E9:
						ConvertUtils.dictionary_0 = new Dictionary<Type, PrimitiveTypeCode>
						{
							{
								typeof(char),
								PrimitiveTypeCode.Char
							},
							{
								typeof(char?),
								PrimitiveTypeCode.CharNullable
							},
							{
								typeof(bool),
								PrimitiveTypeCode.Boolean
							},
							{
								typeof(bool?),
								PrimitiveTypeCode.BooleanNullable
							},
							{
								typeof(sbyte),
								PrimitiveTypeCode.SByte
							},
							{
								typeof(sbyte?),
								PrimitiveTypeCode.SByteNullable
							},
							{
								typeof(short),
								PrimitiveTypeCode.Int16
							},
							{
								typeof(short?),
								PrimitiveTypeCode.Int16Nullable
							},
							{
								typeof(ushort),
								PrimitiveTypeCode.UInt16
							},
							{
								typeof(ushort?),
								PrimitiveTypeCode.UInt16Nullable
							},
							{
								typeof(int),
								PrimitiveTypeCode.Int32
							},
							{
								typeof(int?),
								PrimitiveTypeCode.Int32Nullable
							},
							{
								typeof(byte),
								PrimitiveTypeCode.Byte
							},
							{
								typeof(byte?),
								PrimitiveTypeCode.ByteNullable
							},
							{
								typeof(uint),
								PrimitiveTypeCode.UInt32
							},
							{
								typeof(uint?),
								PrimitiveTypeCode.UInt32Nullable
							},
							{
								typeof(long),
								PrimitiveTypeCode.Int64
							},
							{
								typeof(long?),
								PrimitiveTypeCode.Int64Nullable
							},
							{
								typeof(ulong),
								PrimitiveTypeCode.UInt64
							},
							{
								typeof(ulong?),
								PrimitiveTypeCode.UInt64Nullable
							},
							{
								typeof(float),
								PrimitiveTypeCode.Single
							},
							{
								typeof(float?),
								PrimitiveTypeCode.SingleNullable
							},
							{
								typeof(double),
								PrimitiveTypeCode.Double
							},
							{
								typeof(double?),
								PrimitiveTypeCode.DoubleNullable
							},
							{
								typeof(DateTime),
								PrimitiveTypeCode.DateTime
							},
							{
								typeof(DateTime?),
								PrimitiveTypeCode.DateTimeNullable
							},
							{
								typeof(DateTimeOffset),
								PrimitiveTypeCode.DateTimeOffset
							},
							{
								typeof(DateTimeOffset?),
								PrimitiveTypeCode.DateTimeOffsetNullable
							},
							{
								typeof(decimal),
								PrimitiveTypeCode.Decimal
							},
							{
								typeof(decimal?),
								PrimitiveTypeCode.DecimalNullable
							},
							{
								typeof(Guid),
								PrimitiveTypeCode.Guid
							},
							{
								typeof(Guid?),
								PrimitiveTypeCode.GuidNullable
							},
							{
								typeof(TimeSpan),
								PrimitiveTypeCode.TimeSpan
							},
							{
								typeof(TimeSpan?),
								PrimitiveTypeCode.TimeSpanNullable
							},
							{
								typeof(BigInteger),
								PrimitiveTypeCode.BigInteger
							},
							{
								typeof(BigInteger?),
								PrimitiveTypeCode.BigIntegerNullable
							},
							{
								typeof(Uri),
								PrimitiveTypeCode.Uri
							},
							{
								typeof(string),
								PrimitiveTypeCode.String
							},
							{
								typeof(byte[]),
								PrimitiveTypeCode.Bytes
							},
							{
								typeof(DBNull),
								PrimitiveTypeCode.DBNull
							}
						};
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
						{
							return;
						}
						for (;;)
						{
							switch (num)
							{
							case 1:
								ConvertUtils.typeInformation_0 = new TypeInformation[]
								{
									new TypeInformation(typeof(object), PrimitiveTypeCode.Empty),
									new TypeInformation(typeof(object), PrimitiveTypeCode.Object),
									new TypeInformation(typeof(object), PrimitiveTypeCode.DBNull),
									new TypeInformation(typeof(bool), PrimitiveTypeCode.Boolean),
									new TypeInformation(typeof(char), PrimitiveTypeCode.Char),
									new TypeInformation(typeof(sbyte), PrimitiveTypeCode.SByte),
									new TypeInformation(typeof(byte), PrimitiveTypeCode.Byte),
									new TypeInformation(typeof(short), PrimitiveTypeCode.Int16),
									new TypeInformation(typeof(ushort), PrimitiveTypeCode.UInt16),
									new TypeInformation(typeof(int), PrimitiveTypeCode.Int32),
									new TypeInformation(typeof(uint), PrimitiveTypeCode.UInt32),
									new TypeInformation(typeof(long), PrimitiveTypeCode.Int64),
									new TypeInformation(typeof(ulong), PrimitiveTypeCode.UInt64),
									new TypeInformation(typeof(float), PrimitiveTypeCode.Single),
									new TypeInformation(typeof(double), PrimitiveTypeCode.Double),
									new TypeInformation(typeof(decimal), PrimitiveTypeCode.Decimal),
									new TypeInformation(typeof(DateTime), PrimitiveTypeCode.DateTime),
									new TypeInformation(typeof(object), PrimitiveTypeCode.Empty),
									new TypeInformation(typeof(string), PrimitiveTypeCode.String)
								};
								goto IL_0006;
							case 2:
								goto IL_0006;
							case 3:
								goto IL_01E9;
							case 4:
								goto IL_04D3;
							case 5:
								goto IL_04D9;
							}
							return;
							IL_0006:
							ConvertUtils.threadSafeStore_0 = new ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>>(new Func<StructMultiKey<Type, Type>, Func<object, object>>(ConvertUtils.smethod_0));
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
							{
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x0400039B RID: 923
		private static readonly Dictionary<Type, PrimitiveTypeCode> dictionary_0;

		// Token: 0x0400039C RID: 924
		private static readonly TypeInformation[] typeInformation_0;

		// Token: 0x0400039D RID: 925
		[Nullable(new byte[] { 1, 0, 1, 1, 2, 2, 2 })]
		private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> threadSafeStore_0;

		// Token: 0x0200008A RID: 138
		[NullableContext(0)]
		internal enum ConvertResult
		{
			// Token: 0x040003A0 RID: 928
			Success,
			// Token: 0x040003A1 RID: 929
			CannotConvertNull,
			// Token: 0x040003A2 RID: 930
			NotInstantiableType,
			// Token: 0x040003A3 RID: 931
			NoValidConversion
		}
	}
}
